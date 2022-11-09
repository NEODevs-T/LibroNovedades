using LibroNovedades.Models;
using LibroNovedades.ModelsDocIng;
using Microsoft.EntityFrameworkCore;

    namespace LibroNovedades.Data.LibroNov
{
    public interface IDataLibroNov
    {
        Task<bool> InsertarRegistro(LibroNove libroNove);
        Task<List<LibroNove>> RegistroDeHoyPorLinea(int idLinea);
        Task<List<LibroNove>> ObtenerLibroNovedadesPorFiltro(DateTime fecha,int idLinea,int tipoNov);
        Task<bool> UpdateRegistros(List<LibroNove> novedades);
    }

    public interface IDataPizarra
    {
        Task<bool> InsertarRegistros(List<BdDiv1> bdDiv1);
    }

    public interface IDataTiParTP
    {
        Task<TiParTp> ObtenerTipoParadaId(string IdGespline);

        Task<List<TiParTp>> ObtenerTodosTiposNovedad();
    }


    public class DataLibroNov : IDataLibroNov
    {
        private readonly DbNeoContext _cotext;

        public DataLibroNov(DbNeoContext context)
        {
            this._cotext = context;
        }
        public async Task<bool> InsertarRegistro(LibroNove libroNove)
        {
            this._cotext.LibroNoves.Add(libroNove);
            return await _cotext.SaveChangesAsync() > 0;
        }
        public async Task<List<LibroNove>> RegistroDeHoyPorLinea(int idLinea)
        {
            return await this._cotext.LibroNoves.Where(t => t.IdLinea == idLinea && (t.Lnfecha >= DateTime.Today && t.Lnfecha <  DateTime.Today.AddDays(1))).ToListAsync();
        }

        public async Task<bool> UpdateRegistros(List<LibroNove> novedades)
        {
            LibroNove registro;
            foreach (var item in novedades)
            {
                try{
                    registro = await this._cotext.LibroNoves.FirstOrDefaultAsync(x => x.IdlibrNov == item.IdlibrNov);
                    if(registro != null){
                        registro.LnisPizUni =  item.LnisPizUni;
                    }
                    await _cotext.SaveChangesAsync();
                }catch{
                    try{
                        registro = await this._cotext.LibroNoves.FirstOrDefaultAsync(x => x.IdlibrNov == item.IdlibrNov);
                        if(registro != null){
                            registro.LnisPizUni =  item.LnisPizUni;
                        }
                        await _cotext.SaveChangesAsync();
                    }catch{
                        return false;
                    }
                }
            }
            return true;
        }
        public async Task<List<LibroNove>> ObtenerLibroNovedadesPorFiltro(DateTime fecha,int idLinea,int tipoNov)
        {
            if(idLinea == 0 && tipoNov == 0){
                return await this._cotext.LibroNoves.Where(t => t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)).Include(t => t.IdLineaNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
            }else if(idLinea == 0){
                return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)) && (t.IdTipoNove == tipoNov)).Include(t => t.IdLineaNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
            }else if(tipoNov == 0){
                return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)) && (t.IdLinea == idLinea)).Include(t => t.IdLineaNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
            }else{
                return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)) && ((t.IdTipoNove == tipoNov) && (t.IdLinea == idLinea))).Include(t => t.IdLineaNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
            }
        }
    }
    public class DataTiParTP : IDataTiParTP
    {
        private readonly DbNeoContext _cotext;

        public DataTiParTP(DbNeoContext context)
        {
            this._cotext = context;
        }
        public async Task<TiParTp> ObtenerTipoParadaId(string IdGespline){
            return await this._cotext.TiParTps.Where(t => t.Tpcodigo == IdGespline).FirstOrDefaultAsync();
        }

        public async Task<List<TiParTp>> ObtenerTodosTiposNovedad(){
            return await this._cotext.TiParTps.ToListAsync();
        }
    }
    public class DataPizarra : IDataPizarra
    {

        private readonly DOC_IngIContext _cotext;

        public DataPizarra(DOC_IngIContext context)
        {
            this._cotext = context;
        }
        public async Task<bool> InsertarRegistros(List<BdDiv1> bdDiv1){
            foreach (var item in bdDiv1)
            {
                this._cotext.BdDiv1s.Add(item);
            }
            return await _cotext.SaveChangesAsync() > 0;
        }
    }
}