using LibroNovedades.Models;
using Microsoft.EntityFrameworkCore;

namespace LibroNovedades.Data.APIOEE
{
    public interface IDataAPIOEE
    {
        Task<List<List<string>>> obtenerParadasActuales1turnoPorLinea(string centroCosto);

        Task<List<List<string>>> obtenerParadasActuales1turnoPorLinea(string centroCosto,List<LibroNove> listaNove);

    }

    public class DataAPIOEE : IDataAPIOEE
    {
        public async Task<List<List<string>>>? obtenerParadasActuales1turnoPorLinea(string centroCosto){
            List<List<string>> data;
            string url = "http://operaciones.papeleslatinos.com/neoapi/OEE/obtenerParadasActuales1turnoPorLinea/" + centroCosto;
            HttpClient cliente = new HttpClient();
            data = await cliente.GetFromJsonAsync<List<List<string>>>(url);
            return data;
        }
        public async Task<List<List<string>>>? obtenerParadasActuales1turnoPorLinea(string centroCosto, List<LibroNove> listaNove){
            string ParadasIgnorar = "[";
            List<List<string>> data = new List<List<string>>();
            HttpClient cliente = new HttpClient();
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
    }
}