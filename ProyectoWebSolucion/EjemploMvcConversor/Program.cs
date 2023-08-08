using EjemploMvcConversor.Models;
using EjemploMvcConversor.Servicios;

namespace EjemploMvcConversor
{
    public class Program
    {
        // 1-Crear IRepositorio


        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //++ 1-Add services to the container.
            builder.Services.AddControllersWithViews();  // MVC

            builder.Services.AddScoped<IServicioMonedas, ServicioCriptoMonedas>();
            builder.Services.AddScoped<IRepositorioMonedas, RepositorioMonedasMemoria>();



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