using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEmpleos.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CatalogoEstadosMx",
                columns: table => new
                {
                    IdEstado = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    ClaveEstado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreEstado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoEstadosMx", x => x.IdEstado);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    IdSkill = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Categoria = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.IdSkill);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Activo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuarioDueno = table.Column<int>(type: "int", nullable: false),
                    NombreLegal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreComercial = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RFC = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SitioWeb = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tamano = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sector = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoContacto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailContacto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstado = table.Column<byte>(type: "tinyint unsigned", nullable: true),
                    Ciudad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.IdEmpresa);
                    table.ForeignKey(
                        name: "FK_Empresas_CatalogoEstadosMx_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "CatalogoEstadosMx",
                        principalColumn: "IdEstado");
                    table.ForeignKey(
                        name: "FK_Empresas_Usuarios_IdUsuarioDueno",
                        column: x => x.IdUsuarioDueno,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerfilesTalento",
                columns: table => new
                {
                    IdPerfilTalento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    TituloProfesional = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Seniority = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExperienciaTotalAnios = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ModalidadPreferida = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExpectativaSalarialMin = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    ExpectativaSalarialMax = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    DescripcionPersonal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CVUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LinkedInUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GithubUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PortafolioUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstado = table.Column<byte>(type: "tinyint unsigned", nullable: true),
                    Ciudad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisponibilidadViajar = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DisponibilidadReubicarse = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilesTalento", x => x.IdPerfilTalento);
                    table.ForeignKey(
                        name: "FK_PerfilesTalento_CatalogoEstadosMx_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "CatalogoEstadosMx",
                        principalColumn: "IdEstado");
                    table.ForeignKey(
                        name: "FK_PerfilesTalento_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmpresasSeguidas",
                columns: table => new
                {
                    IdEmpresaSeguida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    FechaSeguimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresasSeguidas", x => x.IdEmpresaSeguida);
                    table.ForeignKey(
                        name: "FK_EmpresasSeguidas_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresasSeguidas_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OfertasEmpleo",
                columns: table => new
                {
                    IdOferta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoContrato = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModalidadTrabajo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeniorityRequerido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalarioMin = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    SalarioMax = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    Moneda = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstado = table.Column<byte>(type: "tinyint unsigned", nullable: true),
                    Ciudad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RemotoDesdeCualquierLugar = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaCierre = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfertasEmpleo", x => x.IdOferta);
                    table.ForeignKey(
                        name: "FK_OfertasEmpleo_CatalogoEstadosMx_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "CatalogoEstadosMx",
                        principalColumn: "IdEstado");
                    table.ForeignKey(
                        name: "FK_OfertasEmpleo_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuarioSkills",
                columns: table => new
                {
                    IdUsuarioSkill = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdSkill = table.Column<int>(type: "int", nullable: false),
                    Nivel = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AniosExperiencia = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PerfilTalentoIdPerfilTalento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioSkills", x => x.IdUsuarioSkill);
                    table.ForeignKey(
                        name: "FK_UsuarioSkills_PerfilesTalento_PerfilTalentoIdPerfilTalento",
                        column: x => x.PerfilTalentoIdPerfilTalento,
                        principalTable: "PerfilesTalento",
                        principalColumn: "IdPerfilTalento");
                    table.ForeignKey(
                        name: "FK_UsuarioSkills_Skills_IdSkill",
                        column: x => x.IdSkill,
                        principalTable: "Skills",
                        principalColumn: "IdSkill",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioSkills_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OfertasFavoritas",
                columns: table => new
                {
                    IdOfertaFavorita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdOferta = table.Column<int>(type: "int", nullable: false),
                    FechaGuardado = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfertasFavoritas", x => x.IdOfertaFavorita);
                    table.ForeignKey(
                        name: "FK_OfertasFavoritas_OfertasEmpleo_IdOferta",
                        column: x => x.IdOferta,
                        principalTable: "OfertasEmpleo",
                        principalColumn: "IdOferta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfertasFavoritas_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OfertaSkills",
                columns: table => new
                {
                    IdOfertaSkill = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdOferta = table.Column<int>(type: "int", nullable: false),
                    IdSkill = table.Column<int>(type: "int", nullable: false),
                    NivelRequerido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EsDeseable = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfertaSkills", x => x.IdOfertaSkill);
                    table.ForeignKey(
                        name: "FK_OfertaSkills_OfertasEmpleo_IdOferta",
                        column: x => x.IdOferta,
                        principalTable: "OfertasEmpleo",
                        principalColumn: "IdOferta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfertaSkills_Skills_IdSkill",
                        column: x => x.IdSkill,
                        principalTable: "Skills",
                        principalColumn: "IdSkill",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Postulaciones",
                columns: table => new
                {
                    IdPostulacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdOferta = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioTalento = table.Column<int>(type: "int", nullable: false),
                    FechaPostulacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ComentariosCandidato = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ComentariosEmpresa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postulaciones", x => x.IdPostulacion);
                    table.ForeignKey(
                        name: "FK_Postulaciones_OfertasEmpleo_IdOferta",
                        column: x => x.IdOferta,
                        principalTable: "OfertasEmpleo",
                        principalColumn: "IdOferta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Postulaciones_Usuarios_IdUsuarioTalento",
                        column: x => x.IdUsuarioTalento,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_IdEstado",
                table: "Empresas",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_IdUsuarioDueno",
                table: "Empresas",
                column: "IdUsuarioDueno",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresasSeguidas_IdEmpresa",
                table: "EmpresasSeguidas",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresasSeguidas_IdUsuario",
                table: "EmpresasSeguidas",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_OfertasEmpleo_IdEmpresa",
                table: "OfertasEmpleo",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_OfertasEmpleo_IdEstado",
                table: "OfertasEmpleo",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_OfertasFavoritas_IdOferta",
                table: "OfertasFavoritas",
                column: "IdOferta");

            migrationBuilder.CreateIndex(
                name: "IX_OfertasFavoritas_IdUsuario",
                table: "OfertasFavoritas",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_OfertaSkills_IdOferta",
                table: "OfertaSkills",
                column: "IdOferta");

            migrationBuilder.CreateIndex(
                name: "IX_OfertaSkills_IdSkill",
                table: "OfertaSkills",
                column: "IdSkill");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilesTalento_IdEstado",
                table: "PerfilesTalento",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilesTalento_IdUsuario",
                table: "PerfilesTalento",
                column: "IdUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Postulaciones_IdOferta",
                table: "Postulaciones",
                column: "IdOferta");

            migrationBuilder.CreateIndex(
                name: "IX_Postulaciones_IdUsuarioTalento",
                table: "Postulaciones",
                column: "IdUsuarioTalento");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSkills_IdSkill",
                table: "UsuarioSkills",
                column: "IdSkill");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSkills_IdUsuario",
                table: "UsuarioSkills",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSkills_PerfilTalentoIdPerfilTalento",
                table: "UsuarioSkills",
                column: "PerfilTalentoIdPerfilTalento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresasSeguidas");

            migrationBuilder.DropTable(
                name: "OfertasFavoritas");

            migrationBuilder.DropTable(
                name: "OfertaSkills");

            migrationBuilder.DropTable(
                name: "Postulaciones");

            migrationBuilder.DropTable(
                name: "UsuarioSkills");

            migrationBuilder.DropTable(
                name: "OfertasEmpleo");

            migrationBuilder.DropTable(
                name: "PerfilesTalento");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "CatalogoEstadosMx");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
