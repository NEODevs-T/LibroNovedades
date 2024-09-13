using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibroNovedades.Interface;
using LibroNovedades.DTOs;
using ReunionDiaria.DTOs;
using DTOs.Maestra;

namespace LibroNovedades.Data.LibroNov
{

    public class ClasifiTPMData : IClasifiTPMData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/TPM";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public ClasifiTPMData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<ClasifiTpmDTO>> ObtenerClasificacion()
        {
            url = $"{BaseUrl}/GetClasificacionTPM/";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<ClasifiTpmDTO>>(url) ?? new List<ClasifiTpmDTO>();

        }
    }
    public class LibroNovData : ILibroNovData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/LibroNove";

        // private const string BaseUrl = "http://localhost:5021/api/LibroNove";
        private HttpClient cliente { get; set; } = new HttpClient();    //direccion va todo
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public LibroNovData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;     // Constructor
        }
        public async Task<bool> InsertarRegistro(List<LibroNoveDTO> libroNove)
        {
            bool band = false;

            url = $"{BaseUrl}/AddLibroNovedadesNormal";
            cliente = _clientFactory.CreateClient();
            mensaje = await cliente.PostAsJsonAsync(url, libroNove);

            if (mensaje.IsSuccessStatusCode)
            {
            band = await mensaje.Content.ReadFromJsonAsync<bool>();
            }
            else
            {
                // Si no es un estado exitoso, leer el contenido del error
                var errorContent = await mensaje.Content.ReadAsStringAsync();
                
                // Puedes registrar o mostrar el contenido del error para más detalles
                Console.WriteLine($"Error al hacer la solicitud: {errorContent}");

               // Puedes lanzar una excepción o manejar el error de acuerdo a tu necesidad
                throw new HttpRequestException($"La solicitud falló con el código: {mensaje.StatusCode} y el contenido: {errorContent}");
            }

            return band;

        }

        public async Task<LibroNoveDTO>? ObtenerPorIdParada(string idParada)
        {
            url = $"{BaseUrl}/GetNoveadadPorIdParada/{idParada}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<LibroNoveDTO>(url) ?? new LibroNoveDTO();
        }

        public async Task<bool> ActualizacionNovedad(int idlibrNov, LibroNoveDTO data)
        {
            bool band = false;

            url = $"{BaseUrl}/UpdatenNovedad/{idlibrNov}";
            cliente = _clientFactory.CreateClient();
            mensaje = await cliente.PutAsJsonAsync(url, data);

            if (mensaje.IsSuccessStatusCode)
            {
                band = await mensaje.Content.ReadFromJsonAsync<bool>();
            }
            return band;
        }
        public async Task<List<LibroNoveDTO>> RegistroDeHoyPorLinea(int idLinea)
        {
            url = $"{BaseUrl}/GetRegistroDeHoyPorLinea/{idLinea}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<LibroNoveDTO>>(url) ?? new List<LibroNoveDTO>();
        }

        public async Task<List<LibroNoveDTO>> ObtenerNovedadePorLinea(int idLinea)
        {
            url = $"{BaseUrl}/GetObtenerNovedadePorLinea/{idLinea}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<LibroNoveDTO>>(url) ?? new List<LibroNoveDTO>();
        }

        public async Task<bool> UpdateRegistros(List<LibroNoveDTO> novedades)
        {
            bool band = false;

            url = $"{BaseUrl}/UpdateGrupoRegistros";
            cliente = _clientFactory.CreateClient();
            mensaje = await cliente.PutAsJsonAsync(url, novedades);

            if (mensaje.IsSuccessStatusCode)
            {
                band = await mensaje.Content.ReadFromJsonAsync<bool>();
            }
            return band;
        }

