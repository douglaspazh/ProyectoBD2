using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD2.Models
{
    public class Estado
    {
        public int EstadoID { get; set; }
        public required string Nombre { get; set; }
        public string? Observaciones { get; set; }
    }
}
