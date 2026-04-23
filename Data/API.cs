using System.Net.Http;
using System.Net.Http.Json;
using LibroNovedades.DTOs;
using System.Text.Json;

namespace LibroNovedades.Data.API
{
    public class DataAPI : IDataAPI
    {

        private readonly HttpClient _cliente;

        public DataAPI(HttpClient cliente)
        {
            _cliente = cliente;
        }

        private async Task<T?> TryGetAsync<T>(string url)
        {
            try
            {
                return await _cliente.GetFromJsonAsync<T>(url);
            }
            catch
            {
                return default;
            }
        }

        public async Task<List<ParadasActualesDTO>?> GetParadasActuales1Turno(string centroCosto)
        {
            var url = $"http://neo.grandbay-corp.com/ApiNeoMasterP/api/GesplineParadasEjecutadas/GetParadasActuales1Turno?centroCosto={Uri.EscapeDataString(centroCosto)}";
            return await TryGetAsync<List<ParadasActualesDTO>>(url);
        }

        public async Task<List<ParadasActualesAgrupadasDTO>?> GetParadasActuales1TurnoAgrupados(string centroCosto)
        {
            var url = $"http://neo.grandbay-corp.com/ApiNeoMasterP/api/GesplineParadasEjecutadas/GetParadasActuales1TurnoAgrupados?centroCosto={Uri.EscapeDataString(centroCosto)}";
            return await TryGetAsync<List<ParadasActualesAgrupadasDTO>>(url);
        }

        public async Task<List<ParadasActualesAgrupadasDTO>?> GetParadasActuales2TurnoDespuesDeLas0amAgrupadas(string centroCosto)
        {
            var url = $"http://neo.grandbay-corp.com/ApiNeoMasterP/api/GesplineParadasEjecutadas/GetParadasActuales2TurnoDespuesDeLas0amAgrupadas?centroCosto={Uri.EscapeDataString(centroCosto)}";
            return await TryGetAsync<List<ParadasActualesAgrupadasDTO>>(url);
        }

        public async Task<List<ParadasActualesAgrupadasDTO>?> GetParadasActuales2TurnoAntesDeLas0amAgrupadas(string centroCosto)
        {
            var url = $"http://neo.grandbay-corp.com/ApiNeoMasterP/api/GesplineParadasEjecutadas/GetParadasActuales2TurnoAntesDeLas0amAgrupadas?centroCosto={Uri.EscapeDataString(centroCosto)}";
            return await TryGetAsync<List<ParadasActualesAgrupadasDTO>>(url);
        }

        public async Task<List<ParadasActualesDTO>?> GetParadasActuales2Turno(string centroCosto)
        {
            var url = $"http://neo.grandbay-corp.com/ApiNeoMasterP/api/GesplineParadasEjecutadas/GetParadasActuales2Turno?centroCosto={Uri.EscapeDataString(centroCosto)}";
            return await TryGetAsync<List<ParadasActualesDTO>>(url);
        }

        public async Task<List<ParadasActualesAgrupadasDTO>> GetParadasActualesTurnoPorLineaAgrupadas(string centroCosto)
        {
            int hora = DateTime.Now.Hour;

            if (hora >= 6 && hora < 18)
                return await GetParadasActuales1TurnoAgrupados(centroCosto)
                        ?? new List<ParadasActualesAgrupadasDTO>();

            if (hora >= 18)
                return await GetParadasActuales2TurnoAntesDeLas0amAgrupadas(centroCosto)
                        ?? new List<ParadasActualesAgrupadasDTO>();

            var antes = await GetParadasActuales2TurnoAntesDeLas0amAgrupadas(centroCosto)
                        ?? new List<ParadasActualesAgrupadasDTO>();

            var despues = await GetParadasActuales2TurnoDespuesDeLas0amAgrupadas(centroCosto)
                        ?? new List<ParadasActualesAgrupadasDTO>();

            antes.AddRange(despues);
            return antes;
        }

