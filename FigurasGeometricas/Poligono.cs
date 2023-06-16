using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Poligono : Forma
    {
        protected int numLados;

        public Poligono(int lados)
        {
            numLados = lados;
        }

    }
}
