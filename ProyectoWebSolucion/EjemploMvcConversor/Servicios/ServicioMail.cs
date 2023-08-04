using EjemploMvcConversor.Models;

namespace EjemploMvcConversor.Servicios
{
    public class ServicioMail :IMail



    {

        public List<MailProduccion> MailDesarrollos { get; set; }

        public List<MailProduccion>EnvioMail(string envio, string destino)
        {
            List<MailProduccion> resultados = new List<MailProduccion>();

            // ... Agregar lógica de envío de correo ...

            return resultados;
        }
    }

        
  }

