namespace BackEmpleos.Api.Models.Entities
{
    public class UsuarioSkill
    {
        public int IdUsuarioSkill { get; set; }
        public int IdUsuario { get; set; }
        public int IdSkill { get; set; }
        public string Nivel { get; set; }
        public decimal AniosExperiencia { get; set; }

        public Usuario Usuario { get; set; }
        public Skill Skill { get; set; }
    }
}
