namespace BackEmpleos.Api.Models.Entities
{
    public class OfertaSkill
    {
        public int IdOfertaSkill { get; set; }
        public int IdOferta { get; set; }
        public int IdSkill { get; set; }
        public string NivelRequerido { get; set; }
        public bool EsDeseable { get; set; }

        public OfertaEmpleo OfertaEmpleo { get; set; }
        public Skill Skill { get; set; }
    }
}
