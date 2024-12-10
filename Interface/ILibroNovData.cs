using Microsoft.EntityFrameworkCore;
using BlazorStrap.Service;
using ReunionDiaria.DTOs;
using LibroNovedades.DTOs;

namespace LibroNovedades.Interface
{
    public interface IClasifiTPMData
    {
        Task<List<ClasifiTpmDTO>> ObtenerClasificacion();
    }
    public interface ILibroNovData
    {
        Task<bool> InsertarRegistro(List<LibroNoveDTO> libroNove);
        Task<List<LibroNoveDTO>> RegistroDeHoyPorLinea(int idLinea);
        Task<List<LibroNoveDTO>> ObtenerLibroNovedadesPorFiltro(int idCentro, DateTime fecha, int idDivision, int idLinea, int tipoClasi, int filtroIsResuelto);
        Task<bool> UpdateRegistros(List<LibroNoveDTO> novedades);
        Task<LibroNoveDTO>? ObtenerPorIdParada(string idParada);
        Task<LibroNoveDTO>? ObtenerLibroPorId(int idRegistro);
        Task<bool> ActualizacionNovedad(int idlibrNov, LibroNoveDTO data);
        Task<List<LibroNoveDTO>> ObtenerNovedadePorLinea(int IdLiena);
        Task<List<LibroNoveDTO>> ObtenerLibroNovedadesDelAreaQueCarga(DateTime fecha, int idCentro, int idDivision, int idLinea, int tipoClasi, int IdAreaCar, int filtroIsResuelto);
        Task<LibroNoveDTO> CalcularCumplimiento(DateTime fechaInicion, DateTime fechafinal, string tipo, int idCondicional);
        Task<List<LibroNoveDTO>> ObtenerLibroNovedadesPorFiltroEntreFechas(int idCentro, DateTime fechaInicion, DateTime fechaFinal, int idDivision, int idLinea, int tipoClasi, int filtroIsResuelto);
        Task<List<LibroNoveDTO>> ObtenerLibroNovedadesDelAreaQueCargaEntreFechas(DateTime fechaInicion, DateTime fechaFinal, int idCentro, int idDivision, int idLinea, int tipoClasi, int IdAreaCar, int filtroIsResuelto);
    }
    public interface IDataPizarra
    {
        Task<bool> InsertarRegistros(RegistroCambiosDTO registroCambios);

    }
    public interface IDataTiParTP
    {
        Task<TiParTpDTO> ObtenerTipoParadaId(string IdGespline);
        Task<List<TiParTpDTO>> ObtenerTodosTiposNovedad();
    }

    public interface IDataAvisador
    {
        Task<bool> InsertarRegistros(RegistroCambiosDTO registroCambios);
        Task<bool> InsertCambioStatus(CambStatDTO status);
        Task<bool> InsertCambioFec(CambFecDTO cambiofec);
    }

}