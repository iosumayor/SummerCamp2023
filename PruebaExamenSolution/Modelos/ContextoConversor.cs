using Microsoft.EntityFrameworkCore;
using Entidades;


namespace Modelos
{
    public class ContextoConversor: DbContext
    {

        public ContextoConversor(DbContextOptions<ContextoConversor> options) : base(options) 
        { 
        
        }

        public DbSet<Persona> Persona { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Persona>().HasData(
                new Persona()
                {

                    Id = 1,
                    Nombre = "Pedro",
                    FechaNacimiento = new DateTime(1998, 06, 21),
                    Telefono = "948230430"
                },

                new Persona()
                {
                    Id = 2,
                    Nombre = "Ana",
                    FechaNacimiento = new DateTime(1995, 03, 15),
                    Telefono = "123456789"
                },
                new Persona()
                {
                    Id = 3,
                    Nombre = "Luis",
                    FechaNacimiento = new DateTime(1990, 11, 30),
                    Telefono = "987654321"
                },
                new Persona()
                {
                    Id = 4,
                    Nombre = "María",
                    FechaNacimiento = new DateTime(1987, 08, 12),
                    Telefono = "555123789"
                },
                new Persona()
                {
                    Id = 5,
                    Nombre = "Juan",
                    FechaNacimiento = new DateTime(2005, 04, 05),
                    Telefono = "777888999"
                },
                new Persona()
                {
                    Id = 6,
                    Nombre = "Laura",
                    FechaNacimiento = new DateTime(2002, 09, 18),
                    Telefono = "333444555"
                },
                new Persona()
                {
                    Id = 7,
                    Nombre = "Carlos",
                    FechaNacimiento = new DateTime(1978, 12, 03),
                    Telefono = "999111222"
                },
                 new Persona()
                 {
                     Id = 8,
                     Nombre = "Marta",
                     FechaNacimiento = new DateTime(1983, 07, 27),
                     Telefono = "444555666"
                 },
                new Persona()
                {
                    Id = 9,
                    Nombre = "Andrés",
                    FechaNacimiento = new DateTime(2000, 01, 10),
                    Telefono = "888999000"
                },
                new Persona()
                {
                    Id = 10,
                    Nombre = "Isabel",
                    FechaNacimiento = new DateTime(1970, 05, 08),
                    Telefono = "222333444"
                }


                );
            
        }



    }
}