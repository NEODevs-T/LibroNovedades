using System.Resources;
using System.Globalization;

namespace LibroNovedades.Resources
{
    public class ValidationMessages
    {
        private static readonly ResourceManager _resourceManager =
            new ResourceManager("LibroNovedades.Resources.ValidationMessages", typeof(ValidationMessages).Assembly);

        public static string RequiredUserName => _resourceManager.GetString("RequiredUserName", CultureInfo.CurrentUICulture);
        public static string RequiredPassword => _resourceManager.GetString("RequiredPassword", CultureInfo.CurrentUICulture);
        public static string RequiredEquipment => _resourceManager.GetString("RequiredEquipment", CultureInfo.CurrentUICulture);
        public static string RequiredObservation => _resourceManager.GetString("RequiredObservation", CultureInfo.CurrentUICulture);
        public static string RequiredSheet => _resourceManager.GetString("RequiredSheet", CultureInfo.CurrentCulture);
        public static string ErrorGeneral => _resourceManager.GetString("ErrorGeneral", CultureInfo.CurrentCulture);
        public static string ErrorDesarrollo => _resourceManager.GetString("ErrorDesarrollo", CultureInfo.CurrentCulture);
        public static string Recargar => _resourceManager.GetString("Recargar", CultureInfo.CurrentCulture);
        public static string Formato => _resourceManager.GetString("Formato", CultureInfo.CurrentCulture);
        public static string LibroDeNovedades => _resourceManager.GetString("LibroDeNovedades", CultureInfo.CurrentCulture);
        public static string Pais => _resourceManager.GetString("Pais", CultureInfo.CurrentCulture);
        public static string SeleccioneUnPais => _resourceManager.GetString("SeleccioneUnPais", CultureInfo.CurrentCulture);
        public static string Cargando => _resourceManager.GetString("Cagando", CultureInfo.CurrentCulture);
        public static string Empresas => _resourceManager.GetString("Empresas", CultureInfo.CurrentCulture);
        public static string SeleccioneUnaEmpresa => _resourceManager.GetString("SeleccioneUnaEmpresa", CultureInfo.CurrentCulture);
        public static string Centro => _resourceManager.GetString("Centro", CultureInfo.CurrentCulture);
        public static string SeleccioneUnCentro => _resourceManager.GetString("SeleccioneUnCentro", CultureInfo.CurrentCulture);
        public static string Divisiones => _resourceManager.GetString("Divisiones", CultureInfo.CurrentCulture);
        public static string SeleccioneUnaDivision => _resourceManager.GetString("SeleccioneUnaDivision", CultureInfo.CurrentCulture);
        public static string Linea => _resourceManager.GetString("Linea", CultureInfo.CurrentCulture);
        public static string SeleccioneUnaLinea => _resourceManager.GetString("SeleccioneUnaLinea", CultureInfo.CurrentCulture);
        public static string TiempoPerdido => _resourceManager.GetString("TiempoPerdido", CultureInfo.CurrentCulture);
        public static string TiempoEmpleado => _resourceManager.GetString("TiempoPerdido", CultureInfo.CurrentCulture);
        public static string Causa => _resourceManager.GetString("Causa", CultureInfo.CurrentCulture);
        public static string Seleccionar => _resourceManager.GetString("Seleccionar", CultureInfo.CurrentCulture);
        public static string SinPerdidaDeTiempo => _resourceManager.GetString("SinPerdidaDeTiempo", CultureInfo.CurrentCulture);
        public static string SeleccionarGrupo => _resourceManager.GetString("SeleccionarGrupo", CultureInfo.CurrentCulture);
        public static string Grupo => _resourceManager.GetString("Grupo", CultureInfo.CurrentCulture);
        public static string Turno => _resourceManager.GetString("Turno", CultureInfo.CurrentCulture);
        public static string CodigoEquipo => _resourceManager.GetString("CodigoEquipo", CultureInfo.CurrentCulture);
        public static string Ficha => _resourceManager.GetString("Ficha", CultureInfo.CurrentCulture);
        public static string FichaSupervisor => _resourceManager.GetString("FichaSupervisor", CultureInfo.CurrentCulture);
        public static string ClasificacionTPM => _resourceManager.GetString("ClasificacionTPM", CultureInfo.CurrentCulture);
        public static string Resuelto => _resourceManager.GetString("Resuelto", CultureInfo.CurrentCulture);
        public static string Si => _resourceManager.GetString("Si", CultureInfo.CurrentCulture);
        public static string No => _resourceManager.GetString("No", CultureInfo.CurrentCulture);
        public static string Discrepancia => _resourceManager.GetString("Discrepancia", CultureInfo.CurrentCulture);
        public static string Observacion => _resourceManager.GetString("Observacion", CultureInfo.CurrentCulture);
        public static string Accion => _resourceManager.GetString("Accion", CultureInfo.CurrentCulture);
        public static string Registrar => _resourceManager.GetString("Registrar", CultureInfo.CurrentCulture);
        public static string Atras => _resourceManager.GetString("Atras",CultureInfo.CurrentCulture);
        public static string Seccion => _resourceManager.GetString("Seccion", CultureInfo.CurrentCulture);
        public static string Descripcion => _resourceManager.GetString("Descripcion", CultureInfo.CurrentCulture);
        public static string Tiempo => _resourceManager.GetString("Tiempo", CultureInfo.CurrentCulture);
        public static string ColoqueLinea => _resourceManager.GetString("ColoqueLinea", CultureInfo.CurrentCulture);
        public static string Actualizado => _resourceManager.GetString("Actualizado", CultureInfo.CurrentCulture);
        public static string PorActualizar => _resourceManager.GetString("PorActualizar", CultureInfo.CurrentCulture);
    }
}
