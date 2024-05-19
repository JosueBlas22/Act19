using System.ComponentModel.DataAnnotations;

namespace Directorio4E.Data
{
    public class Clasificacion
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }

        //Propiedad de navegación del EF
        virtual public ICollection<Persona>? Personas { get; set; }
    }
}
