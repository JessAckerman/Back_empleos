namespace BackEmpleos.Api.Models.Entities
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public int IdUsuarioDueno { get; set; }
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
        public DateTime FechaRegistro { get; set; }

        public Usuario UsuarioDueno { get; set; }
        public CatalogoEstado Estado { get; set; }

        public ICollection<OfertaEmpleo> OfertasEmpleo { get; set; }
        public ICollection<EmpresaSeguida> Seguidores { get; set; }
    }
}
