using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBD2.Models
{
    [Table("Finca", Schema = "dbo")]
    [PrimaryKey("FincaID")]
    public class Finca
    {
        public int FincaID { get; set; }

        [Required(ErrorMessage = "El campo ProductorID es obligatorio.")]
        [ForeignKey("Productor")]
        public int ProductorID { get; set; }
        public Productor? Productor { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public required string Nombre { get; set; }

        public string? Direccion { get; set; }

        [Required(ErrorMessage = "El campo ExtensionTotal es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "La extensión total debe ser un número positivo.")]
        [Precision(10, 2)]
        public decimal ExtensionTotal { get; set; }

        public DateOnly FechaRegistro { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
