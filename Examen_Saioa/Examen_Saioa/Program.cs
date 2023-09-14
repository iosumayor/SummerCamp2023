using AutoMapper;
using BaseDatos;
using Microsoft.EntityFrameworkCore;
using Perfiles;
using Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//Contexto
builder.Services.AddDbContext<ContextoAgenda>(options =>
          {
              options.UseSqlServer(builder.Configuration["ConnectionStrings:ConexionDatos"]);
          });


//Cors

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});

//Mapper
builder.Services.AddAutoMapper(typeof(PersonaPerfil) );

//Repositorio
builder.Services.AddScoped<IRepositorio, Repositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
