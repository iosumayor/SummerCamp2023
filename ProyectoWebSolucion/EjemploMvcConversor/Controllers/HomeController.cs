using EjemploMvcConversor.Models;
using EjemploMvcConversor.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploMvcConversor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioMonedas servicioMonedas;
        private readonly IMail mail;

        public HomeController(ILogger<HomeController> logger, IServicioMonedas servicioMonedas,IMail mail)
        {
            _logger = logger;
            this.servicioMonedas = servicioMonedas;
            this.mail = mail;
        }

        public IActionResult Index()
        {

            _logger.LogInformation("Estoy en el index");
            //var serviciomonedas = new ServicioMonedas();
            //var serviciomonedas = new ServicioCriptoMonedas();
            //IServicioMonedas serviciomonedas = new ServicioCriptoMonedas();
            var lista = this.servicioMonedas.ObtenerMonedas();

            return View();
        }

        public IActionResult Privacy()
        {

            //var serviciomonedas = new ServicioMonedas();
            //var serviciomonedas = new ServicioCriptoMonedas();
            //IServicioMonedas serviciomonedas = new ServicioCriptoMonedas();
            ViewBag.lista = this.servicioMonedas.ObtenerMonedas();
            
            ViewBag.correo = this.mail.EnvioMail("pepe", "luis");
            

            
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}