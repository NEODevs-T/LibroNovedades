using LibroNovedades.Models;
using LibroNovedades.ModelsDocIng;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace LibroNovedades.Data.API
{
    public interface IDataAPI
    {
        Task<List<List<string>>> obtenerParadasActuales1turnoPorLinea(string centroCosto);
        Task<List<List<string>>> obtenerParadasActuales1turnoPorLinea(string centroCosto,List<LibroNove> listaNove);
        Task<List<List<string>>> obtenerParadasActualesturnoPorLinea(string centroCosto,List<LibroNove> listaNove);
        Task<Dictionary<string,string>>? obtenerUsuario(string ficha);
        Task<List<List<string>>>? obtenerParadasActualesturnoPorLineaAgrupadas(string centroCosto);
        // Task<System.Net.Http.HttpResponseMessage> PostDiscrepancia(BdDiv1 bdDiv1);

        Task<List<string>>? ObtenerTurnoYGrupo();
    }

    public class DataAPI : IDataAPI
    {
        private HttpClient cliente;
        public async Task<List<List<string>>>? obtenerParadasActuales1turnoPorLinea(string centroCosto){
            List<List<string>> data;
            string url = "http://neo.paveca.com.ve/neoapi/gespline/obtenerParadasActuales1turnoPorLinea/" + centroCosto;
            this.cliente = new HttpClient();
            data = await cliente.GetFromJsonAsync<List<List<string>>>(url);
            return data;
        }

        public async Task<List<List<string>>>? obtenerParadasActuales1turnoPorLineaAgrupados(string centroCosto){
            List<List<string>> data;
            string url = "http://neo.paveca.com.ve/neoapi/gespline/ObtenerParadasGesplienActualesAgrupados1turno/" + centroCosto;
            this.cliente = new HttpClient();
            data = await cliente.GetFromJsonAsync<List<List<string>>>(url);
            return data;
        }

        public async Task<List<List<string>>>? obtenerParadasActuales2turnoPorLineaAgrupadosDespuesDeLas0am(string centroCosto){
            List<List<string>> data;
            string url = "http://neo.paveca.com.ve/neoapi/gespline/ObtenerParadasGesplienActualesAgrupados2turnoDespuesDeLas0am/" + centroCosto;
            this.cliente = new HttpClient();
            data = await cliente.GetFromJsonAsync<List<List<string>>>(url);
            return data;
        }
        public async Task<List<List<string>>>? obtenerParadasActuales2turnoPorLineaAgrupadosAntesDeLas0am(string centroCosto){
            List<List<string>> data;
            string url = "http://neo.paveca.com.ve/neoapi/gespline/ObtenerParadasGesplienActualesAgrupados2turnoAntesDeLas0am/" + centroCosto;
            this.cliente = new HttpClient();
            data = await cliente.GetFromJsonAsync<List<List<string>>>(url);
            return data;
        }



        public async Task<List<List<string>>>? obtenerParadasActuales2turnoPorLinea(string centroCosto){
            List<List<string>> data;
            string url = "http://neo.paveca.com.ve/neoapi/gespline/ObtenerParadasSegundoTurnoPorMaquina/" + centroCosto;
            this.cliente = new HttpClient();
            data = await cliente.GetFromJsonAsync<List<List<string>>>(url);
            return data;
        }

        public async Task<List<List<string>>>? obtenerParadasActualesturnoPorLineaAgrupadas(string centroCosto){
            DateTime tiempo =  DateTime.Now;
            if(tiempo.Hour >= 6 && tiempo.Hour < 18){
                return await this.obtenerParadasActuales1turnoPorLineaAgrupados(centroCosto);
            }else if(tiempo.Hour >= 18 && tiempo.Hour < 24){
                return await this.obtenerParadasActuales2turnoPorLineaAgrupadosAntesDeLas0am(centroCosto);
            }else if(tiempo.Hour >= 0 && tiempo.Hour < 6){
                return await this.obtenerParadasActuales2turnoPorLineaAgrupadosDespuesDeLas0am(centroCosto);
            }
            return null;
        }
        public async Task<List<List<string>>>? obtenerParadasActuales1turnoPorLinea(string centroCosto, List<LibroNove> listaNove){
            string ParadasIgnorar = "[";
            List<List<string>> data = new List<List<string>>();
            this.cliente = new HttpClient();
            if(centroCosto != ""){
                if(listaNove.Count == 0){
                    return await this.obtenerParadasActuales1turnoPorLinea(centroCosto);
                }else{
                    for (int i = 0; i < listaNove.Count; i++)
                    {
                        if(listaNove[i].IdParada != null){
                            if(i ==  listaNove.Count - 1){
                                ParadasIgnorar += listaNove[i].IdParada.ToString().Substring(1);
                            }else{
                                ParadasIgnorar +=  listaNove[i].IdParada.ToString().Substring(1) + ",";
                            }
                        }else{
                            continue;
                        }
                    }
                    ParadasIgnorar += "]";
                }
                if(ParadasIgnorar == "[]"){
                    return await this.obtenerParadasActuales1turnoPorLinea(centroCosto);
                }
                string url = "http://neo.paveca.com.ve/neoapi/gespline/obtenerParadasActuales1turnoPorLinea/" + centroCosto + "/" + ParadasIgnorar;
                data = await cliente.GetFromJsonAsync<List<List<string>>>(url);     
                return data;
            }
            return data;
        }

        public async Task<List<List<string>>>? obtenerParadasActuales2turnoPorLinea(string centroCosto, List<LibroNove> listaNove){
            string ParadasIgnorar = "[";
            List<List<string>> data = new List<List<string>>();
            this.cliente = new HttpClient();
            if(centroCosto != ""){
                if(listaNove.Count == 0 ){
                    return await this.obtenerParadasActuales2turnoPorLinea(centroCosto);
                }else{
                    for (int i = 0; i < listaNove.Count; i++)
                    {
                        if(listaNove[i].IdParada != null){
                            if(i ==  listaNove.Count - 1){
                                ParadasIgnorar += listaNove[i].IdParada.ToString().Substring(1);
                            }else{
                                ParadasIgnorar +=  listaNove[i].IdParada.ToString().Substring(1) + ",";
                            }
                        }else{
                            continue;
                        }
                    }
                    ParadasIgnorar += "]";
                }
                string url = "http://neo.paveca.com.ve/neoapi/gespline/ObtenerParadasSegundoTurnoPorMaquina/" + centroCosto + "/" + ParadasIgnorar;
                data = await cliente.GetFromJsonAsync<List<List<string>>>(url);     
                return data;
            }
            return data;  
        }
        public async Task<List<List<string>>>? obtenerParadasActualesturnoPorLinea(string centroCosto, List<LibroNove> listaNove){
            DateTime tiempo =  DateTime.Now;
            if(tiempo.Hour >= 6 && tiempo.Hour < 18){
                return await this.obtenerParadasActuales1turnoPorLinea(centroCosto,listaNove);
            }else{
                return await this.obtenerParadasActuales2turnoPorLinea(centroCosto,listaNove);
            }
        }
        
        public async Task<Dictionary<string,string>>? obtenerUsuario(string ficha){
            Dictionary<string,string> usuario = new Dictionary<string,string>();
            string url = "http://neo.paveca.com.ve/neoapi/usuario/BuscarUsuarioPorFicha/" + ficha;
            this.cliente = new HttpClient();
            usuario = await cliente.GetFromJsonAsync<Dictionary<string,string>>(url);
            return usuario;
        }

        public async Task<List<string>>? ObtenerTurnoYGrupo(){
            List<string> usuario;
            string url = "http://neo.paveca.com.ve/neoapi/turno/ObtenerTurnoYGrupoActual";
            this.cliente = new HttpClient();
            usuario = await cliente.GetFromJsonAsync<List<string>>(url);
            return usuario;
        }

        // public async Task<System.Net.Http.HttpResponseMessage> PostDiscrepancia(BdDiv1 bdDiv1)
        // {   
        
            
        //     //return true;
        //     // await SetAsistencia(result);
        // }

    }   
}