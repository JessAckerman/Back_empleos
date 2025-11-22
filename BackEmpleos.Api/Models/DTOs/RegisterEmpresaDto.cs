namespace BackEmpleos.Api.Models.DTOs
{
    public class RegisterEmpresaDto
    {
        // Datos del usuario dueño
        public string NombreDueno { get; set; }
        public string ApellidosDueno { get; set; }
        public string EmailDueno { get; set; }
        public string TelefonoDueno { get; set; }
        public string Password { get; set; }

        // Datos de la empresa
        public string NombreLegal { get; set; }
        public string NombreComercial { get; set; }
        public string RFC { get; set; }
        public string SitioWeb { get; set; }
        public string Descripcion { get; set; }
        public string Tamano { get; set; }
        public string Sector { get; set; }
        public string TelefonoContacto { get; set; }
        public string EmailContacto { get; set; }
        public byte? IdEstado { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
    }
}
