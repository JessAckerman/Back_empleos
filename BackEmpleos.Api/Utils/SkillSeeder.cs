using BackEmpleos.Api.Data;
using BackEmpleos.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackEmpleos.Api.Utils
{
    public static class SkillSeeder
    {
        public static async Task SeedSkills(ApplicationDbContext context)
        {
            // Si ya hay skills, no inserta nada
            if (await context.Skills.AnyAsync())
                return;

            var skills = new List<Skill>
            {
                new() { Nombre = "C#", Categoria = "Lenguaje" },
                new() { Nombre = ".NET Core", Categoria = "Framework" },
                new() { Nombre = "JavaScript", Categoria = "Lenguaje" },
                new() { Nombre = "Vue.js", Categoria = "Framework Frontend" },
                new() { Nombre = "Node.js", Categoria = "Backend" },
                new() { Nombre = "SQL Server", Categoria = "Base de Datos" },
                new() { Nombre = "MySQL", Categoria = "Base de Datos" },
                new() { Nombre = "AWS", Categoria = "Cloud" },
                new() { Nombre = "Docker", Categoria = "DevOps" },
                new() { Nombre = "Git", Categoria = "Herramientas" }
            };

            await context.Skills.AddRangeAsync(skills);
            await context.SaveChangesAsync();
        }
    }
}
