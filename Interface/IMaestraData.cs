using BlazorStrap.Service;
using LibroNovedades.Models.Neo;
using LibroNovedades.Models.Neo.Views;
using Microsoft.EntityFrameworkCore;

namespace LibroNovedades.Interface.Maestra
{
    public interface IPaisData
    {
        Task<List<Pai>> ObtenerTodosLosPaises();
    }

    public interface IEmpresaData
    {
        Task<List<EmpresasV>> ObtenerEmpresasPorPaies(int idPais);
    }
    public interface ICentroData
    {
        Task<List<CentrosV>> ObtenerTodosLosCentro();

        Task<List<CentrosV>> ObtenerCentrosPorEmpresa(int idEmpresa);
    }

    public interface IDivisionData
    {
        Task<List<DivisionesV>> ObtenerDivisionDelCentro(int idCentro);
    }

    public interface ILineaData
    {
        Task<List<LineaV>> ObtenerTodasLasLineas();
        Task<List<LineaV>> ObtenerLasLineasPorDivision(int idDivision);
    }

    public interface IEquipoEAMData
    {
        Task<List<EquipoEam>> BuscarEquiposSegunLinea(int idLinea);
    }
}