namespace BackEmpleos.Api.Models.Entities
{
	public class OfertaFavorita
	{
		public int IdOfertaFavorita { get; set; }
		public int IdUsuario { get; set; }
		public int IdOferta { get; set; }
		public DateTime FechaGuardado { get; set; }

		public Usuario Usuario { get; set; }
		public OfertaEmpleo OfertaEmpleo { get; set; }
	}
}
