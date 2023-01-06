using LibroNovedades.Models;
using LibroNovedades.ModelsDocIng;
using Microsoft.EntityFrameworkCore;

    namespace LibroNovedades.Data.LibroNov
{
    public interface IDataLibroNov
    {
        Task<bool> InsertarRegistro(LibroNove libroNove);
        Task<List<LibroNove>> RegistroDeHoyPorLinea(int idLinea);
        Task<List<LibroNove>> ObtenerLibroNovedadesPorFiltro(int idCentro,DateTime fecha,int idLinea,int tipoNov,string chempoFiltro);
        Task<bool> UpdateRegistros(List<LibroNove> novedades);
        Task<LibroNove>? ObtenerPorIdParada(string idParada);
        Task<bool> ActualizacionCompleta(int IdlibrNov,LibroNove data);
        Task<List<LibroNove>> ObtenerNovedadePorLinea(int IdLiena);
        
    }

    public interface IDataPizarra
    {
        Task<bool> InsertarRegistros(List<ReunionDium> reunionDia);
    }

    public interface IDataClasifiTPM
    {
        Task<List<ClasifiTpm>> ObtenerClasificacion();
    }

    public class DataClasifiTPM :IDataClasifiTPM
    {
        private readonly DbNeoContext _cotext;

        public DataClasifiTPM(DbNeoContext context)
        {
            this._cotext = context;
        }

        public async Task<List<ClasifiTpm>> ObtenerClasificacion()
        {
            return await this._cotext.ClasifiTpms.Where(c => c.Ctpmestado == true).ToListAsync();
        }
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

        public async Task<LibroNove>? ObtenerPorIdParada(string idParada)
        {
            LibroNove data = await this._cotext.LibroNoves.Where(x => x.IdParada == idParada).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> ActualizacionCompleta(int IdlibrNov,LibroNove data){
            LibroNove dataNove = await this._cotext.LibroNoves.Where(x=> x.IdlibrNov == IdlibrNov).FirstOrDefaultAsync();
            if(data != null){
                dataNove.IdLinea = data.IdLinea;
                dataNove.IdAreaCar = data.IdAreaCar;
                dataNove.IdEquipo = data.IdEquipo;
                dataNove.IdlibrNov =  data.IdlibrNov;
                dataNove.IdMaquina = data.IdMaquina;
                dataNove.IdParada = data.IdParada;
                dataNove.IdTipoNove = data.IdTipoNove;
                dataNove.Lndiscrepa = data.Lndiscrepa;
                dataNove.Lnfecha = data.Lnfecha;
                dataNove.LnfichaRes = data.LnfichaRes;
                dataNove.Lngrupo = data.Lngrupo;
                dataNove.LnisPizUni = data.LnisPizUni;
                dataNove.Lnobserv = data.Lnobserv;
                dataNove.LntiePerMi = data.LntiePerMi;
                dataNove.Lnturno = data.Lnturno;
                dataNove.IdCtpm = data.IdCtpm;
                dataNove.LnisResu = data.LnisResu;
                return 0 < await _cotext.SaveChangesAsync();
            }
            return false;         
        }
        public async Task<List<LibroNove>> RegistroDeHoyPorLinea(int idLinea)
        {
            return await this._cotext.LibroNoves.Where(t => t.IdLinea == idLinea && (t.Lnfecha >= DateTime.Today && t.Lnfecha <  DateTime.Today.AddDays(1))).ToListAsync();
        }

        public async Task<List<LibroNove>> ObtenerNovedadePorLinea(int IdLiena){
            return await this._cotext.LibroNoves.Where(l => l.IdLinea == IdLiena).ToListAsync();
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
        public async Task<List<LibroNove>> ObtenerLibroNovedadesPorFiltro(int idCentro,DateTime fecha,int idLinea,int tipoNov,string chempoFiltro)
        {
            if(chempoFiltro == null){
                if(idLinea == 0 && tipoNov == 0 && idCentro == 0){
                    return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1))).Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
                }else if(idLinea == 0 && tipoNov == 0){
                    return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)) && t.IdLineaNavigation.IdCentro == idCentro).Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
                }else if(idLinea == 0){
                    return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)) && (t.IdTipoNove == tipoNov)).Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
                }else if(tipoNov == 0){
                    return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)) && (t.IdLinea == idLinea)).Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
                }else{
                    return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)) && ((t.IdTipoNove == tipoNov) && (t.IdLinea == idLinea))).Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
                }
            }else{
                if(idLinea == 0 && tipoNov == 0){
                    return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)) && t.IdLineaNavigation.IdCentro == idCentro && t.IdParada == chempoFiltro).Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
                }else if(idLinea == 0){
                    return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)) && (t.IdTipoNove == tipoNov) && t.IdParada == chempoFiltro).Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
                }else if(tipoNov == 0){
                    return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)) && (t.IdLinea == idLinea) && t.IdParada == chempoFiltro).Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
                }else{
                    return await this._cotext.LibroNoves.Where(t => (t.Lnfecha >= fecha && t.Lnfecha < fecha.AddDays(1)) && ((t.IdTipoNove == tipoNov) && (t.IdLinea == idLinea)) && t.IdParada == chempoFiltro).Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).ToListAsync();
                }
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
            return await this._cotext.TiParTps.Where(t => t.Tpestado == true).ToListAsync();
        }
    }
    public class DataPizarra : IDataPizarra
    {

        private readonly DbNeoContext _cotext;

        public DataPizarra(DbNeoContext context)
        {
            this._cotext = context;
        }
        public async Task<bool> InsertarRegistros(List<ReunionDium> reunionDia){
            foreach (var item in reunionDia)
            {
                this._cotext.ReunionDia.Add(item);
            }
            return await _cotext.SaveChangesAsync() > 0;
        }
    }
}