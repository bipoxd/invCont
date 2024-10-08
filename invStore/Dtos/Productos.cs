using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invStore.Dtos
{
    public class Productos
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int precioProducto { get; set; }
        public string stock { get; set; }
        public string codigo { get; set; }
    }
}
