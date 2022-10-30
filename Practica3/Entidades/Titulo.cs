using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Entidades
{
    internal class Titulo
    {
        public string nombreAutor { get; set; }
        public string titulo { get; set; }
        public string categoria { get; set; }
        public double precio { get; set; }
        public string notas { get; set; }

        public Titulo(string nombreAutor, string titulo, string categoria, double precio, string notas)
        {
            this.nombreAutor = nombreAutor;
            this.titulo = titulo;
            this.categoria = categoria;
            this.precio = precio;
            this.notas = notas;
        }

        public Titulo()
        {
        }
    }
}
