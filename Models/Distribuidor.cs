using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T1_Lerggios_Luis.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre del distribuidor es obligatorio")]
        public string NombreDistribuidor { get; set; }

        [Required(ErrorMessage = "La Razon Social del distribuidor es obligatoria")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El Telefono del distribuidor es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El Año de operación es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El año de operación debe estar entre 1900 y 3000")]
        public int AnioInicioOperacion { get; set; }

        //[Required(ErrorMessage = "El contacto es obligatorio")]
        public string Contacto { get; set; }
    }
}