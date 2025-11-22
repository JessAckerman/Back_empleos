using BackEmpleos.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackEmpleos.Api.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Empresa> Empresas { get; set; }
		public DbSet<CatalogoEstado> CatalogoEstadosMx { get; set; }
		public DbSet<PerfilTalento> PerfilesTalento { get; set; }
		public DbSet<OfertaEmpleo> OfertasEmpleo { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<UsuarioSkill> UsuarioSkills { get; set; }
		public DbSet<OfertaSkill> OfertaSkills { get; set; }
		public DbSet<Postulacion> Postulaciones { get; set; }
		public DbSet<OfertaFavorita> OfertasFavoritas { get; set; }
		public DbSet<EmpresaSeguida> EmpresasSeguidas { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Usuario>().ToTable("Usuarios");
			modelBuilder.Entity<Empresa>().ToTable("Empresas");
			modelBuilder.Entity<CatalogoEstado>().ToTable("CatalogoEstadosMx");
			modelBuilder.Entity<PerfilTalento>().ToTable("PerfilesTalento");
			modelBuilder.Entity<OfertaEmpleo>().ToTable("OfertasEmpleo");
			modelBuilder.Entity<Skill>().ToTable("Skills");
			modelBuilder.Entity<UsuarioSkill>().ToTable("UsuarioSkills");
			modelBuilder.Entity<OfertaSkill>().ToTable("OfertaSkills");
			modelBuilder.Entity<Postulacion>().ToTable("Postulaciones");
			modelBuilder.Entity<OfertaFavorita>().ToTable("OfertasFavoritas");
			modelBuilder.Entity<EmpresaSeguida>().ToTable("EmpresasSeguidas");

			modelBuilder.Entity<Usuario>().HasKey(x => x.IdUsuario);
			modelBuilder.Entity<Empresa>().HasKey(x => x.IdEmpresa);
			modelBuilder.Entity<CatalogoEstado>().HasKey(x => x.IdEstado);
			modelBuilder.Entity<PerfilTalento>().HasKey(x => x.IdPerfilTalento);
			modelBuilder.Entity<OfertaEmpleo>().HasKey(x => x.IdOferta);
			modelBuilder.Entity<Skill>().HasKey(x => x.IdSkill);
			modelBuilder.Entity<UsuarioSkill>().HasKey(x => x.IdUsuarioSkill);
			modelBuilder.Entity<OfertaSkill>().HasKey(x => x.IdOfertaSkill);
			modelBuilder.Entity<Postulacion>().HasKey(x => x.IdPostulacion);
			modelBuilder.Entity<OfertaFavorita>().HasKey(x => x.IdOfertaFavorita);
			modelBuilder.Entity<EmpresaSeguida>().HasKey(x => x.IdEmpresaSeguida);


			modelBuilder.Entity<Empresa>()
				.HasOne(e => e.UsuarioDueno)
				.WithOne(u => u.Empresa)
				.HasForeignKey<Empresa>(e => e.IdUsuarioDueno);

			modelBuilder.Entity<Empresa>()
				.HasOne(e => e.Estado)
				.WithMany(c => c.Empresas)
				.HasForeignKey(e => e.IdEstado);

			modelBuilder.Entity<PerfilTalento>()
				.HasOne(p => p.Usuario)
				.WithOne(u => u.PerfilTalento)
				.HasForeignKey<PerfilTalento>(p => p.IdUsuario);

			modelBuilder.Entity<PerfilTalento>()
				.HasOne(p => p.Estado)
				.WithMany(e => e.PerfilesTalento)
				.HasForeignKey(p => p.IdEstado);

			modelBuilder.Entity<OfertaEmpleo>()
				.HasOne(o => o.Empresa)
				.WithMany(e => e.OfertasEmpleo)
				.HasForeignKey(o => o.IdEmpresa);

			modelBuilder.Entity<OfertaEmpleo>()
				.HasOne(o => o.EstadoMx)
				.WithMany(e => e.OfertasEmpleo)
				.HasForeignKey(o => o.IdEstado);

			modelBuilder.Entity<UsuarioSkill>()
				.HasOne(us => us.Usuario)
				.WithMany(u => u.UsuarioSkills)
				.HasForeignKey(us => us.IdUsuario);

			modelBuilder.Entity<UsuarioSkill>()
				.HasOne(us => us.Skill)
				.WithMany(s => s.UsuarioSkills)
				.HasForeignKey(us => us.IdSkill);

			modelBuilder.Entity<OfertaSkill>()
				.HasOne(os => os.OfertaEmpleo)
				.WithMany(o => o.OfertaSkills)
				.HasForeignKey(os => os.IdOferta);

			modelBuilder.Entity<OfertaSkill>()
				.HasOne(os => os.Skill)
				.WithMany(s => s.OfertaSkills)
				.HasForeignKey(os => os.IdSkill);

			modelBuilder.Entity<Postulacion>()
				.HasOne(p => p.OfertaEmpleo)
				.WithMany(o => o.Postulaciones)
				.HasForeignKey(p => p.IdOferta);

			modelBuilder.Entity<Postulacion>()
				.HasOne(p => p.UsuarioTalento)
				.WithMany(u => u.Postulaciones)
				.HasForeignKey(p => p.IdUsuarioTalento);

			modelBuilder.Entity<OfertaFavorita>()
				.HasOne(of => of.Usuario)
				.WithMany(u => u.OfertasFavoritas)
				.HasForeignKey(of => of.IdUsuario);

			modelBuilder.Entity<OfertaFavorita>()
				.HasOne(of => of.OfertaEmpleo)
				.WithMany(o => o.Favoritos)
				.HasForeignKey(of => of.IdOferta);

			modelBuilder.Entity<EmpresaSeguida>()
				.HasOne(es => es.Usuario)
				.WithMany(u => u.EmpresasSeguidas)
				.HasForeignKey(es => es.IdUsuario);

			modelBuilder.Entity<EmpresaSeguida>()
				.HasOne(es => es.Empresa)
				.WithMany(e => e.Seguidores)
				.HasForeignKey(es => es.IdEmpresa);
		}
	}
}