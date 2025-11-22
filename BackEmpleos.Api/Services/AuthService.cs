using BackEmpleos.Api.Data;
using BackEmpleos.Api.Interfaces;
using BackEmpleos.Api.Models.DTOs;
using BackEmpleos.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackEmpleos.Api.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;

        public AuthService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> RegisterTalentAsync(RegisterTalentDto dto)
        {
            // Validar email duplicado
            if (await _context.Usuarios.AnyAsync(u => u.Email == dto.Email))
                throw new Exception("El correo ya está registrado");

            var usuario = new Usuario
            {
                Nombre = dto.Nombre,
                Apellidos = dto.Apellidos,
                Email = dto.Email,
                Telefono = dto.Telefono,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                Rol = "TALENTO",
                FechaRegistro = DateTime.UtcNow,
                Activo = true
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            var perfil = new PerfilTalento
            {
                IdUsuario = usuario.IdUsuario,
                TituloProfesional = dto.TituloProfesional,
                Seniority = dto.Seniority,
                ExperienciaTotalAnios = dto.ExperienciaTotalAnios,
                ModalidadPreferida = dto.ModalidadPreferida,
                ExpectativaSalarialMin = dto.ExpectativaSalarialMin,
                ExpectativaSalarialMax = dto.ExpectativaSalarialMax,
                DescripcionPersonal = dto.DescripcionPersonal,
                IdEstado = dto.IdEstado,
                Ciudad = dto.Ciudad,
                DisponibilidadViajar = dto.DisponibilidadViajar,
                DisponibilidadReubicarse = dto.DisponibilidadReubicarse,
                FechaActualizacion = DateTime.UtcNow
            };

            _context.PerfilesTalento.Add(perfil);
            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task<Empresa> RegisterEmpresaAsync(RegisterEmpresaDto dto)
        {
            if (await _context.Usuarios.AnyAsync(u => u.Email == dto.EmailDueno))
                throw new Exception("El correo del dueño ya está registrado");

            var usuario = new Usuario
            {
                Nombre = dto.NombreDueno,
                Apellidos = dto.ApellidosDueno,
                Email = dto.EmailDueno,
                Telefono = dto.TelefonoDueno,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                Rol = "EMPRESA",
                FechaRegistro = DateTime.UtcNow,
                Activo = true
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            var empresa = new Empresa
            {
                IdUsuarioDueno = usuario.IdUsuario,
                NombreLegal = dto.NombreLegal,
                NombreComercial = dto.NombreComercial,
                RFC = dto.RFC,
                SitioWeb = dto.SitioWeb,
                Descripcion = dto.Descripcion,
                Tamano = dto.Tamano,
                Sector = dto.Sector,
                TelefonoContacto = dto.TelefonoContacto,
                EmailContacto = dto.EmailContacto,
                IdEstado = dto.IdEstado,
                Ciudad = dto.Ciudad,
                Direccion = dto.Direccion,
                FechaRegistro = DateTime.UtcNow
            };

            _context.Empresas.Add(empresa);
            await _context.SaveChangesAsync();

            return empresa;
        }

        public async Task<Usuario> LoginAsync(LoginDto dto)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (usuario == null)
                throw new Exception("Credenciales inválidas");

            if (!BCrypt.Net.BCrypt.Verify(dto.Password, usuario.PasswordHash))
                throw new Exception("Credenciales inválidas");

            return usuario;
        }
    }
}
