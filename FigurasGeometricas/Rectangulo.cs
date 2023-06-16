using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Rectangulo : Poligono
    {
        private int lado1, lado2;



        public Rectangulo(int l1, int l2) : base(4)
        {
            lado1 = l1;
            lado2 = l2;
        }

        public override double Area()
        {
            return lado1 * lado2;
        }

        public override double Perimetro() { return lado1 * 2 + lado2 * 2; }  


    }
}
