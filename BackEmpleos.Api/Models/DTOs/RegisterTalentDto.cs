namespace BackEmpleos.Api.Models.DTOs
{
    public class RegisterTalentDto
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Password { get; set; }

        public string TituloProfesional { get; set; }
        public string Seniority { get; set; }  // "Junior", "Mid", etc.
        public decimal ExperienciaTotalAnios { get; set; }
        public string ModalidadPreferida { get; set; } // "Remoto", etc.
        public decimal? ExpectativaSalarialMin { get; set; }
        public decimal? ExpectativaSalarialMax { get; set; }
        public string DescripcionPersonal { get; set; }

        public byte? IdEstado { get; set; }
        public string Ciudad { get; set; }
        public bool DisponibilidadViajar { get; set; }
        public bool DisponibilidadReubicarse { get; set; }
    }
}
