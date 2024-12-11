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
            IDataPizarra pizarraData = new DataPizarra(_clientFactory);
            IDataAvisador avisadorData = new DataAvisador(_clientFactory);
            LibroNoveDTO? temporal;
            ReunionDTO registroNuevo = new ReunionDTO();
            CambFecDTO ChismosoCambioFecha = new CambFecDTO();
            CambStatDTO ChismosoCambioEstado = new CambStatDTO();
            List<CambFecDTO> ListaChismosoCambioFecha = new List<CambFecDTO>();
            List<CambStatDTO> ListaChismosoCambioEstado = new List<CambStatDTO>();
            List<ReunionDTO> listaPizarra = new List<ReunionDTO>(listaNovedades.Count);
            List<LibroNoveDTO> listaNovedadesFiltrada = new List<LibroNoveDTO>();

            List<LibroNoveDTO> listaNovedades2;
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
                        //registroNuevo.Rdcentro = temporal.IdLineaNavigation.IdDivisionNavigation.IdCentroNavigation.Cnom;
                        //registroNuevo.Rddiv = temporal.IdLineaNavigation.IdDivisionNavigation.Dnombre;
                        //registroNuevo.Rdarea = temporal.IdLineaNavigation.Lnom;
                        registroNuevo.RdcodEq = temporal.IdEquipo;
                        registroNuevo.Rddisc = temporal.Lndiscrepa;
                        registroNuevo.RdfecReu = DateTime.Now;
                        registroNuevo.RdfecTra = DateTime.Now;
                        registroNuevo.Rdstatus = "Pendiente";
                        registroNuevo.IdResReu = 11;
                        //registroNuevo.IdPais = idPais;
                        registroNuevo.IdEmpresa = idEmpresa;
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

                        registroNuevo = new ReunionDTO();
                        ChismosoCambioFecha = new CambFecDTO();
                        ChismosoCambioEstado = new CambStatDTO();
                        registroNuevo.IdTipReu = 2;
                        listaNovedadesFiltrada.Add(item);
                    }
                }
                else
                {
                    continue;
                }
            }
            if (listaPizarra.Count > 0)
            {
                RegistroCambiosDTO  registroCambios = new RegistroCambiosDTO(ChismosoCambioFecha, ChismosoCambioEstado, registroNuevo);
                avisadorData.InsertarRegistros(registroCambios);
                return Tuple.Create(true, listaNovedadesFiltrada);
            }
            else
            {
                return Tuple.Create(false, listaNovedadesFiltrada);
            }
        }
    }

}