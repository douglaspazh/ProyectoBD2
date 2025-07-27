using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBD2.Models
{
    [Table("Productor", Schema = "dbo")]
    [PrimaryKey("ProductorID")]
    public class Productor
    {
        public int? ProductorID { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(50)]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        [StringLength(8)]
        public required string Telefono { get; set; }

        [StringLength(50)]
        public string? Correo { get; set; }

        [ForeignKey("Estado")]
        public int? EstadoID { get; set; }
        public Estado? Estado { get; set; }

        public DateOnly FechaRegistro { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        //public ICollection<Finca>? Fincas { get; set; }
    }
}
