using LibroNovedades.Models.Neo;
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
            return await _cotext.Usuarios.Where(u => u.UsNombre == username && u.UsPass == password && u.UsEstatus == true).FirstOrDefaultAsync();
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
            return await _cotext.Nivels.Include(n => n.IdUsuarioNavigation).Include(n => n.IdDivisionNavigation).Include(n => n.IdProyectoNavigation).Include(n => n.IdRolNavigation).Where(n => n.IdUsuarioNavigation.IdUsuario == usuario.IdUsuario && n.IdProyectoNavigation.IdProyecto == proyecto.IdProyecto).ToListAsync();
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
            return await _cotext.ProyectoUsrs.Where(p => p.Pnombre == nombreProyecto && p.Pestado == true).FirstOrDefaultAsync();
        }
    }

}