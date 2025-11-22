using BackEmpleos.Api.Data;
using BackEmpleos.Api.Interfaces;
using BackEmpleos.Api.Services;
using BackEmpleos.Api.Utils;               // ⬅️ Seeder
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// ----------------------------
// 1. Controllers
// ----------------------------
builder.Services.AddControllers();

// ----------------------------
// 2. Base de datos MySQL
// ----------------------------
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 42)) // Versión real de tu MySQL
    )
);

// ----------------------------
// 3. Servicios
// ----------------------------
builder.Services.AddScoped<IAuthService, AuthService>();

// ----------------------------
// 4. Swagger
// ----------------------------
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "BackEmpleos API",
        Version = "v1"
    });
});

// ----------------------------
// 5. CORS para Vue
// ----------------------------
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:8080")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// ----------------------------
// 6. Ejecutar Seeders
// ----------------------------
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    await StateSeeder.SeedEstados(db);   // Estados de México
    await SkillSeeder.SeedSkills(db); // ⬅️ Lo activamos cuando tú quieras
}

// ----------------------------
// 7. Middleware
// ----------------------------
app.UseCors("AllowFrontend");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
