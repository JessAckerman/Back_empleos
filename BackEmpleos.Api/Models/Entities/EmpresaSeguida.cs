namespace BackEmpleos.Api.Models.Entities
{
    public class EmpresaSeguida
    {
        public int IdEmpresaSeguida { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime FechaSeguimiento { get; set; }

        public Usuario Usuario { get; set; }
        public Empresa Empresa { get; set; }
    }
}
