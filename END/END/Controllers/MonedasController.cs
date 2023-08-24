using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace END.Controllers
{


    public class Moneda
    {
        public string Nombre { get; set;}
    }
    //  1-Ruta
    //[Route("api/[controller]")]
    
    [Route("api/Monedas")]

    //  2-Controlador-Api
    [ApiController]
    public class MonedasController : ControllerBase //  3-Hereda de controlador API
    {
        //A -Verbo Http
        [HttpGet]

        // B -Devuelve ActionResult<tipo>
        public ActionResult<IEnumerable<Moneda>> ObtenerMonedas() {

            var lista = new List<Moneda>
            {
                new Moneda {Nombre = "Euro"}
            };

            //C -Devolver resultado y codigo estado
            return Ok(lista);
        }
    }
}
