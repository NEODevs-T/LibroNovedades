using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibroNovedades.Models.Neo;
using LibroNovedades.ModelsDocIng;
using LibroNovedades.Interface;
using LibroNovedades.DTO;


    namespace LibroNovedades.Data.LibroNov
    {
        
        public class ClasifiTPMData :IClasifiTPMData
        {
            private readonly IHttpClientFactory _clientFactory;
            private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/TPM";
            private HttpClient cliente { get; set; } = new HttpClient();
            private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
            private string url {get; set;} = "";

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
            private HttpClient cliente { get; set; } = new HttpClient();
            private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
            private string url {get; set;} = "";

            public LibroNovData(IHttpClientFactory clientFactory)
            {
                _clientFactory = clientFactory;
            }
            public async Task<bool> InsertarRegistro(LibroNoveDTO libroNove)
            {
                bool band = false;

                url = $"{BaseUrl}/AddLibroNovedadesNormal";
                cliente =  _clientFactory.CreateClient();
                mensaje = await cliente.PostAsJsonAsync(url,libroNove);

                if(mensaje.IsSuccessStatusCode){
                    band = await mensaje.Content.ReadFromJsonAsync<bool>();
                }
                return band;
            }

            public async Task<LibroNoveDTO>? ObtenerPorIdParada(string idParada)
            {
                url = $"{BaseUrl}/GetNoveadadPorIdParada/{idParada}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<LibroNoveDTO>(url) ?? new LibroNoveDTO();
            }

            public async Task<bool> ActualizacionNovedad(int idlibrNov,LibroNoveDTO data){
                bool band = false;

                url = $"{BaseUrl}/UpdatenNovedad/{idlibrNov}";
                cliente = _clientFactory.CreateClient();
                mensaje = await cliente.PutAsJsonAsync(url,data);

                if(mensaje.IsSuccessStatusCode){
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

            public async Task<List<LibroNoveDTO>> ObtenerNovedadePorLinea(int idLinea){
                url = $"{BaseUrl}/GetObtenerNovedadePorLinea/{idLinea}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<LibroNoveDTO>>(url) ?? new List<LibroNoveDTO>();
            }
            
            public async Task<bool> UpdateRegistros(List<LibroNoveDTO> novedades)
            {
                bool band = false;

                url = $"{BaseUrl}/UpdateGrupoRegistros";
                cliente = _clientFactory.CreateClient();
                mensaje = await cliente.PutAsJsonAsync(url,novedades);

                if(mensaje.IsSuccessStatusCode){
                    band = await mensaje.Content.ReadFromJsonAsync<bool>();
                }
                return band;
            }

            public async Task<List<LibroNove>> ObtenerLibroNovedadesPorFiltro(int idCentro,DateTime fecha,int idDivision,int idLinea,int tipoClasi,int filtroIsResuelto)
            {
                List<LibroNove> libroNov = new List<LibroNove>();
                if (tipoClasi == 0){
                    if(idCentro != 0 && idDivision != 0 && idLinea != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision && t.IdLinea == idLinea))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0 && idDivision != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else{
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }
                }else{
                    if(idCentro != 0 && idDivision != 0 && idLinea != 0){
                            libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision && t.IdLinea == idLinea) && (t.IdCtpm == tipoClasi))
                            .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0 && idDivision != 0){
                            libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision) && (t.IdCtpm == tipoClasi))
                            .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0){
                            libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro) && (t.IdCtpm == tipoClasi))
                            .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else{
                            libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdCtpm == tipoClasi))
                            .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }
                }
                if(filtroIsResuelto == 0){
                    libroNov = libroNov.Where(l => l.LnisResu == 0).ToList();
                }else if(filtroIsResuelto == 1){
                    libroNov = libroNov.Where(l => l.LnisResu == 1).ToList();
                }
                return libroNov;
            }

            public async Task<List<LibroNove>> ObtenerLibroNovedadesPorFiltroEntreFechas(int idCentro,DateTime fechaInicion,DateTime fechaFinal,int idDivision,int idLinea,int tipoClasi,int filtroIsResuelto)
            {
                List<LibroNove> libroNov = new List<LibroNove>();

                if (tipoClasi != 0){
                    if(idCentro != 0 && idDivision != 0 && idLinea != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision && t.IdLinea == idLinea) && (t.IdCtpm == tipoClasi))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0 && idDivision != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision) && (t.IdCtpm == tipoClasi))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro)&& (t.IdCtpm == tipoClasi))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else{
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdCtpm == tipoClasi))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }
                }else{
                    if(idCentro != 0 && idDivision != 0 && idLinea != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision && t.IdLinea == idLinea))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0 && idDivision != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }else{
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).Include(l => l.IdAreaCarNavigation).AsNoTracking().ToListAsync();
                    }
                }

                if(filtroIsResuelto == 0){
                    libroNov = libroNov.Where(l => l.LnisResu == 0).ToList();
                }else if(filtroIsResuelto == 1){
                    libroNov = libroNov.Where(l => l.LnisResu == 1).ToList();
                }
                return libroNov;
            }
            public async Task<List<LibroNove>> ObtenerLibroNovedadesDelAreaQueCarga(DateTime fecha,int idCentro,int idDivision,int idLinea,int tipoClasi,int IdAreaCar, int filtroIsResuelto)
            {
                List<LibroNove> libroNov = new List<LibroNove>();
                if (tipoClasi == 0){
                    if(idCentro != 0 && idDivision != 0 && idLinea != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision && t.IdLinea == idLinea) &&  (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0 && idDivision != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision) &&  (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro) &&  (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else{
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) &&  (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }
                }else{
                    if(idCentro != 0 && idDivision != 0 && idLinea != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision && t.IdLinea == idLinea) && (t.IdCtpm == tipoClasi) &&  (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0 && idDivision != 0){
                            libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision) && (t.IdCtpm == tipoClasi) &&  (t.IdAreaCar == IdAreaCar))
                            .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro) && (t.IdCtpm == tipoClasi) && (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else{
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date == fecha.Date) && (t.IdCtpm == tipoClasi) && (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }
                }

                if(filtroIsResuelto == 0){
                    libroNov = libroNov.Where(l => l.LnisResu == 0).ToList();
                }else if(filtroIsResuelto == 1){
                    libroNov = libroNov.Where(l => l.LnisResu == 1).ToList();
                }
                return libroNov;
            }

            public async Task<List<LibroNove>> ObtenerLibroNovedadesDelAreaQueCargaEntreFechas(DateTime fechaInicion,DateTime fechaFinal,int idCentro,int idDivision,int idLinea,int tipoClasi,int IdAreaCar, int filtroIsResuelto)
            {
                List<LibroNove> libroNov = new List<LibroNove>();
                if (tipoClasi != 0){
                    if(idCentro != 0 && idDivision != 0 && idLinea != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision && t.IdLinea == idLinea) && (t.IdCtpm == tipoClasi) && (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0 && idDivision != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision) && (t.IdCtpm == tipoClasi) && (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro)&& (t.IdCtpm == tipoClasi) && (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else{
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdCtpm == tipoClasi) && (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }
                }else{
                    if(idCentro != 0 && idDivision != 0 && idLinea != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision && t.IdLinea == idLinea) && (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0 && idDivision != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro && t.IdLineaNavigation.IdDivision == idDivision) && (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else if(idCentro != 0){
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCentro) && (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }else{
                        libroNov = await this._cotext.LibroNoves.Where(t => (t.Lnfecha.Date >= fechaInicion.Date && t.Lnfecha.Date <= fechaFinal.Date) && (t.IdAreaCar == IdAreaCar))
                        .Include(t => t.IdLineaNavigation).ThenInclude(L => L.IdDivisionNavigation).ThenInclude(L => L.IdCentroNavigation).Include(t => t.IdTipoNoveNavigation).AsNoTracking().ToListAsync();
                    }
                }

                if(filtroIsResuelto == 0){
                    libroNov = libroNov.Where(l => l.LnisResu == 0).ToList();
                }else if(filtroIsResuelto == 1){
                    libroNov = libroNov.Where(l => l.LnisResu == 1).ToList();
                }
                return libroNov;
            }
            public async Task<(IEnumerable<IGrouping<DateTime, LibroNove>>,int,int,double)> CalcularCumplimiento(DateTime fechaInicion,DateTime fechafinal,string tipo,int idCondicional)
            {
                IEnumerable<IGrouping<DateTime, LibroNove>> data;
                List<LibroNove> libroNov = new List<LibroNove>();
                int diasReales = 0;
                double cumplimiento;
                int diasToricos = (fechafinal.Day - fechaInicion.Day) + 1;
                if(tipo == "Centro"){
                    libroNov = await this._cotext.LibroNoves.Where(l => l.IdLineaNavigation.IdDivisionNavigation.IdCentro == idCondicional && (l.Lnfecha.Date >= fechaInicion.Date &&  l.Lnfecha.Date <= fechafinal.Date)).Include(t => t.IdLineaNavigation).ToListAsync(); //.Select(l => new LibroNove() {Lnfecha = l.Lnfecha})
                }else if(tipo == "Division"){
                    libroNov = await this._cotext.LibroNoves.Where(l => l.IdLineaNavigation.IdDivision == idCondicional && (l.Lnfecha.Date >= fechaInicion.Date &&  l.Lnfecha.Date <= fechafinal.Date)).Include(t => t.IdLineaNavigation).ToListAsync(); //.Select(l => new LibroNove() {Lnfecha = l.Lnfecha})
                }else if(tipo == "Linea"){
                    libroNov = await this._cotext.LibroNoves.Where(l => l.IdLineaNavigation.IdLinea == idCondicional && (l.Lnfecha.Date >= fechaInicion.Date &&  l.Lnfecha.Date <= fechafinal.Date)).Include(t => t.IdLineaNavigation).ToListAsync(); //.Select(l => new LibroNove() {Lnfecha = l.Lnfecha})
                }
                data = libroNov.GroupBy(l => l.Lnfecha.Date);
                diasReales = data.Count();
                cumplimiento = (double) diasReales / diasToricos;
                return (data,diasToricos,diasReales,cumplimiento);
            }

            public async Task<LibroNove>? ObtenerLibroPorId(int idRegistro){
                LibroNove data = await this._cotext.LibroNoves.Where(l => l.IdlibrNov == idRegistro).FirstOrDefaultAsync();
                return data;
            }
        }
        public class DataTiParTP : IDataTiParTP
        {
            private readonly DbNeoContext _cotext;

            public DataTiParTP(DbNeoContext context)
            {
                this._cotext = context;
            }
            public async Task<TiParTp> ObtenerTipoParadaId(string IdGespline){
                return await this._cotext.TiParTps.Where(t => t.Tpcodigo == IdGespline).FirstOrDefaultAsync();
            }

            public async Task<List<TiParTp>> ObtenerTodosTiposNovedad(){
                return await this._cotext.TiParTps.Where(t => t.Tpestado == true).ToListAsync();
            }
        }
        public class DataPizarra : IDataPizarra
        {

            private readonly DbNeoContext _cotext;

            public DataPizarra(DbNeoContext context)
            {
                this._cotext = context;
            }
            public async Task<bool> InsertarRegistros(List<ReuDium> reunionDia){
                foreach (var item in reunionDia)
                {
                    this._cotext.ReuDia.Add(item);
                }
                return await _cotext.SaveChangesAsync() > 0;
            }
        }

        public class DataChismoso : IDataChismoso
        {
            private readonly DbNeoContext _cotext;

            public DataChismoso(DbNeoContext context)
            {
                this._cotext = context;
            }

            public async Task<bool> InsertarRegistros(List<CambFec> data,List<CambStat> data2){
                foreach (var item in data)
                {
                    this._cotext.CambFecs.Add(item);
                }
                foreach (var item in data2)
                {
                    this._cotext.CambStats.Add(item);
                }
                return await _cotext.SaveChangesAsync() > 0;
            }
        }
    }