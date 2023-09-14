using AutoMapper;
using DTOs;
using Entidades_BBDD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositorios;

namespace Examen_Saioa.Controllers
{
    [Route("api/personas")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IRepositorio repodb;
        private readonly IMapper mapper;

        public PersonaController(IRepositorio repodb, IMapper mapper)
        {
            this.repodb = repodb;
            this.mapper = mapper ??
            throw new ArgumentNullException(nameof(mapper));
        }

            [HttpGet]
            public  async Task<ActionResult<List<PersonaDTO>>> GetPersonas()
            {
                IEnumerable<Persona> PersonasFromRepo = await repodb.GetPersonas();
                return Ok(mapper.Map<List<PersonaDTO>>(PersonasFromRepo));

            }
        



    }
}
