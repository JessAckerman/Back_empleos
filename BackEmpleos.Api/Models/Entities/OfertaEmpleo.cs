namespace BackEmpleos.Api.Models.Entities
{
    public class OfertaEmpleo
    {
        public int IdOferta { get; set; }
        public int IdEmpresa { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string TipoContrato { get; set; }
        public string ModalidadTrabajo { get; set; }
        public string SeniorityRequerido { get; set; }
        public decimal? SalarioMin { get; set; }
        public decimal? SalarioMax { get; set; }
        public string Moneda { get; set; }
        public byte? IdEstado { get; set; }
        public string Ciudad { get; set; }
        public bool RemotoDesdeCualquierLugar { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string Estado { get; set; }

        public Empresa Empresa { get; set; }
        public CatalogoEstado EstadoMx { get; set; }
        public ICollection<OfertaSkill> OfertaSkills { get; set; }
        public ICollection<Postulacion> Postulaciones { get; set; }
        public ICollection<OfertaFavorita> Favoritos { get; set; }
    }
}
