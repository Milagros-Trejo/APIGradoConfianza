namespace ServicioExternoApi.Dto
{
    public class UsuarioRequestDto
    {
        public long idUsuario { get; set; }
        public double gradoActualConfianza { get; set; }
        public int cantidadCierresFraudulentos { get; set; }
        public int cantidadAperturasFraudulentas { get; set; }
        public int cantidadInteraccionesCorrectas { get; set; }
    }
}