    public async Task<GrupoTurnoDTO> ObtenerTurnoYGrupo()
    {
        var url = "http://neo.grandbay-corp.com/ApiNeoMasterP/api/Global/GetGrupoYTurnoActual";

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var response = await _cliente.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var data = await response.Content.ReadFromJsonAsync<GrupoTurnoDTO>(options);

        return data ?? new GrupoTurnoDTO();
    }


      /*      public async Task<List<List<string>>>? obtenerParadasActualesturnoPorLinea(string centroCosto, List<LibroNoveDTO> listaNove)
        {
            DateTime hora = DateTime.Now;
            if (hora.Hour >= 6 && hora.Hour < 18)
            {
                return await this.obtenerParadasActuales1turnoPorLinea(centroCosto, listaNove);
            }
            else
            {
                return await this.obtenerParadasActuales2turnoPorLinea(centroCosto, listaNove);
            }
        }*/

      /*  public async Task<List<List<string>>>? GetParadasActuales1Turno(string centroCosto, List<LibroNoveDTO> listaNove)
        {
            string ParadasIgnorar = "[";
            List<List<string>> data = new List<List<string>>();
            this.cliente = new HttpClient();
            if (centroCosto != "")
            {
                if (listaNove.Count == 0)
                {
                    return await this.GetParadasActuales1Turno(centroCosto);
                }
                else
                {
                    for (int i = 0; i < listaNove.Count; i++)
                    {
                        if (listaNove[i].IdParada != null)
                        {
                            if (i == listaNove.Count - 1)
                            {
                                ParadasIgnorar += listaNove[i].IdParada.ToString().Substring(1);
                            }
                            else
                            {
                                ParadasIgnorar += listaNove[i].IdParada.ToString().Substring(1) + ",";
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    ParadasIgnorar += "]";
                }
                if (ParadasIgnorar == "[]")
                {
                    return await this.GetParadasActuales1Turno(centroCosto);
                }
                string url = "http://neo.grandbay-corp.com/ApiNeoMasterP/gespline/obtenerParadasActuales1turnoPorLinea/" + centroCosto + "/" + ParadasIgnorar;
                data = await cliente.GetFromJsonAsync<List<List<string>>>(url);
                return data;
            }
            return data;
        }

        public async Task<List<List<string>>>? obtenerParadasActuales2turnoPorLinea(string centroCosto, List<LibroNoveDTO> listaNove)
        {
            string ParadasIgnorar = "[";
            List<List<string>> data = new List<List<string>>();
            this.cliente = new HttpClient();
            if (centroCosto != "")
            {
                if (listaNove.Count == 0)
                {
                    return await this.obtenerParadasActuales2turnoPorLinea(centroCosto);
                }
                else
                {
                    for (int i = 0; i < listaNove.Count; i++)
                    {
                        if (listaNove[i].IdParada != null)
                        {
                            if (i == listaNove.Count - 1)
                            {
                                ParadasIgnorar += listaNove[i].IdParada.ToString().Substring(1);
                            }
                            else
                            {
                                ParadasIgnorar += listaNove[i].IdParada.ToString().Substring(1) + ",";
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    ParadasIgnorar += "]";
                }
                string url = "http://neo.grandbay-corp.com/ApiNeoMasterP/gespline/ObtenerParadasSegundoTurnoPorMaquina/" + centroCosto + "/" + ParadasIgnorar;
                data = await cliente.GetFromJsonAsync<List<List<string>>>(url);
                return data;
            }
            return data;
        }

        public async Task<Dictionary<string, string>>? obtenerUsuario(string ficha)
        {
            Dictionary<string, string> usuario = new Dictionary<string, string>();
            string url = "http://neo.grandbay-corp.com/ApiNeoMasterP/usuario/BuscarUsuarioPorFicha/" + ficha;
            this.cliente = new HttpClient();
            usuario = await cliente.GetFromJsonAsync<Dictionary<string, string>>(url);
            return usuario;
        }

        // public async Task<System.Net.Http.HttpResponseMessage> PostDiscrepancia(BdDiv1 bdDiv1)
        // {   


        //     //return true;
        //     // await SetAsistencia(result);
        // }*/

    }
}