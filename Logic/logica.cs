using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using Newtonsoft.Json;
using LibroNovedades.Models;
using LibroNovedades.ModelsDocIng;
using LibroNovedades.Data.LibroNov;



namespace LibroNovedades.Logic{
    public interface ILogicLibroNov
    {
        Task<Tuple<bool,List<LibroNove>>> CambiosBDLibro(int idPais,int idEmpresa,int idCentro,int idDivision,List<LibroNove> listaNovedades,DateTime filtroFechaInicio,DateTime filtroFechaFinal,int filtroLinea,int filtroCLTPM,string nombre);
    }

    public class LogicLibroNov : ILogicLibroNov
    {

        public async Task<Tuple<bool,List<LibroNove>>> CambiosBDLibro(int idPais,int idEmpresa,int idCentro,int idDivision,List<LibroNove> listaNovedades,DateTime filtroFechaInicio,DateTime filtroFechaFinal,int filtroLinea,int filtroCLTPM,string nombre){
            DbNeoContext contex = new DbNeoContext();
            IDataLibroNov dataLibroNov = new DataLibroNov(contex);
            IDataPizarra dataPizarra = new DataPizarra(contex);
            IDataChismoso dataChismoso = new DataChismoso(contex);
            LibroNove? temporal;
            ReunionDium registro = new ReunionDium();
            ReuDium registroNuevo = new ReuDium();
            CambFec ChismosoCambioFecha =  new CambFec();
            CambStat ChismosoCambioEstado = new  CambStat();
            List<CambFec> ListaChismosoCambioFecha  = new List<CambFec>();
            List<CambStat> ListaChismosoCambioEstado  = new List<CambStat>();
            List<ReuDium> listaPizarra = new List<ReuDium>(listaNovedades.Count);
            List<LibroNove> listaNovedadesFiltrada = new List<LibroNove>();

            List<LibroNove> listaNovedades2;
            if(filtroFechaInicio.Date == filtroFechaFinal.Date) {
                listaNovedades2 = await dataLibroNov.ObtenerLibroNovedadesPorFiltro(idCentro,filtroFechaInicio,idDivision,filtroLinea,filtroCLTPM,2);
            }else if(filtroFechaInicio.Date < filtroFechaFinal.Date){
                listaNovedades2 = await dataLibroNov.ObtenerLibroNovedadesPorFiltroEntreFechas(idCentro,filtroFechaInicio,filtroFechaFinal,idDivision,filtroLinea,filtroCLTPM,2);
            }else{
                listaNovedades2 = await dataLibroNov.ObtenerLibroNovedadesPorFiltroEntreFechas(idCentro,filtroFechaFinal,filtroFechaInicio,idDivision,filtroLinea,filtroCLTPM,2);
            }

            foreach (var item in listaNovedades)
            {
                temporal = listaNovedades2.Find(x=> x.IdlibrNov == item.IdlibrNov);
                if(temporal != null){
                    if((temporal.LnisPizUni != item.LnisPizUni) && (item.LnisPizUni == true) && (item.LnisResu == 0)){
                        if(temporal.IdTipoNove == 8 || temporal.IdAreaCar == 2 || temporal.IdCtpm == 4){
                            //* Calidad
                            registroNuevo.Idksf = 3;
                        }else if(temporal.IdTipoNove == 13 || temporal.IdAreaCar == 3 || temporal.IdCtpm == 1){
                            //* Seguridad
                            registroNuevo.Idksf = 5;
                        }else{
                            //* produccion
                            registroNuevo.Idksf = 1;
                        }
                        registroNuevo.Rdcentro = temporal.IdLineaNavigation.IdDivisionNavigation.IdCentroNavigation.Cnom;
                        registroNuevo.Rddiv = temporal.IdLineaNavigation.IdDivisionNavigation.Dnombre;
                        registroNuevo.Rdarea = temporal.IdLineaNavigation.Lnom;
                        registroNuevo.RdcodEq = temporal.IdEquipo;
                        registroNuevo.Rddisc = temporal.Lndiscrepa;
                        registroNuevo.RdfecReu = DateTime.Now;
                        registroNuevo.RdfecTra = DateTime.Now;
                        registroNuevo.Rdstatus = "Pendiente";
                        registroNuevo.IdResReu =  11;
                        registroNuevo.IdPais = idPais;
                        registroNuevo.IdEmpresa = idEmpresa;
                        listaPizarra.Add(registroNuevo);

                        ChismosoCambioFecha.IdReuDiaNavigation = registroNuevo;
                        ChismosoCambioFecha.Cffec = DateTime.Now;
                        ChismosoCambioFecha.CffecNew = DateTime.Now;
                        ChismosoCambioFecha.Cfuser = nombre;
                        ListaChismosoCambioFecha.Add(ChismosoCambioFecha);

                        ChismosoCambioEstado.Cbuser = nombre;
                        ChismosoCambioEstado.Cbstat = "Pendiente";
                        ChismosoCambioEstado.Cbfecha =  DateTime.Now;
                        ChismosoCambioEstado.IdReuDiaNavigation =  registroNuevo;
                        ListaChismosoCambioEstado.Add(ChismosoCambioEstado);

                        registroNuevo = new ReuDium();
                        ChismosoCambioFecha = new CambFec();
                        ChismosoCambioEstado = new  CambStat();
                        
                        listaNovedadesFiltrada.Add(item);
                    }
                }else{
                    continue;
                }
            }
            if(listaPizarra.Count > 0){
                dataChismoso.InsertarRegistros(ListaChismosoCambioFecha,ListaChismosoCambioEstado);
                return Tuple.Create(true,listaNovedadesFiltrada);
            }else{
                return Tuple.Create(false,listaNovedadesFiltrada);
            }
        }
    }

}