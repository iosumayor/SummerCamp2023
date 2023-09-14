using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class PersonaDTO
    {
        [MaxLength(50)]
        public string Nombre { get; set; }

        public int Edad { get; set; }

        [MaxLength(25)]
        public string? Telefono { get; set; }
    }
}