public async Task<List<LibroNoveDTO>> ObtenerLibroNovedadesPorFiltro(int idCentro, DateTime fecha, int idDivision, int idLinea, int IdCTPM, int LNIsResu)
{
    try
    {
        // Convertir la fecha al formato yyyy-MM-dd
        string formattedDate = fecha.ToString("yyyy-MM-dd");

        // Formar la URL con la fecha formateada
        url = $"{BaseUrl}/GetLibroNovedadesPorFiltro/{idCentro}/{idDivision}/{idLinea}/{IdCTPM}/{LNIsResu}/{formattedDate}";
        cliente = _clientFactory.CreateClient();

        // Hacer la solicitud HTTP y obtener la respuesta
        var response = await cliente.GetFromJsonAsync<List<LibroNoveDTO>>(url);

        // Verificar si la respuesta es nula
        if (response == null)
        {
            throw new HttpRequestException("La API no devolvió ningún dato. La respuesta es nula.");
        }

        return response;
    }
    catch (HttpRequestException httpEx)
    {
        Console.WriteLine($"Error HTTP: {httpEx.Message}");
        throw;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error general: {ex.Message}");
        throw;
    }
}
        public async Task<List<LibroNoveDTO>> ObtenerLibroNovedadesPorFiltroEntreFechas(int idCentro, DateTime fechaInicio, DateTime fechaFinal, int idDivision, int idLinea, int IdCTPM, int LNIsResu)
        {
            url = $"{BaseUrl}/GetObtenerLibroNovedadesPorFiltroEntreFechas/{idCentro}/{idDivision}/{idLinea}/{IdCTPM}/{LNIsResu}/{fechaInicio}/{fechaFinal}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<LibroNoveDTO>>(url) ?? new List<LibroNoveDTO>();
        }
        public async Task<List<LibroNoveDTO>> ObtenerLibroNovedadesDelAreaQueCarga(DateTime fecha, int idCentro, int idDivision, int idLinea, int IdCTPM, int IdAreaCar, int LNIsResu)
        {
            url = $"{BaseUrl}/GetObtenerLibroNovedadesDelAreaQueCarga/{fecha}/{idCentro}/{idDivision}/{idLinea}/{IdCTPM}/{IdAreaCar}/{LNIsResu}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<LibroNoveDTO>>(url) ?? new List<LibroNoveDTO>();
        }
        public async Task<List<LibroNoveDTO>> ObtenerLibroNovedadesDelAreaQueCargaEntreFechas(DateTime fechaInicio, DateTime fechaFinal, int idCentro, int idDivision, int idLinea, int IdCTPM, int IdAreaCar, int LNIsResu)
        {
            url = $"{BaseUrl}/GetObtenerLibroNovedadesDelAreaQueCargaEntreFechas/{fechaInicio}/{fechaFinal}/{idCentro}/{idDivision}/{idLinea}/{IdCTPM}/{IdAreaCar}/{LNIsResu}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<LibroNoveDTO>>(url) ?? new List<LibroNoveDTO>();
        }
        public async Task<LibroNoveDTO> CalcularCumplimiento(DateTime fechaInicio, DateTime fechafinal, string tipo, int idCondicional)
        {
            url = $"{BaseUrl}/GetCalcularCumplimiento/{fechaInicio}/{fechafinal}/{tipo}/{idCondicional}";
            cliente = _clientFactory.CreateClient();
            var retorno = await cliente.GetFromJsonAsync<LibroNoveDTO>(url) ?? new LibroNoveDTO();
            return retorno;
        }
        public async Task<LibroNoveDTO>? ObtenerLibroPorId(int idRegistro)
        {
            url = $"{BaseUrl}/GetObtenerLibroPorId/{idRegistro}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<LibroNoveDTO>(url) ?? new LibroNoveDTO();
        }

    }
    public class DataTiParTP : IDataTiParTP
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/TipoParada";
        private HttpClient cliente { get; set; } = new HttpClient();    //direccion va todo
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public DataTiParTP(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;     // Constructor
        }
        public async Task<TiParTpDTO> ObtenerTipoParadaId(string IdGespline)
        {
            url = $"{BaseUrl}/GetObtenerTipoParadaId/{IdGespline}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<TiParTpDTO>(url) ?? new TiParTpDTO();
        }

        public async Task<List<TiParTpDTO>> ObtenerTodosTiposNovedad()
        {
            url = $"{BaseUrl}/GetObtenerTodosTiposNovedad";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<TiParTpDTO>>(url) ?? new List<TiParTpDTO>();
        }
    }
    public class DataPizarra : IDataPizarra
    {

        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Pizarra";
        private HttpClient cliente { get; set; } = new HttpClient();    //direccion va todo
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public DataPizarra(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;     // Constructor
        }

        public async Task<bool> InsertarRegistros(List<ReuDiumDTO> reunionDia)
        {
            bool band = false;
            url = $"{BaseUrl}/AddRegistros";
            cliente = _clientFactory.CreateClient();
            mensaje = await cliente.PostAsJsonAsync(url, reunionDia);

            if (mensaje.IsSuccessStatusCode)
            {
                band = await mensaje.Content.ReadFromJsonAsync<bool>();
            }
            return band;
        }

    }
    public class DataAvisador : IDataAvisador
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Avisador";
        private HttpClient cliente { get; set; } = new HttpClient();    //direccion va todo
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public DataAvisador(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;     // Constructor
        }

        public async Task<bool> InsertarRegistros(List<CambFecDTO> data, List<CambStatDTO> data2)
        {
            url = $"{BaseUrl}/AddRegistros";
            cliente = _clientFactory.CreateClient();
            mensaje = await cliente.PostAsJsonAsync(url, (data, data2));
            bool band = false;

            if (mensaje.IsSuccessStatusCode)
            {
                band = await mensaje.Content.ReadFromJsonAsync<bool>();
            }
            return band;
        }
    }
}