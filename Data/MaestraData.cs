using Microsoft.EntityFrameworkCore;
using BlazorStrap.Service;


using LibroNovedades.Interface.Maestra;
using Maestra.DTOs;
using DTOs.Maestra;

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
    public class MaestraData : IMaestraData
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private const string BaseUrl2 = "http://localhost:5021/api/Maestra";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public MaestraData(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<MaestraVDTO>> GetMaestraId(int idMaster)

        {
            url = $"{BaseUrl2}/GetMaestraId/{idMaster}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<MaestraVDTO>>(url) ?? new List<MaestraVDTO>();
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

        public async Task<List<EmpresasVDTO>> ObtenerEmpresasPorPaies(int idPais)
        {
            url = $"{BaseUrl}/GetEmpresas/{idPais}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<EmpresasVDTO>>(url) ?? new List<EmpresasVDTO>();
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

        public async Task<List<CentrosVDTO>> ObtenerTodosLosCentro()
        {
            url = $"{BaseUrl}/GetAllCentros/";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<CentrosVDTO>>(url) ?? new List<CentrosVDTO>();
        }

        public async Task<List<CentrosVDTO>> ObtenerCentrosPorEmpresa(int idEmpresa)
        {
            url = $"{BaseUrl}/GetCentros/{idEmpresa}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<CentrosVDTO>>(url) ?? new List<CentrosVDTO>();
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
        public async Task<List<DivisionesVDTO>> ObtenerDivisionDelCentro(int idCentro)
        {
            url = $"{BaseUrl}/GetDivisiones/{idCentro}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<DivisionesVDTO>>(url) ?? new List<DivisionesVDTO>();
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

        public async Task<List<LineaVDTO>> ObtenerTodasLasLineas()
        {
            url = $"{BaseUrl}/GetAllLineas/";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<LineaVDTO>>(url) ?? new List<LineaVDTO>();
        }

        public async Task<List<LineaVDTO>> ObtenerLasLineasPorDivision(int idDivision)
        {
            url = $"{BaseUrl}/GetLineas/{idDivision}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<LineaVDTO>>(url) ?? new List<LineaVDTO>();
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