using LibroNovedades.Models;
using Microsoft.EntityFrameworkCore;

namespace LibroNovedades.Data.API
{
    public interface IDataAPI
    {
        Task<List<List<string>>> obtenerParadasActuales1turnoPorLinea(string centroCosto);
        Task<List<List<string>>> obtenerParadasActuales1turnoPorLinea(string centroCosto,List<LibroNove> listaNove);
        Task<Dictionary<string,string>>? obtenerUsuario(string ficha);
    }

    public class DataAPI : IDataAPI
    {
        private HttpClient cliente;
        public async Task<List<List<string>>>? obtenerParadasActuales1turnoPorLinea(string centroCosto){
            List<List<string>> data;
            string url = "http://operaciones.papeleslatinos.com/neoapi/OEE/obtenerParadasActuales1turnoPorLinea/" + centroCosto;
            this.cliente = new HttpClient();
            data = await cliente.GetFromJsonAsync<List<List<string>>>(url);
            return data;
        }
        public async Task<List<List<string>>>? obtenerParadasActuales1turnoPorLinea(string centroCosto, List<LibroNove> listaNove){
            string ParadasIgnorar = "[";
            List<List<string>> data = new List<List<string>>();
            this.cliente = new HttpClient();
            if(listaNove.Count == 0){
                return await this.obtenerParadasActuales1turnoPorLinea(centroCosto);
            }else{
                for (int i = 0; i < listaNove.Count; i++)
                {
                    if(i ==  listaNove.Count-1){
                        ParadasIgnorar += listaNove[i].IdParaGesp.ToString().Substring(1);
                    }else{
                        ParadasIgnorar +=  listaNove[i].IdParaGesp.ToString().Substring(1) + ",";
                    }
                }
                ParadasIgnorar += "]";
            }
            string url = "http://operaciones.papeleslatinos.com/neoapi/OEE/obtenerParadasActuales1turnoPorLinea/" + centroCosto + "/" + ParadasIgnorar;
            data = await cliente.GetFromJsonAsync<List<List<string>>>(url);     
            return data;
        }
        public async Task<Dictionary<string,string>>? obtenerUsuario(string ficha){
            Dictionary<string,string> usuario = new Dictionary<string,string>();
            string url = "http://operaciones.papeleslatinos.com/neoapi/usuario/BuscarUsuarioPorFicha/" + ficha;
            this.cliente = new HttpClient();
            usuario = await cliente.GetFromJsonAsync<Dictionary<string,string>>(url);
            return usuario;
        } 
    }
}