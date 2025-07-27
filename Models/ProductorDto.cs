using Microsoft.EntityFrameworkCore;

namespace ProyectoBD2.Models
{
    [PrimaryKey("ProductorID")]
    public class ProductorDto
    {
        public int ProductorID { get; set; }
        public required string Nombre { get; set; }
        public required string Telefono { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
        public int EstadoID { get; set; }
        public DateOnly FechaRegistro { get; set; }
    }
}
