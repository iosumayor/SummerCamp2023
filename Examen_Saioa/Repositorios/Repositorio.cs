using BaseDatos;
using Microsoft.EntityFrameworkCore;
using Helpers;
using Entidades_BBDD;
using Microsoft.AspNetCore.Mvc;

namespace Repositorios
{
    public class Repositorio :IRepositorio
    {
        private readonly ContextoAgenda db;

        public Repositorio(ContextoAgenda db)
        {
            this.db = db;
        }


        public async Task<IEnumerable<Persona>> GetPersonas()
        {
            var personas = await db.Persona.ToListAsync();
            return personas.Where(p => p.FechaNacimiento.GetCurrentAge() > 21).OrderBy(p => p.Nombre).Take(10).ToList();
        }

        public async Task RegistrarPersona(Persona persona)
        {

            db.Persona.Add(persona);
            await db.SaveChangesAsync();

        }

    }
}