using BackEmpleos.Api.Interfaces;
using BackEmpleos.Api.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BackEmpleos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;

        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }

        [HttpPost("register-talent")]
        public async Task<IActionResult> RegisterTalent([FromBody] RegisterTalentDto dto)
        {
            try
            {
                var usuario = await _auth.RegisterTalentAsync(dto);
                return Ok(new { mensaje = "Registro de talento exitoso", usuario.IdUsuario, usuario.Email });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("register-empresa")]
        public async Task<IActionResult> RegisterEmpresa([FromBody] RegisterEmpresaDto dto)
        {
            try
            {
                var empresa = await _auth.RegisterEmpresaAsync(dto);
                return Ok(new { mensaje = "Registro de empresa exitoso", empresa.IdEmpresa });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            try
            {
                var usuario = await _auth.LoginAsync(dto);
                // Más adelante aquí generamos el JWT
                return Ok(new
                {
                    mensaje = "Login correcto",
                    usuario.IdUsuario,
                    usuario.Email,
                    usuario.Rol
                });
            }
            catch (Exception ex)
            {
                return Unauthorized(new { error = ex.Message });
            }
        }
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok(new { message = "Backend funcionando correctamente 🔥" });
        }

    }
}
