using BlazorStrap.Service;
using LibroNovedades.Models.Neo;
using LibroNovedades.Models.Neo.Views;
using Maestra.DTOs;
using Microsoft.EntityFrameworkCore;

namespace LibroNovedades.Interface.Maestra
{
    public interface IPaisData
    {
        Task<List<PaiDTO>> ObtenerTodosLosPaises();

    }

    public interface IEmpresaData
    {
        Task<List<EmpresasVDTO>> ObtenerEmpresasPorPaies(int idPais);
    }
    public interface ICentroData
    {
        Task<List<CentrosVDTO>> ObtenerTodosLosCentro();

        Task<List<CentrosVDTO>> ObtenerCentrosPorEmpresa(int idEmpresa);
    }

    public interface IDivisionData
    {
        Task<List<DivisionesVDTO>> ObtenerDivisionDelCentro(int idCentro);

    }

    public interface ILineaData
    {
        Task<List<LineaVDTO>> ObtenerTodasLasLineas();
        Task<List<LineaVDTO>> ObtenerLasLineasPorDivision(int idDivision);
    }

    public interface IEquipoEAMData
    {
        Task<List<EquipoEamDTO>> BuscarEquiposSegunLinea(int idLinea);
    }
}