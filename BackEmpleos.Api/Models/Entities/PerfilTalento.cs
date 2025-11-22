namespace BackEmpleos.Api.Models.Entities
{
    public class PerfilTalento
    {
        public int IdPerfilTalento { get; set; }
        public int IdUsuario { get; set; }
        public string TituloProfesional { get; set; }
        public string Seniority { get; set; }
        public decimal ExperienciaTotalAnios { get; set; }
        public string ModalidadPreferida { get; set; }
        public decimal? ExpectativaSalarialMin { get; set; }
        public decimal? ExpectativaSalarialMax { get; set; }
        public string DescripcionPersonal { get; set; }
        public string CVUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string GithubUrl { get; set; }
        public string PortafolioUrl { get; set; }
        public byte? IdEstado { get; set; }
        public string Ciudad { get; set; }
        public bool DisponibilidadViajar { get; set; }
        public bool DisponibilidadReubicarse { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public Usuario Usuario { get; set; }
        public CatalogoEstado Estado { get; set; }
        public ICollection<UsuarioSkill> UsuarioSkills { get; set; }
    }
}
