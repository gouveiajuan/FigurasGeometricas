using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Circulo : Forma
    {
        private int radio { get; set; }

        public Circulo(int r)
        {

            radio = r;
        }

        public override double Area()
        {
            return Math.PI * radio * radio;
        }

        public override double Perimetro() 
        {
            return 2*Math.PI * radio;
        }

    }
}
