using EjemploMvcConversor.Models;

namespace EjemploMvcConversor.Servicios
{
    public interface IMail
    {

        List<MailProduccion> EnvioMail(string origen,string destino);
    }
}
