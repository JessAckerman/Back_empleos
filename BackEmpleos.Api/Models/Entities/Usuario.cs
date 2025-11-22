namespace BackEmpleos.Api.Models.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Telefono { get; set; }
        public string Rol { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        public Empresa Empresa { get; set; }
        public PerfilTalento PerfilTalento { get; set; }
        public ICollection<UsuarioSkill> UsuarioSkills { get; set; }
        public ICollection<Postulacion> Postulaciones { get; set; }
        public ICollection<OfertaFavorita> OfertasFavoritas { get; set; }
        public ICollection<EmpresaSeguida> EmpresasSeguidas { get; set; }
    }
}
