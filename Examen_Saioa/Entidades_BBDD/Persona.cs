using System.ComponentModel.DataAnnotations;

namespace Entidades_BBDD
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "El Nombre de usuario es obligatorio.")]

        public string Nombre { get; set; }


        [Required(ErrorMessage = "El la fecha de macimiento es obligatoria.")]

        public DateTime FechaNacimiento { get; set; }

        [MaxLength(25)]

        public string? Telefono { get; set; }

    }
}