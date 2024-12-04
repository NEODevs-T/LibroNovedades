using LibroNovedades.Models;
using Microsoft.EntityFrameworkCore;

namespace LibroNovedades.Data.User
{
    public interface IDataUser
    {
        Task<Usuario>? ObtenerUsuario(string username,string password);
    }

    public class DataUser : IDataUser
    {
        private readonly DbNeoContext _cotext;

        public DataUser(DbNeoContext context)
        {
            this._cotext = context;
        }
        public async Task<Usuario>? ObtenerUsuario(string username,string password){
            throw new NotImplementedException();

        }

    }

    public interface IDataNivel
    {
        Task<List<Nivel>>? ObtenerNivelesDelUsuarioSegunProyecto(Usuario usuario,ProyectoUsr proyecto);
    }

    public class DataNivel : IDataNivel
    {
        private readonly DbNeoContext _cotext;

        public DataNivel(DbNeoContext context)
        {
            this._cotext = context;
        }

        public async Task<List<Nivel>>? ObtenerNivelesDelUsuarioSegunProyecto(Usuario usuario,ProyectoUsr proyecto){
            throw new NotImplementedException();
        }
    }

    public interface IDataProyectoUsr
    {
        Task<ProyectoUsr>? ObtenerProyectoSegunNombre(string nombreProyecto);
    }
    public class DataProyectoUsr : IDataProyectoUsr
    {
        private readonly DbNeoContext _cotext;

        public DataProyectoUsr(DbNeoContext context)
        {
            this._cotext = context;
        }
        public async Task<ProyectoUsr>? ObtenerProyectoSegunNombre(string nombreProyecto){
            throw new NotImplementedException();
        }
    }

}