using EjemploMvcConversor.Models;
using EjemploMvcConversor.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ApiJsonBiblioteca;
using AutoMapper;

namespace EjemploMvcConversor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioMonedas repositorioMonedas;
        private readonly IMapper mapper;

        public HomeController(ILogger<HomeController> logger, IRepositorioMonedas repositorioMonedas,
            IMapper mapper)
        {
            _logger = logger;
            this.repositorioMonedas = repositorioMonedas;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {

            var apiMonedas = new ApiMonedas();
            List<MonedaJson> listaMonedasApi = apiMonedas.ObtenerMonedas();


            foreach (MonedaJson monedaJson in listaMonedasApi)
            {
                //var moneda = new Moneda
                //{
                //    CodigoMoneda = monedaJson.CodigoMoneda
                //};

                // Moneda moneda = monedaJson;

                Moneda moneda = mapper.Map<Moneda>(monedaJson);

                repositorioMonedas.AgregarMoneda(moneda);
            }



            _logger.LogInformation("Estoy en el index");
            IEnumerable<Moneda> lista = repositorioMonedas.ObtenerMonedas();

            return View(lista);
        }

        public IActionResult Privacy()
        {

            
            

            
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}