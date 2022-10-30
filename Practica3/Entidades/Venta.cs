using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Entidades
{
    internal class Venta
    {
        public string tienda { get; set; }
        public int numeroOrden { get; set; }
        public DateTime fecha { get; set; }
        public int cantidad { get; set; }
        public string titulo { get; set; }
    }
}
