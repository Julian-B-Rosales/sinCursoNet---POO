using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto {get; set; }
        public double Margen { get; set; } 
        public double Iva { get; set; }   
        public decimal PrecioBruto {
            get
            {
                decimal precioBruto = PrecioCosto + (decimal) Margen;
                return precioBruto;
            }
        }
        public decimal precioVenta { 
            get
            {
                Decimal precioVenta = PrecioBruto + Convert.ToDecimal(1+Iva);
                return precioVenta;
            }
        }
        public string proveedor {get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }

    }

}
