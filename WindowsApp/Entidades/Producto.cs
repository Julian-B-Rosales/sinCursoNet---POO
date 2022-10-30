using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    internal class Producto
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precioCosto {get; set; }
        public double margen { get; set; } 
        public double iva { get; set; }   
        public decimal precioBruto {
            get
            {
                decimal precioBruto = precioCosto + (decimal)margen;
                return precioBruto;
            }
        }
        public decimal precioVenta { 
            get
            {
                Decimal precioVenta = precioBruto + Convert.ToDecimal(1+iva);
                return precioVenta;
            }
        }
        public string proveedor {get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }

    }

}
