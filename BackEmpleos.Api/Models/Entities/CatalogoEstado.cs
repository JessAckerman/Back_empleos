namespace BackEmpleos.Api.Models.Entities
{
    public class CatalogoEstado
    {
        public byte IdEstado { get; set; }
        public string ClaveEstado { get; set; }
        public string NombreEstado { get; set; }


        public ICollection<Empresa> Empresas { get; set; }
        public ICollection<PerfilTalento> PerfilesTalento { get; set; }
        public ICollection<OfertaEmpleo> OfertasEmpleo { get; set; }
    }
}
