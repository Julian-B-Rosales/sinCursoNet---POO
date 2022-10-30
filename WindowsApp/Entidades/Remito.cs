using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    internal class Remito
    {
        public string numero { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public string direccion { get; set; }
        public string condicionIVA { get; set; }
        public string condicionVenta { get; set; }
        public string detalle { get; set; }
        public DateTime fechaEntrega { get; set; }
        public decimal total { get; set; }
    }
}
