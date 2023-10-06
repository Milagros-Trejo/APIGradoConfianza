using ServicioExternoApi.Dto;

namespace ServicioExternoApi.Services
{
    public class GradoConfianzaService : IGradoConfianzaService
    {
        public ComunidadResponseDto CalcularGradoConfianzaComunidad(ComunidadRequestDto gradoConfianzaRequest)
        {
            var gradoConfianzaResponse = new ComunidadResponseDto();
            gradoConfianzaResponse.idComunidad = gradoConfianzaRequest.idComunidad;

            var promedioGrados = gradoConfianzaRequest.gradosConfianzaUsuarios.Average();
            var cantUsuariosConReservas = gradoConfianzaRequest.gradosConfianzaUsuarios.Where(gc => (gc >= 2 && gc <= 3))
                                                                                        .ToList().Count;

            gradoConfianzaResponse.gradoConfianzaFinal = promedioGrados - cantUsuariosConReservas * 0.2;
            return gradoConfianzaResponse;
        }

        public UsuarioResponseDto CalcularGradoConfianzaUsuario(UsuarioRequestDto gradoConfianzaRequest)
        {
            var gradoConfianzaResponse = new UsuarioResponseDto();
            gradoConfianzaResponse.idUsuario = gradoConfianzaRequest.idUsuario;
            gradoConfianzaResponse.gradoConfianzaFinal = gradoConfianzaRequest.gradoActualConfianza 
                                                        - gradoConfianzaRequest.cantidadAperturasFraudulentas * 0.2
                                                        - gradoConfianzaRequest.cantidadCierresFraudulentos * 0.2
                                                        + gradoConfianzaRequest.cantidadInteraccionesCorrectas * 0.5;

            return gradoConfianzaResponse;
        }
    }
}
