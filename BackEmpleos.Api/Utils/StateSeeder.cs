using BackEmpleos.Api.Data;
using BackEmpleos.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackEmpleos.Api.Utils
{
    public static class StateSeeder
    {
        public static async Task SeedEstados(ApplicationDbContext context)
        {
            // Si ya existen estados, no hace nada
            if (await context.CatalogoEstadosMx.AnyAsync())
                return;

            var estados = new List<CatalogoEstadosMx>
            {
                new() { ClaveEstado = "AG", NombreEstado = "Aguascalientes" },
                new() { ClaveEstado = "BC", NombreEstado = "Baja California" },
                new() { ClaveEstado = "BS", NombreEstado = "Baja California Sur" },
                new() { ClaveEstado = "CM", NombreEstado = "Campeche" },
                new() { ClaveEstado = "CS", NombreEstado = "Chiapas" },
                new() { ClaveEstado = "CH", NombreEstado = "Chihuahua" },
                new() { ClaveEstado = "CO", NombreEstado = "Coahuila" },
                new() { ClaveEstado = "CL", NombreEstado = "Colima" },
                new() { ClaveEstado = "DG", NombreEstado = "Durango" },
                new() { ClaveEstado = "GT", NombreEstado = "Guanajuato" },
                new() { ClaveEstado = "GR", NombreEstado = "Guerrero" },
                new() { ClaveEstado = "HG", NombreEstado = "Hidalgo" },
                new() { ClaveEstado = "JC", NombreEstado = "Jalisco" },
                new() { ClaveEstado = "EM", NombreEstado = "México" },
                new() { ClaveEstado = "MI", NombreEstado = "Michoacán" },
                new() { ClaveEstado = "MO", NombreEstado = "Morelos" },
                new() { ClaveEstado = "NA", NombreEstado = "Nayarit" },
                new() { ClaveEstado = "NL", NombreEstado = "Nuevo León" },
                new() { ClaveEstado = "OA", NombreEstado = "Oaxaca" },
                new() { ClaveEstado = "PU", NombreEstado = "Puebla" },
                new() { ClaveEstado = "QT", NombreEstado = "Querétaro" },
                new() { ClaveEstado = "QR", NombreEstado = "Quintana Roo" },
                new() { ClaveEstado = "SL", NombreEstado = "San Luis Potosí" },
                new() { ClaveEstado = "SI", NombreEstado = "Sinaloa" },
                new() { ClaveEstado = "SO", NombreEstado = "Sonora" },
                new() { ClaveEstado = "TB", NombreEstado = "Tabasco" },
                new() { ClaveEstado = "TM", NombreEstado = "Tamaulipas" },
                new() { ClaveEstado = "TL", NombreEstado = "Tlaxcala" },
                new() { ClaveEstado = "VE", NombreEstado = "Veracruz" },
                new() { ClaveEstado = "YU", NombreEstado = "Yucatán" },
                new() { ClaveEstado = "ZA", NombreEstado = "Zacatecas" }
            };

            await context.CatalogoEstadosMx.AddRangeAsync(estados);
            await context.SaveChangesAsync();
        }
    }
}
