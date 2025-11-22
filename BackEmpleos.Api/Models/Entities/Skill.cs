namespace BackEmpleos.Api.Models.Entities
{
    public class Skill
    {
        public int IdSkill { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }

        public ICollection<UsuarioSkill> UsuarioSkills { get; set; }
        public ICollection<OfertaSkill> OfertaSkills { get; set; }
    }
}
