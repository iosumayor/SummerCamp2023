using EjemploMvcConversor.Models;

namespace EjemploMvcConversor.Servicios
{
    public class ServiciosMonedas : IServicioMonedas
    {
        
        public List<Moneda> Monedas { get; set; }

        public List<Moneda> ObtenerMonedas()
        {
            return Monedas;
        }
    }
}
