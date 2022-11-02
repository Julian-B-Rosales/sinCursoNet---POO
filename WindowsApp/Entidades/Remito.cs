using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Remito:DocumentoComercial
    {
        public string Numero { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}
