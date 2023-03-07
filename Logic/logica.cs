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
        Task<bool> CambiosBDLibro(int idCentro,List<LibroNove> listaNovedades,DateTime filtroFecha,int filtroLinea,int filtroTipoNovedad);
    }

    public class LogicLibroNov : ILogicLibroNov
    {

        public async Task<bool> CambiosBDLibro(int idCentro,List<LibroNove> listaNovedades,DateTime filtroFecha,int filtroLinea,int filtroTipoNovedad){
            DbNeoContext contex = new DbNeoContext();
            IDataLibroNov dataLibroNov = new DataLibroNov(contex);
            IDataPizarra dataPizarra = new DataPizarra(contex);
            LibroNove? temporal;
            ReunionDium registro = new ReunionDium();
            ReuDium registroNuevo = new ReuDium();
            List<ReuDium> listaPizarra = new List<ReuDium>(listaNovedades.Count);
            List<LibroNove> listaNovedades2 = await dataLibroNov.ObtenerLibroNovedadesPorFiltro(idCentro,filtroFecha,filtroLinea,filtroTipoNovedad);

            foreach (var item in listaNovedades)
            {
                temporal = listaNovedades2.Find(x=> x.IdlibrNov == item.IdlibrNov);
                if(temporal != null){
                    if((temporal.LnisPizUni != item.LnisPizUni) && (item.LnisPizUni == true)){
                        // if(temporal.IdLineaNavigation.IdCentro == 1){
                        //     registro.Div = "DIV 1 Prueba";
                        // }else if(temporal.IdLineaNavigation.IdCentro == 2){
                        //     registro.Div = "Mol";
                        // }else if(temporal.IdLineaNavigation.IdCentro == 5){
                        //     registro.Div = "Generación";
                        // }else if(temporal.IdLineaNavigation.IdCentro == 6){
                        //     registro.Div = "AMB";
                        // }else if(temporal.IdLineaNavigation.IdCentro == 8){
                        //     registro.Div = "PP";
                        // }else if(temporal.IdLineaNavigation.IdCentro == 10){
                        //     registro.Div = "PD&CL";
                        // }
                        if(temporal.IdTipoNove == 8 || temporal.IdAreaCar == 2){
                            //* Calidad
                            registroNuevo.Idksf = 3;
                        }else if(temporal.IdTipoNove == 13 || temporal.IdAreaCar == 3){
                            //* Seguridad
                            registroNuevo.Idksf = 5;
                        }else{
                            registroNuevo.Idksf = 1; 
                        }
                        registroNuevo.Rdcentro = temporal.IdLineaNavigation.IdCentroNavigation.Cnom;
                        registroNuevo.Rddiv = temporal.IdLineaNavigation.IdDivisionNavigation.Dnombre;
                        registroNuevo.Rdarea = temporal.IdLineaNavigation.Lnom;
                        registroNuevo.RdcodEq = temporal.IdEquipo;
                        registroNuevo.Rddisc = temporal.Lndiscrepa;
                        registroNuevo.RdfecReu = temporal.Lnfecha;   
                        registroNuevo.RdfecTra = temporal.Lnfecha;
                        registroNuevo.Rdstatus = "Pendiente";
                        registroNuevo.IdResReu =  11;
                        registroNuevo.IdPais = 1;
                        listaPizarra.Add(registroNuevo);
                        registroNuevo = new ReuDium();
                    }
                }else{
                    continue;
                }
            }
            if(listaPizarra.Count > 0){
                dataPizarra.InsertarRegistros(listaPizarra);
                return true;
            }else{
                return false;
            }
        }
    }

}