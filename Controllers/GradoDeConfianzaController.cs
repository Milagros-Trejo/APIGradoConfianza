using Microsoft.AspNetCore.Mvc;
using ServicioExternoApi.Dto;
using ServicioExternoApi.Services;

namespace ServicioExternoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GradoDeConfianzaController : ControllerBase
    {
        private IGradoConfianzaService _gradoConfianzaService;
        public GradoDeConfianzaController(IGradoConfianzaService gradoConfianzaService)
        {
            _gradoConfianzaService = gradoConfianzaService;
        }

        [HttpPost("Usuarios")]
        public List<UsuarioResponseDto> ObtenerGradoDeConfianzaUsuarios(List<UsuarioRequestDto> gradoConfianzaRequests)
        {
            var gradoConfianzaResponses = new List<UsuarioResponseDto>();
            foreach (var request in gradoConfianzaRequests)
            {
                var response = _gradoConfianzaService.CalcularGradoConfianzaUsuario(request);
                gradoConfianzaResponses.Add(response);
            }
            return gradoConfianzaResponses;
        }

        [HttpPost("Comunidades")]
        public List<ComunidadResponseDto> ObtenerGradoDeConfianzaComunidades(List<ComunidadRequestDto> gradoConfianzaRequests)
        {
            var gradoConfianzaResponses = new List<ComunidadResponseDto>();
            foreach (var request in gradoConfianzaRequests)
            {
                var response = _gradoConfianzaService.CalcularGradoConfianzaComunidad(request);
                gradoConfianzaResponses.Add(response);
            }
            return gradoConfianzaResponses;
        }

        [HttpPost("Usuario")]
        public UsuarioResponseDto ObtenerGradoDeConfianzaUsuario(UsuarioRequestDto gradoConfianzaRequest)
        {
            return _gradoConfianzaService.CalcularGradoConfianzaUsuario(gradoConfianzaRequest);
        }

        [HttpPost("Comunidad")]
        public ComunidadResponseDto ObtenerGradoDeConfianzaComunidad(ComunidadRequestDto gradoConfianzaRequests)
        {
            return _gradoConfianzaService.CalcularGradoConfianzaComunidad(gradoConfianzaRequests);
        }
    }
}
