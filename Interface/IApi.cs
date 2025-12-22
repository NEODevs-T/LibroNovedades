
using LibroNovedades.DTOs;

namespace LibroNovedades.Data.API
{
    public interface IDataAPI
    {
        // Turnos: resultados NO agrupados
        Task<List<ParadasActualesDTO>?> GetParadasActuales1Turno(string centroCosto);
        Task<List<ParadasActualesDTO>?> GetParadasActuales2Turno(string centroCosto);

        // Turnos: resultados AGRUPADOS
        Task<List<ParadasActualesAgrupadasDTO>?> GetParadasActuales1TurnoAgrupados(string centroCosto);
        Task<List<ParadasActualesAgrupadasDTO>?> GetParadasActuales2TurnoDespuesDeLas0amAgrupadas(string centroCosto);
        Task<List<ParadasActualesAgrupadasDTO>?> GetParadasActuales2TurnoAntesDeLas0amAgrupadas(string centroCosto);

        // Selector por hora que retorna AGRUPADOS tipados
        Task<List<ParadasActualesAgrupadasDTO>?> GetParadasActualesTurnoPorLineaAgrupadas(string centroCosto);

        // Otros
        Task<List<string>?> ObtenerTurnoYGrupo();
    }
}
