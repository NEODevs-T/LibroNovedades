using Microsoft.EntityFrameworkCore;
using BlazorStrap.Service;
using LibroNovedades.Models.Neo;
using LibroNovedades.DTO;
using LibroNovedades.Models.Neo.Views;

namespace LibroNovedades.Interface
{
    public interface IClasifiTPMData
    {
        Task<List<ClasifiTpmDTO>> ObtenerClasificacion();
    }
    public interface ILibroNovData
    {
        Task<bool> InsertarRegistro(LibroNoveDTO libroNove);
        Task<List<LibroNove>> RegistroDeHoyPorLinea(int idLinea);
        Task<List<LibroNove>> ObtenerLibroNovedadesPorFiltro(int idCentro,DateTime fecha,int idDivision,int idLinea,int tipoClasi,int filtroIsResuelto);
        Task<bool> UpdateRegistros(List<LibroNove> novedades);
        Task<LibroNoveDTO>? ObtenerPorIdParada(string idParada);
        Task<LibroNove>? ObtenerLibroPorId(int idRegistro);
        Task<bool> ActualizacionCompleta(int IdlibrNov,LibroNove data);
        Task<bool> ActualizacionEstado(int IdlibrNov,LibroNove data);
        Task<List<LibroNove>> ObtenerNovedadePorLinea(int IdLiena);
        Task<List<LibroNove>> ObtenerLibroNovedadesDelAreaQueCarga(DateTime fecha,int idCentro,int idDivision,int idLinea,int tipoClasi,int IdAreaCar,int filtroIsResuelto);
        Task<(IEnumerable<IGrouping<DateTime, LibroNove>>,int,int,double)> CalcularCumplimiento(DateTime fechaInicion,DateTime fechafinal,string tipo,int idCondicional);
        Task<List<LibroNove>> ObtenerLibroNovedadesPorFiltroEntreFechas(int idCentro,DateTime fechaInicion,DateTime fechaFinal,int idDivision,int idLinea,int tipoClasi,int filtroIsResuelto);
        Task<List<LibroNove>> ObtenerLibroNovedadesDelAreaQueCargaEntreFechas(DateTime fechaInicion,DateTime fechaFinal,int idCentro,int idDivision,int idLinea,int tipoClasi,int IdAreaCar,int filtroIsResuelto);
    }
    public interface IDataPizarra
    {
        Task<bool> InsertarRegistros(List<ReuDium> reunionDia);
    }
    public interface IDataTiParTP
    {
        Task<TiParTp> ObtenerTipoParadaId(string IdGespline);
        Task<List<TiParTp>> ObtenerTodosTiposNovedad();
    }

    public interface IDataChismoso
    {
        Task<bool> InsertarRegistros(List<CambFec> data,List<CambStat> data2);
    }

}