using Microsoft.EntityFrameworkCore;
using BlazorStrap.Service;
using LibroNovedades.Models.Neo;
using LibroNovedades.Models.Neo.Views;
using LibroNovedades.Interface.Maestra;
using Maestra.DTOs;

namespace LibroNovedades.Data.Maestra
{


    public class PaisData : IPaisData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public PaisData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<PaiDTO>> ObtenerTodosLosPaises()
        {
            url = $"{BaseUrl}/GetPaises/";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<PaiDTO>>(url) ?? new List<PaiDTO>();
        }
    }

    public class EmpresaData : IEmpresaData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public EmpresaData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<EmpresasDTO>> ObtenerEmpresasPorPaies(int idPais)
        {
            url = $"{BaseUrl}/GetEmpresas/{idPais}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<EmpresasDTO>>(url) ?? new List<EmpresasDTO>();
        }
    }

    public class CentroData : ICentroData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public CentroData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<CentrosDTO>> ObtenerTodosLosCentro()
        {
            url = $"{BaseUrl}/GetAllCentros/";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<CentrosDTO>>(url) ?? new List<CentrosDTO>();
        }

        public async Task<List<CentrosDTO>> ObtenerCentrosPorEmpresa(int idEmpresa)
        {
            url = $"{BaseUrl}/GetCentros/{idEmpresa}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<CentrosDTO>>(url) ?? new List<CentrosDTO>();
        }
    }
    public class DivisionData : IDivisionData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public DivisionData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<List<DivisionesDTO>> ObtenerDivisionDelCentro(int idCentro)
        {
            url = $"{BaseUrl}/GetDivisiones/{idCentro}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<DivisionesDTO>>(url) ?? new List<DivisionesDTO>();
        }
    }
    public class LineaData : ILineaData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public LineaData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<LineaDTO>> ObtenerTodasLasLineas()
        {
            url = $"{BaseUrl}/GetAllLineas/";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<LineaDTO>>(url) ?? new List<LineaDTO>();
        }

        public async Task<List<LineaDTO>> ObtenerLasLineasPorDivision(int idDivision)
        {
            url = $"{BaseUrl}/GetLineas/{idDivision}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<LineaDTO>>(url) ?? new List<LineaDTO>();
        }
    }

    public class EquipoEAMData : IEquipoEAMData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public EquipoEAMData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<EquipoEamDTO>> BuscarEquiposSegunLinea(int idLinea)
        {
            url = $"{BaseUrl}/GetEquiposEAMPorLinea/{idLinea}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();
        }
    }

}