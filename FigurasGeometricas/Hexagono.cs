using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Hexagono : Poligono
    {
        private int radio;

        public Hexagono(int radio) : base(6)
        {
            this.radio = radio;
        }

        public override double Area() { return radio; }

    }
}
