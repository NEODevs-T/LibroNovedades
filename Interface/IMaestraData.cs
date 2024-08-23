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
        Task<List<EmpresasDTO>> ObtenerEmpresasPorPaies(int idPais);
    }
    public interface ICentroData
    {
        Task<List<CentrosDTO>> ObtenerTodosLosCentro();

        Task<List<CentrosDTO>> ObtenerCentrosPorEmpresa(int idEmpresa);
    }

    public interface IDivisionData
    {
        Task<List<DivisionesDTO>> ObtenerDivisionDelCentro(int idCentro);

    }

    public interface ILineaData
    {
        Task<List<LineaDTO>> ObtenerTodasLasLineas();
        Task<List<LineaDTO>> ObtenerLasLineasPorDivision(int idDivision);
    }

    public interface IEquipoEAMData
    {
        Task<List<EquipoEamDTO>> BuscarEquiposSegunLinea(int idLinea);
    }
}