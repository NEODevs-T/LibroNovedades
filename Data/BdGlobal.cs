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

        Task<List<Linea>> ObtenerTodasLasLineas();
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
            if(idCentro == 0){
                return await _cotext.Lineas.Where(x => x.Lestado == true).ToListAsync();
            }else if(idCentro == -1){
                return null;
            }else{
                return await _cotext.Lineas.Include(l => l.IdDivisionNavigation).Where(l => l.IdDivisionNavigation.IdCentro == idCentro).ToListAsync();
            }
        }
        public async Task<List<Linea>> ObtenerTodasLasLineas(){
            return await _cotext.Lineas.OrderBy(l => l.Lnom).ToListAsync();
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