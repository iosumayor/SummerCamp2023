using EjemploMvcConversor.Models;
using EjemploMvcConversor.Servicios;
using Microsoft.EntityFrameworkCore;

namespace EjemploMvcConversor
{
    public class Program
    {
        // 1-Crear IRepositorio    // 2-Crear Repositorio    // 3-Agregar AddScoped<IRepositorio,Repositorio>    // 4-Modificar constructor de HomeController para incluir IRepositorio    // 5-Crear campo repositorio en HomeController    // 6-Eliminar dependencia de proyecto lectura JSON Monedas    // 7-Modificar metodo ObtenerMonedas en Repositorio para llamar al metodo libreria JSON    // 8-En el metodo Index() llamar a repositorio.ObtenerMonedas, guardar en lista    // 9-Pasar lista a la vista en return View(lista)    // 10-Modificar vista @model IEnumerable<Moneda>    // 11-Mostrar lista de monedas en la vista con un @foreach


        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //++ 1-Add services to the container.
            builder.Services.AddControllersWithViews();  // MVC


            builder.Services.AddDbContext<ContextoConversor>(options =>
                        {
                            options.UseSqlServer(builder.Configuration["ConnectionStrings:ConexionDatos"]);
                        });


            builder.Services.AddScoped<IServicioMonedas, ServicioCriptoMonedas>();
            builder.Services.AddScoped<IRepositorioMonedas, RepositorioMonedasMemoria>();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



            var app = builder.Build();

            //++ 2-Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {

            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}