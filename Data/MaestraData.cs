using BlazorStrap.Service;
using LibroNovedades.Models.Neo;
using LibroNovedades.Models.Neo.Views;
using Microsoft.EntityFrameworkCore;
using LibroNovedades.Interface.Maestra;

namespace LibroNovedades.Data.Maestra
{


    public class PaisData : IPaisData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url {get; set;} = "";

        public PaisData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<Pai>> ObtenerTodosLosPaises(){
            url = $"{BaseUrl}/GetPaises/";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<Pai>>(url) ?? new List<Pai>();
        }
    }

    public class EmpresaData : IEmpresaData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url {get; set;} = "";

        public EmpresaData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<EmpresasV>> ObtenerEmpresasPorPaies(int idPais){
            url = $"{BaseUrl}/GetEmpresas/{idPais}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<EmpresasV>>(url) ?? new List<EmpresasV>();
        }
    }

    public class CentroData : ICentroData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url {get; set;} = "";

        public CentroData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<CentrosV>> ObtenerTodosLosCentro(){
            url = $"{BaseUrl}/GetAllCentros/";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<CentrosV>>(url) ?? new List<CentrosV>();
        }

        public async Task<List<CentrosV>> ObtenerCentrosPorEmpresa(int idEmpresa){
            url = $"{BaseUrl}/GetCentros/{idEmpresa}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<CentrosV>>(url) ?? new List<CentrosV>();
        }
    }
    public class DivisionData : IDivisionData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url {get; set;} = "";

        public DivisionData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<List<DivisionesV>> ObtenerDivisionDelCentro(int idCentro){
            url = $"{BaseUrl}/GetDivisiones/{idCentro}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<DivisionesV>>(url) ?? new List<DivisionesV>();
        }
    }
    public class LineaData : ILineaData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url {get; set;} = "";

        public LineaData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<LineaV>> ObtenerTodasLasLineas(){
            url = $"{BaseUrl}/GetAllLineas/";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<LineaV>>(url) ?? new List<LineaV>();
        }

        public async Task<List<LineaV>> ObtenerLasLineasPorDivision(int idDivision){
            url = $"{BaseUrl}/GetLineas/{idDivision}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<LineaV>>(url) ?? new List<LineaV>();
        }
    }

    public class EquipoEAMData : IEquipoEAMData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url {get; set;} = "";

        public EquipoEAMData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<EquipoEam>> BuscarEquiposSegunLinea(int idLinea){
            url = $"{BaseUrl}/GetEquiposEAMPorLinea/{idLinea}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<EquipoEam>>(url) ?? new List<EquipoEam>();
        }
    }
    
}