using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Rombo : Poligono
    {
        private int diagonal1;
        private int diagonal2;
        private int lado1;
        private int lado2;

        public Rombo(int l1, int l2, int d1, int d2 ) : base(4)
        {
            lado1 = l1;
            lado2 = l2;
            diagonal1 = d1;
            diagonal2 = d2;
        }

        public override double Area()
        {
            return diagonal1 * diagonal2 / 2;
        }

        public override double Perimetro()
        {
            return lado1 + lado2;
        }

    }
}
