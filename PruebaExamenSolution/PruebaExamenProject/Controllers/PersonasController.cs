using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entidades;

using AutoMapper;
using Repositorios;
using DTOs;

namespace PruebaExamenProject.Controllers
{

    [Route("api/personas")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        
        private readonly IMapper mapper;
        private IConfiguration configuration;
        private IRepositoriosBBDD repodb;

        public PersonasController(IMapper mapper,IConfiguration configuration,IRepositoriosBBDD repodb)
        {
            this.mapper = mapper;
            this.configuration = configuration;
            this.repodb = repodb;
        }

        [HttpGet]
        [HttpHead]

        public async Task<ActionResult<List<PersonaDTO>>> GetPersonas()
        {
            

            IEnumerable<Persona> personaFromRepo = await repodb.GetPersonasAsync();

            return Ok(mapper.Map<List<PersonaDTO>>(personaFromRepo));
        }

        [HttpGet("mayoresDe21")]
        public async Task<ActionResult<List<PersonaDTO>>> GetPersonasMayoresDe21()
        {
            var personasDTO = await repodb.GetPersonasMayoresDe21();

            // Devuelve solo los 3 primeros elementos de la lista
            return personasDTO;
        }





    }
}
