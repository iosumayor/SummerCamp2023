using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PersonaCrearDTO
    {

        [Required(ErrorMessage = "El Nombre de usuario es obligatorio.")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El la fecha de macimiento es obligatoria.")]
        public DateTime FechaNacimiento { get; set; }

        [MaxLength(25)]

        public string? Telefono { get; set; }
    }
}
