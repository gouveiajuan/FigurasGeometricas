using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vamos a crear un diagrama");
            Diagrama diagrama = new Diagrama();

            Console.WriteLine("Ya hemos creado el diagrama");
            Console.WriteLine("Este es el area total");
            Console.WriteLine(diagrama.AreaTotal());
            Console.WriteLine("Este es el perimetro total");
            Console.WriteLine(diagrama.PerimetroTotal());
            Console.ReadKey();
            Console.WriteLine("\n HASTA LA PROXIMA \n");
            Console.ReadKey();


        }
    }
}
