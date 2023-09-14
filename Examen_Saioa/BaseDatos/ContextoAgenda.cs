using Entidades_BBDD;
using Microsoft.EntityFrameworkCore;

namespace BaseDatos
{
    public class ContextoAgenda : DbContext

    {
        public ContextoAgenda(DbContextOptions<ContextoAgenda> opciones) : base(opciones)
        {


        }

        public DbSet<Persona> Persona { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Persona[] personas = new Persona[]
                {
                    new Persona { Id = 1, Nombre = "Juan", FechaNacimiento = new DateTime(1990, 3, 15), Telefono = "987654321" },
                    new Persona { Id = 2, Nombre = "Maria", FechaNacimiento = new DateTime(1985, 7, 8), Telefono = "123456789" },
                    new Persona { Id = 3, Nombre = "Pedro", FechaNacimiento = new DateTime(2000, 5, 20), Telefono = "555555555" },
                    new Persona { Id = 4, Nombre = "Luisa", FechaNacimiento = new DateTime(1982, 12, 10), Telefono = "777777777" },
                    new Persona { Id = 5, Nombre = "Carlos", FechaNacimiento = new DateTime(1995, 9, 3), Telefono = "999999999" },
                    new Persona { Id = 6, Nombre = "Ana", FechaNacimiento = new DateTime(1998, 6, 25), Telefono = "111111111" },
                    new Persona { Id = 7, Nombre = "Diego", FechaNacimiento = new DateTime(1993, 2, 18), Telefono = "222222222" },
                    new Persona { Id = 8, Nombre = "Laura", FechaNacimiento = new DateTime(1996, 11, 30), Telefono = "333333333" },
                    new Persona { Id = 9, Nombre = "Sergio", FechaNacimiento = new DateTime(1987, 4, 5), Telefono = "444444444" },
                    new Persona { Id = 10, Nombre = "Elena", FechaNacimiento = new DateTime(2002, 8, 12), Telefono = "666666666" },
                    new Persona { Id = 11, Nombre = "Ricardo", FechaNacimiento = new DateTime(1980, 1, 1), Telefono = "888888888" },
                    new Persona { Id = 12, Nombre = "Isabel", FechaNacimiento = new DateTime(1997, 10, 7), Telefono = "666666666" },
                    new Persona { Id = 13, Nombre = "Roberto", FechaNacimiento = new DateTime(1989, 5, 29), Telefono = "222222222" },
                    new Persona { Id = 14, Nombre = "Natalia", FechaNacimiento = new DateTime(2001, 4, 17), Telefono = "111111111" },
                    new Persona { Id = 15, Nombre = "Andres", FechaNacimiento = new DateTime(1983, 6, 9), Telefono = "444444444" },
                    new Persona { Id = 16, Nombre = "Carmen", FechaNacimiento = new DateTime(1994, 7, 22), Telefono = "555555555" },
                    new Persona { Id = 17, Nombre = "Gabriel", FechaNacimiento = new DateTime(1999, 9, 14), Telefono = "777777777" },
                    new Persona { Id = 18, Nombre = "Beatriz", FechaNacimiento = new DateTime(2003, 11, 5), Telefono = "123456789" },
                    new Persona { Id = 19, Nombre = "Alejandro", FechaNacimiento = new DateTime(1986, 2, 28), Telefono = "987654321" },
                    new Persona { Id = 20, Nombre = "Silvia", FechaNacimiento = new DateTime(1991, 12, 24), Telefono = "999999999" }
                };

            modelBuilder.Entity<Persona>().HasData(personas);

        }
    }
}