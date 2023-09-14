using Entidades_BBDD;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public interface IRepositorio
    {

        Task<IEnumerable<Persona>> GetPersonas();
        public Task RegistrarPersona(Persona persona);
    }
}
