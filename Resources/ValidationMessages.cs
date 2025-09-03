using System.Resources;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace LibroNovedades.Resources
{
    public class ValidationMessages
    {
        private static readonly ResourceManager _resourceManager =
            new ResourceManager("LibroNovedades.Resources.ValidationMessages", typeof(ValidationMessages).Assembly);

        public static ResourceManager ResourceManager => _resourceManager;

        public static string RequiredUserName => _resourceManager.GetString("RequiredUserName", CultureInfo.CurrentUICulture);
        public static string RequiredPassword => _resourceManager.GetString("RequiredPassword", CultureInfo.CurrentUICulture);
        public static string RequiredEquipment => _resourceManager.GetString("RequiredEquipment", CultureInfo.CurrentUICulture);
        public static string RequiredObservation => _resourceManager.GetString("RequiredObservation", CultureInfo.CurrentUICulture);
        public static string RequiredSheet => _resourceManager.GetString("RequiredSheet", CultureInfo.CurrentCulture);
        public static string ErrorGeneral => _resourceManager.GetString("ErrorGeneral", CultureInfo.CurrentCulture);
        public static string ErrorDesarrollo => _resourceManager.GetString("ErrorDesarrollo", CultureInfo.CurrentCulture);
        public static string Recargar => _resourceManager.GetString("Recargar", CultureInfo.CurrentCulture);
        public static string Formato => _resourceManager.GetString("Formato", CultureInfo.CurrentCulture);
        public static string LibroDeNovedades => _resourceManager.GetString("LibroDeNovedades", CultureInfo.CurrentUICulture);
        public static string Pais => _resourceManager.GetString("Pais", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnPais => _resourceManager.GetString("SeleccioneUnPais", CultureInfo.CurrentUICulture);
        public static string Cargando => _resourceManager.GetString("Cargando", CultureInfo.CurrentUICulture);
        public static string Empresas => _resourceManager.GetString("Empresas", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnaEmpresa => _resourceManager.GetString("SeleccioneUnaEmpresa", CultureInfo.CurrentUICulture);
        public static string Centro => _resourceManager.GetString("Centro", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnCentro => _resourceManager.GetString("SeleccioneUnCentro", CultureInfo.CurrentUICulture);
        public static string Divisiones => _resourceManager.GetString("Divisiones", CultureInfo.CurrentCulture);
        public static string SeleccioneUnaDivision => _resourceManager.GetString("SeleccioneUnaDivision", CultureInfo.CurrentCulture);
        public static string Linea => _resourceManager.GetString("Linea", CultureInfo.CurrentCulture);
        public static string SeleccioneUnaLinea => _resourceManager.GetString("SeleccioneUnaLinea", CultureInfo.CurrentCulture);
        public static string TiempoPerdido => _resourceManager.GetString("TiempoPerdido", CultureInfo.CurrentCulture);
        public static string TiempoEmpleado => _resourceManager.GetString("TiempoEmpleado", CultureInfo.CurrentCulture);
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
        public static string Historico => _resourceManager.GetString("Historico", CultureInfo.CurrentCulture);
        public static string Desde => _resourceManager.GetString("Desde", CultureInfo.CurrentCulture);
        public static string Hasta => _resourceManager.GetString("Hasta", CultureInfo.CurrentCulture);
        public static string Estado => _resourceManager.GetString("Estado", CultureInfo.CurrentCulture);
        public static string Todos => _resourceManager.GetString("Todos", CultureInfo.CurrentCulture);
        public static string SinResolver => _resourceManager.GetString("SinResolver", CultureInfo.CurrentCulture);
        public static string Resueltos => _resourceManager.GetString("Resueltos", CultureInfo.CurrentCulture);
        public static string Seleccione => _resourceManager.GetString("Seleccione", CultureInfo.CurrentCulture);
        public static string Fecha => _resourceManager.GetString("Fecha", CultureInfo.CurrentCulture);
        public static string AreaCargador => _resourceManager.GetString("AreaCargador", CultureInfo.CurrentCulture);
        public static string Supervisor => _resourceManager.GetString("Supervisor", CultureInfo.CurrentCulture);
        public static string CambioDeEstado => _resourceManager.GetString("CambioDeEstado", CultureInfo.CurrentCulture);
        public static string PizarraUnificada => _resourceManager.GetString("PizarraUnificada", CultureInfo.CurrentCulture);
        public static string TipoDeReunion => _resourceManager.GetString("TipoDeReunion", CultureInfo.CurrentCulture);
        public static string Diaria => _resourceManager.GetString("Diaria", CultureInfo.CurrentCulture);
        public static string Buscar => _resourceManager.GetString("Buscar", CultureInfo.CurrentCulture);
        public static string HistoricoRegistro => _resourceManager.GetString("HistoricoRegistro", CultureInfo.CurrentCulture);
        public static string SinAcceso => _resourceManager.GetString("SinAcceso", CultureInfo.CurrentCulture);
        public static String Exitosa =>_resourceManager.GetString("Exitosa", CultureInfo.CurrentCulture);
        public static string FallaLibroNovedades => _resourceManager.GetString("FallaLibroNovedades", CultureInfo.CurrentCulture);
        public static string DatosValidos => _resourceManager.GetString("DatosValidos", CultureInfo.CurrentCulture);
        public static string Gespline => _resourceManager.GetString("Gespline", CultureInfo.CurrentCulture);
        public static string Cambio => _resourceManager.GetString("Cambio", CultureInfo.CurrentCulture);
        public static string IntenteDeNuevo => _resourceManager.GetString("IntenteDeNuevo", CultureInfo.CurrentCulture);
        public static string Discrepancia2 => _resourceManager.GetString("Discrepancia", CultureInfo.CurrentCulture);
        public static string Registre => _resourceManager.GetString("Registre", CultureInfo.CurrentCulture);
        public static string GuardadoExitoso => _resourceManager.GetString("GuardadoExitoso", CultureInfo.CurrentCulture);
        public static string IntenteNuevo => _resourceManager.GetString("IntenteNuevo", CultureInfo.CurrentCulture);
        public static string Obligatoria => _resourceManager.GetString("Obligatoria", CultureInfo.CurrentCulture);
        public static string CampoVacio => _resourceManager.GetString("CampoVacio", CultureInfo.CurrentCulture);
        public static string TiempoMayor => _resourceManager.GetString("TiempoMayor", CultureInfo.CurrentCulture);
        public static string InicieSesion => _resourceManager.GetString("InicieSesion", CultureInfo.CurrentCulture);
        public static string MapTPMKey(string nombre)
        {
            return nombre switch
            {
                "MANTENIMIENTO DE CALIDAD" => "Mtto_Calidad",
                "MANTENIMIENTO AUTONOMO" => "Mtto_Autonomo",
                "SEGURIDAD" => "Seguridad",
                "MANTENIMIENTO ESPECIALIZADO" => "Mtto_Especializado",
                "NOVEDAD" => "Novedad",
                _ => nombre
            };
        }
    
    }
}