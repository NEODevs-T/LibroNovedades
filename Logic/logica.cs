using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using Newtonsoft.Json;
using LibroNovedades.ModelsDocIng;
using LibroNovedades.Data.LibroNov;
using LibroNovedades.DTOs;
using LibroNovedades.Interface;
using System.Net.Http;
using ReunionDiaria.DTOs;
using DTOs.Maestra;
using LibroNovedades.Interface.Maestra;
using LibroNovedades.Data.Maestra;



namespace LibroNovedades.Logic
{
    public interface ILogicLibroNov
    {
        Task<Tuple<bool, List<LibroNoveDTO>>> CambiosBDLibro(int idPais, int idEmpresa, int idCentro, int idDivision, List<LibroNoveDTO> listaNovedades, DateTime filtroFechaInicio, DateTime filtroFechaFinal, int filtroLinea, int filtroCLTPM, string nombre);
    }

    public class LogicLibroNov : ILogicLibroNov
    {

        private readonly IHttpClientFactory _clientFactory;

        public LogicLibroNov(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task SomeMethodAsync()
        {
            var client = _clientFactory.CreateClient();
            var response = await client.GetAsync("http://neo.paveca.com.ve/apineomaster/api/LogicLibroNov");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<Tuple<bool, List<LibroNoveDTO>>> CambiosBDLibro(int idPais, int idEmpresa, int idCentro, int idDivision, List<LibroNoveDTO> listaNovedades, DateTime filtroFechaInicio, DateTime filtroFechaFinal, int filtroLinea, int filtroCLTPM, string nombre)
        {
            
            // TODO: arreglaar la pizarra
            ILibroNovData libroNovData = new LibroNovData(_clientFactory);
            IMaestraData maestraData = new MaestraData(_clientFactory);
            IDataPizarra pizarraData = new DataPizarra(_clientFactory);
            IDataAvisador avisadorData = new DataAvisador(_clientFactory);
            LibroNoveDTO? temporal;
            List<MaestraVDTO> maestra = new List<MaestraVDTO>();
            ReunionDTO registroNuevo = new ReunionDTO();
            CambFecDTO ChismosoCambioFecha = new CambFecDTO();
            CambStatDTO ChismosoCambioEstado = new CambStatDTO();
            List<CambFecDTO> ListaChismosoCambioFecha = new List<CambFecDTO>();
            List<CambStatDTO> ListaChismosoCambioEstado = new List<CambStatDTO>();
            List<ReunionDTO> listaPizarra = new List<ReunionDTO>(listaNovedades.Count);
            List<LibroNoveDTO> listaNovedadesFiltrada = new List<LibroNoveDTO>();
            List<LibroNoveDTO> listaNovedades2;
            int reunionTurno = 2;
            LibroNoveDTO dataNovedades;
            bool validacion = false;

            if (filtroFechaInicio.Date == filtroFechaFinal.Date)
            {
                listaNovedades2 = await libroNovData.ObtenerLibroNovedadesPorFiltro(idCentro, filtroFechaInicio, idDivision, filtroLinea, filtroCLTPM, 2);
                
            }
            else if (filtroFechaInicio.Date < filtroFechaFinal.Date)
            {
                listaNovedades2 = await libroNovData.ObtenerLibroNovedadesPorFiltroEntreFechas(idCentro, filtroFechaInicio, filtroFechaFinal, idDivision, filtroLinea, filtroCLTPM, 2);
            }
            else
            {
                listaNovedades2 = await libroNovData.ObtenerLibroNovedadesPorFiltroEntreFechas(idCentro, filtroFechaFinal, filtroFechaInicio, idDivision, filtroLinea, filtroCLTPM, 2);
            }

            foreach (var item in listaNovedades)
            {
                temporal = listaNovedades2.Find(x => x.IdlibrNov == item.IdlibrNov);
                int idmaster = listaNovedades2.Where(x => x.IdLinea == item.IdLinea).First().IdMaster;
                int TPM = listaNovedades2.Where(x => x.IdCtpm == item.IdCtpm).First().IdCtpm;
                if (temporal != null)
                {
                    if ((temporal.LnisPizUni != item.LnisPizUni) && (item.LnisPizUni == true) && (item.LnisResu == 0))
                    {
                        if (temporal.IdTipoNove == 8 || temporal.IdAreaCar == 2 || temporal.IdCtpm == 4)
                        {
                            //* Calidad
                            registroNuevo.Idksf = 3;
                        }
                        else if (temporal.IdTipoNove == 13 || temporal.IdAreaCar == 3 || temporal.IdCtpm == 1)
                        {
                            //* Seguridad
                            registroNuevo.Idksf = 5;
                        }
                        else
                        {
                            //* produccion
                            registroNuevo.Idksf = 1;
                        }
                        //TODO: Revisar cambio para poder ubicar al nombre del centro
                        registroNuevo.IdTipReu = 2;
                        registroNuevo.RdcodEq = temporal.IdEquipo;
                        registroNuevo.Rddisc = temporal.Lndiscrepa;
                        registroNuevo.RdfecReu = DateTime.Now;
                        registroNuevo.RdfecTra = DateTime.Now;
                        registroNuevo.RdfecCrea = DateTime.Now;
                        registroNuevo.Rdstatus = "Pendiente";
                        registroNuevo.IdResReu = 11;
                        registroNuevo.IdEmpresa = idEmpresa;
                        maestra = await maestraData.GetMaestraId(idmaster);
                        registroNuevo.IdMaster = maestra.Where(x => x.IdMaster == idmaster).First().IdMaster;
                        registroNuevo.Rdcentro = maestra.Where(x => x.IdMaster == idmaster).First().Centro;
                        registroNuevo.Rddiv = maestra.Where(x => x.IdMaster == idmaster).First().División;
                        registroNuevo.Rdarea = maestra.Where(x => x.IdMaster == idmaster).First().Linea;
                        if(TPM == 4) 
                        {
                            registroNuevo.IdCausaCal = 2;
                        }else
                        {
                            registroNuevo.IdCausaCal = 1;
                        }
                        listaPizarra.Add(registroNuevo);

                        //ChismosoCambioFecha.IdReuDiaNavigation = registroNuevo;
                        ChismosoCambioFecha.Cffec = DateTime.Now;
                        ChismosoCambioFecha.CffecNew = DateTime.Now;
                        ChismosoCambioFecha.Cfuser = nombre;
                        ListaChismosoCambioFecha.Add(ChismosoCambioFecha);

                        ChismosoCambioEstado.Cbuser = nombre;
                        ChismosoCambioEstado.Cbstat = "Pendiente";
                        ChismosoCambioEstado.Cbfecha = DateTime.Now;
                        //ChismosoCambioEstado.IdReuDiaNavigation = registroNuevo;
                        ListaChismosoCambioEstado.Add(ChismosoCambioEstado);
                        registroNuevo.IdTipReu = reunionTurno;
                        listaNovedadesFiltrada.Add(item);
                        RegistroCambiosDTO  registroCambios = new RegistroCambiosDTO(ChismosoCambioFecha, ChismosoCambioEstado, registroNuevo);
                        bool insercion = await avisadorData.InsertarRegistros(registroCambios);
                        if (insercion == true)
                        {
                            validacion = true;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            if (listaPizarra.Count > 0 && validacion == true)
            {
                return Tuple.Create(true, listaNovedadesFiltrada);
            }
            else
            {
                return Tuple.Create(false, listaNovedadesFiltrada);
            }
        }
    }

}