using ServicioExternoApi.Dto;

namespace ServicioExternoApi.Services
{
    public interface IGradoConfianzaService
    {
        UsuarioResponseDto CalcularGradoConfianzaUsuario(UsuarioRequestDto gradoConfianzaRequest);
        ComunidadResponseDto CalcularGradoConfianzaComunidad(ComunidadRequestDto gradoConfianzaRequest);
    }
}
