using BackEmpleos.Api.Models.DTOs;
using BackEmpleos.Api.Models.Entities;

namespace BackEmpleos.Api.Interfaces
{
    public interface IAuthService
    {
        Task<Usuario> RegisterTalentAsync(RegisterTalentDto dto);
        Task<Empresa> RegisterEmpresaAsync(RegisterEmpresaDto dto);
        Task<Usuario> LoginAsync(LoginDto dto);
    }
}
