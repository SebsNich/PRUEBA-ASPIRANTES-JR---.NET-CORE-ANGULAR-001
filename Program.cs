using CINE.Api.Entities.Context;
using CINE.Api.Repository.Intefaces;
using CINE.Api.Repository;
using CINE.Api.Services.Interfaces;
using CINE.Api.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CineContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CineDB")));

builder.Services.AddScoped<IPeliculaRepository, PeliculaRepository>();
builder.Services.AddScoped<IPeliculaService, PeliculaService>();

builder.Services.AddScoped<ISalaCineRepository, SalaCineRepository>();
builder.Services.AddScoped<ISalaCineService, SalaCineService>();

builder.Services.AddScoped<IPeliculaSalaCineRepository, PeliculaSalaCineRepository>();
builder.Services.AddScoped<IPeliculaSalaCineService, PeliculaSalaCineService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Cine",
        Version = "v1",
        Description = "API REST para la gestión de películas y salas de cine."
    });
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Cine v1");
        c.RoutePrefix = "swagger";
    });
}

app.UseCors("AllowAngular");
app.UseAuthorization();
app.MapControllers();

app.Run();
