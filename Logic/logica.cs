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
        Task<bool> CambiosBDLibro(List<LibroNove> listaNovedades,DateTime filtroFecha,int filtroLinea,int filtroTipoNovedad);
    }

    public class LogicLibroNov : ILogicLibroNov
    {

        public async Task<bool> CambiosBDLibro(List<LibroNove> listaNovedades,DateTime filtroFecha,int filtroLinea,int filtroTipoNovedad){
            
            DbNeoContext contex = new DbNeoContext();
            DOC_IngIContext contexIng = new DOC_IngIContext();
            IDataLibroNov dataLibroNov = new DataLibroNov(contex);
            IDataPizarra dataPizarra = new DataPizarra(contexIng);
            LibroNove? temporal;
            BdDiv1 registro = new BdDiv1();
            List<BdDiv1> listaPizarra = new List<BdDiv1>(listaNovedades.Count);

            List<LibroNove> listaNovedades2 = await dataLibroNov.ObtenerLibroNovedadesPorFiltro(filtroFecha,filtroLinea,filtroTipoNovedad);

            foreach (var item in listaNovedades)
            {
                temporal = listaNovedades2.Find(x=> x.IdlibrNov == item.IdlibrNov);
                if(temporal != null){
                    if((temporal.LnisPizUni != item.LnisPizUni) && (item.LnisPizUni == true)){
                        if(temporal.IdLineaNavigation.IdCentro == 1){
                            registro.Div = "DIV 1 Prueba";
                        }else if(temporal.IdLineaNavigation.IdCentro == 2){
                            registro.Div = "Mol";
                        }else if(temporal.IdLineaNavigation.IdCentro == 5){
                            registro.Div = "Generación";
                        }else if(temporal.IdLineaNavigation.IdCentro == 6){
                            registro.Div = "AMB";
                        }else if(temporal.IdLineaNavigation.IdCentro == 8){
                            registro.Div = "PP";
                        }else if(temporal.IdLineaNavigation.IdCentro == 10){
                            registro.Div = "PD&CL";
                        }
                        registro.CodigoEquipo = temporal.IdEquipo;
                        registro.Discrepancia = temporal.Lndiscrepa;
                        registro.Fecha = temporal.Lnfecha;
                        registro.FechaTrab1 = temporal.Lnfecha.ToString("yyyyMMdd");
                        listaPizarra.Add(registro);
                        registro = new BdDiv1();
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