using LibroNovedades.Models;
using Microsoft.EntityFrameworkCore;

namespace LibroNovedades.Data.Global
{
    public interface IDataCentro
    {
        Task<List<Centro>> ObtenerTodosLosCentro();
    }

    public interface IDataLinea
    {
        Task<List<Linea>> ObtenerLasLineasPorCentro(int idCentro);
    }

    public interface IDataArea
    {
        Task<List<LinAre>> ObtenerLasAreasPorLinea(int idLinea);
    }

    public class DataCentro : IDataCentro
    {
        private readonly DbNeoContext _cotext;

        public DataCentro(DbNeoContext context)
        {
            this._cotext = context;
        }
        public async Task<List<Centro>> ObtenerTodosLosCentro(){
            return await _cotext.Centros.Where(x => x.Cestado == true).ToListAsync();
        }
    }
    public class DataLinea : IDataLinea
    {
        private readonly DbNeoContext _cotext;

        public DataLinea(DbNeoContext context)
        {
            this._cotext = context;
        }
        public async Task<List<Linea>> ObtenerLasLineasPorCentro(int idCentro)
        {
            return await _cotext.Lineas.Where(x => x.IdCentro == idCentro && x.Lestado == true).ToListAsync();
        }
    }
    public class DataArea : IDataArea
    {
        private readonly DbNeoContext _cotext;

        public DataArea(DbNeoContext context)
        {
            this._cotext = context;
        }
        public async Task<List<LinAre>> ObtenerLasAreasPorLinea(int idLinea)
        {
            return await _cotext.LinAres.Where(x => x.IdLinea == idLinea && x.IdAreaNavigation.Aestado == true).Include(x => x.IdAreaNavigation).ToListAsync();//.Include(x => x.IdArea).ToListAsync();
        }   
    }
}