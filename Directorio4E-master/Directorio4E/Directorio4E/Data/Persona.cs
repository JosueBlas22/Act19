using System.ComponentModel.DataAnnotations;

namespace Directorio4E.Data
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "el nombre es obligatorio")]
        [StringLength(100)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [StringLength(100)]
        [EmailAddress]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [StringLength(10)]
        [Length(10, 10)]
        public string? Telefono { get; set; }

        //Propiedades de navegación EF
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar clasificación")]
        public int ClasificacionId { get; set; }
        virtual public Clasificacion? Clasificacion { get; set; }
    }
}
