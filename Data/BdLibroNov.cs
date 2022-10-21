using LibroNovedades.Models;
using Microsoft.EntityFrameworkCore;

namespace LibroNovedades.Data.LibroNov
{
    public interface IDataLibroNov
    {
        Task<bool> InsertarRegistro(LibroNove libroNove);

        Task<List<LibroNove>> RegistroDeHoyPorLinea(int idLinea);

        Task<List<LibroNove>> ObtenerLibroNovedadesPorFiltro(DateTime fecha,int idLinea,int tipoNov);
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
            return await this._cotext.LibroNoves.Where(t => t.IdLinea == idLinea && (t.Rdfecha >= DateTime.Today && t.Rdfecha <  DateTime.Today.AddDays(1))).ToListAsync();
        }
        public async Task<List<LibroNove>> ObtenerLibroNovedadesPorFiltro(DateTime fecha,int idLinea,int tipoNov)
        {
            if(idLinea == 0 && tipoNov == 0){
                return await this._cotext.LibroNoves.Where(t => t.Rdfecha >= fecha && t.Rdfecha < fecha.AddDays(1)).Include(t => t.IdLineaNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
            }else if(idLinea == 0){
                return await this._cotext.LibroNoves.Where(t => (t.Rdfecha >= fecha && t.Rdfecha < fecha.AddDays(1)) && (t.IdTipoNove == tipoNov)).Include(t => t.IdLineaNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
            }else if(tipoNov == 0){
                return await this._cotext.LibroNoves.Where(t => (t.Rdfecha >= fecha && t.Rdfecha < fecha.AddDays(1)) && (t.IdLinea == idLinea)).Include(t => t.IdLineaNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
            }else{
                return await this._cotext.LibroNoves.Where(t => (t.Rdfecha >= fecha && t.Rdfecha < fecha.AddDays(1)) && ((t.IdTipoNove == tipoNov) && (t.IdLinea == idLinea))).Include(t => t.IdLineaNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
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
}