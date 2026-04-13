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

        public static string RequiredUserName => _resourceManager.GetString(nameof(RequiredUserName), CultureInfo.CurrentUICulture)!;
        public static string RequiredPassword => _resourceManager.GetString(nameof(RequiredPassword), CultureInfo.CurrentUICulture)!;
        public static string RequiredEquipment => _resourceManager.GetString(nameof(RequiredEquipment), CultureInfo.CurrentUICulture)!;
        public static string RequiredObservation => _resourceManager.GetString(nameof(RequiredObservation), CultureInfo.CurrentUICulture)!;
        public static string RequiredSheet => _resourceManager.GetString(nameof(RequiredSheet), CultureInfo.CurrentUICulture)!;
        public static string ErrorGeneral => _resourceManager.GetString(nameof(ErrorGeneral), CultureInfo.CurrentUICulture)!;
        public static string ErrorDesarrollo => _resourceManager.GetString(nameof(ErrorDesarrollo), CultureInfo.CurrentUICulture)!;
        public static string Recargar => _resourceManager.GetString(nameof(Recargar), CultureInfo.CurrentUICulture)!;
        public static string Formato => _resourceManager.GetString(nameof(Formato), CultureInfo.CurrentUICulture)!;
        public static string LibroDeNovedades => _resourceManager.GetString(nameof(LibroDeNovedades), CultureInfo.CurrentUICulture)!;
        public static string Pais => _resourceManager.GetString(nameof(Pais), CultureInfo.CurrentUICulture)!;
        public static string SeleccioneUnPais => _resourceManager.GetString(nameof(SeleccioneUnPais), CultureInfo.CurrentUICulture)!;
        public static string Cargando => _resourceManager.GetString(nameof(Cargando), CultureInfo.CurrentUICulture)!;
        public static string Empresas => _resourceManager.GetString(nameof(Empresas), CultureInfo.CurrentUICulture)!;
        public static string SeleccioneUnaEmpresa => _resourceManager.GetString(nameof(SeleccioneUnaEmpresa), CultureInfo.CurrentUICulture)!;
        public static string Centro => _resourceManager.GetString(nameof(Centro), CultureInfo.CurrentUICulture)!;
        public static string SeleccioneUnCentro => _resourceManager.GetString(nameof(SeleccioneUnCentro), CultureInfo.CurrentUICulture)!;
        public static string Divisiones => _resourceManager.GetString(nameof(Divisiones), CultureInfo.CurrentUICulture)!;
        public static string SeleccioneUnaDivision => _resourceManager.GetString(nameof(SeleccioneUnaDivision), CultureInfo.CurrentUICulture)!;
        public static string Linea => _resourceManager.GetString(nameof(Linea), CultureInfo.CurrentUICulture)!;
        public static string SeleccioneUnaLinea => _resourceManager.GetString(nameof(SeleccioneUnaLinea), CultureInfo.CurrentUICulture)!;
        public static string TiempoPerdido => _resourceManager.GetString(nameof(TiempoPerdido), CultureInfo.CurrentUICulture)!;
        public static string TiempoEmpleado => _resourceManager.GetString(nameof(TiempoEmpleado), CultureInfo.CurrentUICulture)!;
        public static string Causa => _resourceManager.GetString(nameof(Causa), CultureInfo.CurrentUICulture)!;
        public static string Seleccionar => _resourceManager.GetString(nameof(Seleccionar), CultureInfo.CurrentUICulture)!;
        public static string SinPerdidaDeTiempo => _resourceManager.GetString(nameof(SinPerdidaDeTiempo), CultureInfo.CurrentUICulture)!;
        public static string SeleccionarGrupo => _resourceManager.GetString(nameof(SeleccionarGrupo), CultureInfo.CurrentUICulture)!;
        public static string Grupo => _resourceManager.GetString(nameof(Grupo), CultureInfo.CurrentUICulture)!;
        public static string Turno => _resourceManager.GetString(nameof(Turno), CultureInfo.CurrentUICulture)!;
        public static string CodigoEquipo => _resourceManager.GetString(nameof(CodigoEquipo), CultureInfo.CurrentUICulture)!;
        public static string Ficha => _resourceManager.GetString(nameof(Ficha), CultureInfo.CurrentUICulture)!;
        public static string FichaSupervisor => _resourceManager.GetString(nameof(FichaSupervisor), CultureInfo.CurrentUICulture)!;
        public static string ClasificacionTPM => _resourceManager.GetString(nameof(ClasificacionTPM), CultureInfo.CurrentUICulture)!;
        public static string Resuelto => _resourceManager.GetString(nameof(Resuelto), CultureInfo.CurrentUICulture)!;
        public static string Si => _resourceManager.GetString(nameof(Si), CultureInfo.CurrentUICulture)!;
        public static string No => _resourceManager.GetString(nameof(No), CultureInfo.CurrentUICulture)!;
        public static string Discrepancia => _resourceManager.GetString(nameof(Discrepancia), CultureInfo.CurrentUICulture)!;
        public static string Observacion => _resourceManager.GetString(nameof(Observacion), CultureInfo.CurrentUICulture)!;
        public static string Accion => _resourceManager.GetString(nameof(Accion), CultureInfo.CurrentUICulture)!;
        public static string Registrar => _resourceManager.GetString(nameof(Registrar), CultureInfo.CurrentUICulture)!;
        public static string Atras => _resourceManager.GetString(nameof(Atras),CultureInfo.CurrentUICulture)!;
        public static string Seccion => _resourceManager.GetString(nameof(Seccion), CultureInfo.CurrentUICulture)!;
        public static string Descripcion => _resourceManager.GetString(nameof(Descripcion), CultureInfo.CurrentUICulture)!;
        public static string Tiempo => _resourceManager.GetString(nameof(Tiempo), CultureInfo.CurrentUICulture)!;
        public static string ColoqueLinea => _resourceManager.GetString(nameof(ColoqueLinea), CultureInfo.CurrentUICulture)!;
        public static string Actualizado => _resourceManager.GetString(nameof(Actualizado), CultureInfo.CurrentUICulture)!;
        public static string PorActualizar => _resourceManager.GetString((PorActualizar), CultureInfo.CurrentUICulture)!;
        public static string Historico => _resourceManager.GetString(nameof(Historico), CultureInfo.CurrentUICulture)!;
        public static string Desde => _resourceManager.GetString(nameof(Desde), CultureInfo.CurrentUICulture)!;
        public static string Hasta => _resourceManager.GetString(nameof(Hasta), CultureInfo.CurrentUICulture)!;
        public static string Estado => _resourceManager.GetString(nameof(Estado), CultureInfo.CurrentUICulture)!;
        public static string Todos => _resourceManager.GetString(nameof(Todos), CultureInfo.CurrentUICulture)!;
        public static string SinResolver => _resourceManager.GetString(nameof(SinResolver), CultureInfo.CurrentUICulture)!;
        public static string Resueltos => _resourceManager.GetString(nameof(Resueltos), CultureInfo.CurrentUICulture)!;
        public static string Seleccione => _resourceManager.GetString(nameof(Seleccione), CultureInfo.CurrentUICulture)!;
        public static string Fecha => _resourceManager.GetString(nameof(Fecha), CultureInfo.CurrentUICulture)!;
        public static string AreaCargador => _resourceManager.GetString(nameof(AreaCargador), CultureInfo.CurrentUICulture)!;
        public static string Supervisor => _resourceManager.GetString(nameof(Supervisor), CultureInfo.CurrentUICulture)!;
        public static string CambioDeEstado => _resourceManager.GetString(nameof(CambioDeEstado), CultureInfo.CurrentUICulture)!;
        public static string PizarraUnificada => _resourceManager.GetString(nameof(PizarraUnificada), CultureInfo.CurrentUICulture)!;
        public static string TipoDeReunion => _resourceManager.GetString(nameof(TipoDeReunion), CultureInfo.CurrentUICulture)!;
        public static string Diaria => _resourceManager.GetString(nameof(Diaria), CultureInfo.CurrentUICulture)!;
        public static string Buscar => _resourceManager.GetString(nameof(Buscar), CultureInfo.CurrentUICulture)!;
        public static string HistoricoRegistro => _resourceManager.GetString(nameof(HistoricoRegistro), CultureInfo.CurrentUICulture)!;
        public static string SinAcceso => _resourceManager.GetString(nameof(SinAcceso), CultureInfo.CurrentUICulture)!;
        public static string Exitosa =>_resourceManager.GetString(nameof(Exitosa), CultureInfo.CurrentUICulture)!;
        public static string FallaLibroNovedades => _resourceManager.GetString(nameof(FallaLibroNovedades), CultureInfo.CurrentUICulture)!;
        public static string DatosValidos => _resourceManager.GetString(nameof(DatosValidos), CultureInfo.CurrentUICulture)!;
        public static string Gespline => _resourceManager.GetString(nameof(Gespline), CultureInfo.CurrentUICulture)!;
        public static string Cambio => _resourceManager.GetString(nameof(Cambio), CultureInfo.CurrentUICulture)!;
        public static string IntenteDeNuevo => _resourceManager.GetString(nameof(IntenteDeNuevo), CultureInfo.CurrentUICulture)!;
        public static string Discrepancia2 => _resourceManager.GetString(nameof(Discrepancia), CultureInfo.CurrentUICulture)!;
        public static string Registre => _resourceManager.GetString(nameof(Registre), CultureInfo.CurrentUICulture)!;
        public static string GuardadoExitoso => _resourceManager.GetString(nameof(GuardadoExitoso), CultureInfo.CurrentUICulture)!;
        public static string IntenteNuevo => _resourceManager.GetString(nameof(IntenteNuevo), CultureInfo.CurrentUICulture)!;
        public static string Obligatoria => _resourceManager.GetString(nameof(Obligatoria), CultureInfo.CurrentUICulture)!;
        public static string CampoVacio => _resourceManager.GetString(nameof(CampoVacio), CultureInfo.CurrentUICulture)!;
        public static string TiempoMayor => _resourceManager.GetString(nameof(TiempoMayor), CultureInfo.CurrentUICulture)!;
        public static string InicieSesion => _resourceManager.GetString(nameof(InicieSesion), CultureInfo.CurrentUICulture)!;
        public static string Operaciones => _resourceManager.GetString(nameof(Operaciones), CultureInfo.CurrentUICulture)!;
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