using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Entidades
{
    internal class Autor
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime nacimiento { get; set; }
        public string domicilio { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }

        public Autor(string nombre, string apellido, DateTime nacimiento, string ciudad, string pais)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.ciudad = ciudad;
            this.pais = pais;
        }

        public Autor()
        {
        }
    }
}
