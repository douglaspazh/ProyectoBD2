using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBD2.Entities
{
    [Table("Productor", Schema = "dbo")]
    [PrimaryKey("ProductorID")]
    public class Productor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductorID { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(100)]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        public required string Telefono { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del Email es inválido.")]
        [StringLength(100, ErrorMessage = "El Email no puede exceder los 100 caracteres.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "El campo Estado es obligatorio.")]
        public required string Estado { get; set; }

        public DateOnly FechaRegistro { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
