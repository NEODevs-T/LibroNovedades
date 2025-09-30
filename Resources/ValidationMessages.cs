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
        public static string RequiredSheet => _resourceManager.GetString("RequiredSheet", CultureInfo.CurrentUICulture);
        public static string ErrorGeneral => _resourceManager.GetString("ErrorGeneral", CultureInfo.CurrentUICulture);
        public static string ErrorDesarrollo => _resourceManager.GetString("ErrorDesarrollo", CultureInfo.CurrentUICulture);
        public static string Recargar => _resourceManager.GetString("Recargar", CultureInfo.CurrentUICulture);
        public static string Formato => _resourceManager.GetString("Formato", CultureInfo.CurrentUICulture);
        public static string LibroDeNovedades => _resourceManager.GetString("LibroDeNovedades", CultureInfo.CurrentUICulture);
        public static string Pais => _resourceManager.GetString("Pais", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnPais => _resourceManager.GetString("SeleccioneUnPais", CultureInfo.CurrentUICulture);
        public static string Cargando => _resourceManager.GetString("Cargando", CultureInfo.CurrentUICulture);
        public static string Empresas => _resourceManager.GetString("Empresas", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnaEmpresa => _resourceManager.GetString("SeleccioneUnaEmpresa", CultureInfo.CurrentUICulture);
        public static string Centro => _resourceManager.GetString("Centro", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnCentro => _resourceManager.GetString("SeleccioneUnCentro", CultureInfo.CurrentUICulture);
        public static string Divisiones => _resourceManager.GetString("Divisiones", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnaDivision => _resourceManager.GetString("SeleccioneUnaDivision", CultureInfo.CurrentUICulture);
        public static string Linea => _resourceManager.GetString("Linea", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnaLinea => _resourceManager.GetString("SeleccioneUnaLinea", CultureInfo.CurrentUICulture);
        public static string TiempoPerdido => _resourceManager.GetString("TiempoPerdido", CultureInfo.CurrentUICulture);
        public static string TiempoEmpleado => _resourceManager.GetString("TiempoEmpleado", CultureInfo.CurrentUICulture);
        public static string Causa => _resourceManager.GetString("Causa", CultureInfo.CurrentUICulture);
        public static string Seleccionar => _resourceManager.GetString("Seleccionar", CultureInfo.CurrentUICulture);
        public static string SinPerdidaDeTiempo => _resourceManager.GetString("SinPerdidaDeTiempo", CultureInfo.CurrentUICulture);
        public static string SeleccionarGrupo => _resourceManager.GetString("SeleccionarGrupo", CultureInfo.CurrentUICulture);
        public static string Grupo => _resourceManager.GetString("Grupo", CultureInfo.CurrentUICulture);
        public static string Turno => _resourceManager.GetString("Turno", CultureInfo.CurrentUICulture);
        public static string CodigoEquipo => _resourceManager.GetString("CodigoEquipo", CultureInfo.CurrentUICulture);
        public static string Ficha => _resourceManager.GetString("Ficha", CultureInfo.CurrentUICulture);
        public static string FichaSupervisor => _resourceManager.GetString("FichaSupervisor", CultureInfo.CurrentUICulture);
        public static string ClasificacionTPM => _resourceManager.GetString("ClasificacionTPM", CultureInfo.CurrentUICulture);
        public static string Resuelto => _resourceManager.GetString("Resuelto", CultureInfo.CurrentUICulture);
        public static string Si => _resourceManager.GetString("Si", CultureInfo.CurrentUICulture);
        public static string No => _resourceManager.GetString("No", CultureInfo.CurrentUICulture);
        public static string Discrepancia => _resourceManager.GetString("Discrepancia", CultureInfo.CurrentUICulture);
        public static string Observacion => _resourceManager.GetString("Observacion", CultureInfo.CurrentUICulture);
        public static string Accion => _resourceManager.GetString("Accion", CultureInfo.CurrentUICulture);
        public static string Registrar => _resourceManager.GetString("Registrar", CultureInfo.CurrentUICulture);
        public static string Atras => _resourceManager.GetString("Atras",CultureInfo.CurrentUICulture);
        public static string Seccion => _resourceManager.GetString("Seccion", CultureInfo.CurrentUICulture);
        public static string Descripcion => _resourceManager.GetString("Descripcion", CultureInfo.CurrentUICulture);
        public static string Tiempo => _resourceManager.GetString("Tiempo", CultureInfo.CurrentUICulture);
        public static string ColoqueLinea => _resourceManager.GetString("ColoqueLinea", CultureInfo.CurrentUICulture);
        public static string Actualizado => _resourceManager.GetString("Actualizado", CultureInfo.CurrentUICulture);
        public static string PorActualizar => _resourceManager.GetString("PorActualizar", CultureInfo.CurrentUICulture);
        public static string Historico => _resourceManager.GetString("Historico", CultureInfo.CurrentUICulture);
        public static string Desde => _resourceManager.GetString("Desde", CultureInfo.CurrentUICulture);
        public static string Hasta => _resourceManager.GetString("Hasta", CultureInfo.CurrentUICulture);
        public static string Estado => _resourceManager.GetString("Estado", CultureInfo.CurrentUICulture);
        public static string Todos => _resourceManager.GetString("Todos", CultureInfo.CurrentUICulture);
        public static string SinResolver => _resourceManager.GetString("SinResolver", CultureInfo.CurrentUICulture);
        public static string Resueltos => _resourceManager.GetString("Resueltos", CultureInfo.CurrentUICulture);
        public static string Seleccione => _resourceManager.GetString("Seleccione", CultureInfo.CurrentUICulture);
        public static string Fecha => _resourceManager.GetString("Fecha", CultureInfo.CurrentUICulture);
        public static string AreaCargador => _resourceManager.GetString("AreaCargador", CultureInfo.CurrentUICulture);
        public static string Supervisor => _resourceManager.GetString("Supervisor", CultureInfo.CurrentUICulture);
        public static string CambioDeEstado => _resourceManager.GetString("CambioDeEstado", CultureInfo.CurrentUICulture);
        public static string PizarraUnificada => _resourceManager.GetString("PizarraUnificada", CultureInfo.CurrentUICulture);
        public static string TipoDeReunion => _resourceManager.GetString("TipoDeReunion", CultureInfo.CurrentUICulture);
        public static string Diaria => _resourceManager.GetString("Diaria", CultureInfo.CurrentUICulture);
        public static string Buscar => _resourceManager.GetString("Buscar", CultureInfo.CurrentUICulture);
        public static string HistoricoRegistro => _resourceManager.GetString("HistoricoRegistro", CultureInfo.CurrentUICulture);
        public static string SinAcceso => _resourceManager.GetString("SinAcceso", CultureInfo.CurrentUICulture);
        public static String Exitosa =>_resourceManager.GetString("Exitosa", CultureInfo.CurrentUICulture);
        public static string FallaLibroNovedades => _resourceManager.GetString("FallaLibroNovedades", CultureInfo.CurrentUICulture);
        public static string DatosValidos => _resourceManager.GetString("DatosValidos", CultureInfo.CurrentUICulture);
        public static string Gespline => _resourceManager.GetString("Gespline", CultureInfo.CurrentUICulture);
        public static string Cambio => _resourceManager.GetString("Cambio", CultureInfo.CurrentUICulture);
        public static string IntenteDeNuevo => _resourceManager.GetString("IntenteDeNuevo", CultureInfo.CurrentUICulture);
        public static string Discrepancia2 => _resourceManager.GetString("Discrepancia", CultureInfo.CurrentUICulture);
        public static string Registre => _resourceManager.GetString("Registre", CultureInfo.CurrentUICulture);
        public static string GuardadoExitoso => _resourceManager.GetString("GuardadoExitoso", CultureInfo.CurrentUICulture);
        public static string IntenteNuevo => _resourceManager.GetString("IntenteNuevo", CultureInfo.CurrentUICulture);
        public static string Obligatoria => _resourceManager.GetString("Obligatoria", CultureInfo.CurrentUICulture);
        public static string CampoVacio => _resourceManager.GetString("CampoVacio", CultureInfo.CurrentUICulture);
        public static string TiempoMayor => _resourceManager.GetString("TiempoMayor", CultureInfo.CurrentUICulture);
        public static string InicieSesion => _resourceManager.GetString("InicieSesion", CultureInfo.CurrentUICulture);
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