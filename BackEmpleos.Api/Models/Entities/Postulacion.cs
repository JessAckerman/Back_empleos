namespace BackEmpleos.Api.Models.Entities
{
    public class Postulacion
    {
        public int IdPostulacion { get; set; }
        public int IdOferta { get; set; }
        public int IdUsuarioTalento { get; set; }
        public DateTime FechaPostulacion { get; set; }
        public string Estado { get; set; }
        public string ComentariosCandidato { get; set; }
        public string ComentariosEmpresa { get; set; }

        public OfertaEmpleo OfertaEmpleo { get; set; }
        public Usuario UsuarioTalento { get; set; }
    }
}
