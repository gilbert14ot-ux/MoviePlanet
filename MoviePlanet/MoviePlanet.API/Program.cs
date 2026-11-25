using MoviePlanet.Application.Interfaces;
using MoviePlanet.Application.Repositories;
using MoviePlanet.Application.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IPeliculaRepository, PeliculaRepo>();
builder.Services.AddScoped<PeliculaService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
