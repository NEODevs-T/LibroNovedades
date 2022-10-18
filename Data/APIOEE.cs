using LibroNovedades.Models;
using Microsoft.EntityFrameworkCore;

namespace LibroNovedades.Data.APIOEE
{
    public interface IDataAPIOEE
    {
        Task<List<List<string>>> obtenerParadasActuales1turnoPorLinea(string centroCosto);

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
    }
}