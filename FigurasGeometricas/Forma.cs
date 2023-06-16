using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Forma
    {
        private string nombre { get; set; }
        public virtual double Area() { return 0; }

        public virtual double Perimetro () { return 0; } 
    }
}
