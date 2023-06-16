using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Diagrama
    {
        private List<Forma> formas = new List<Forma>();

        public Diagrama()
        {
                Console.WriteLine("Ingresa (0) si quieres que sea un diagrama a mano"
                    + "\nIngresa (1) si quieres que se cree de forma Random"
                + "\nIngresa (2) si quieres ingresar los datos de cada figura");
                int i = int.Parse(Console.ReadLine());
                int opcion=3;

                if (i == 0)
                {
                    opcion = 4;
                    i++;
                }
                else if (i == 1)
                {
                Random random = new Random();
                int valorAleatorio = random.Next(1,1000);
                AgregarCirculo(valorAleatorio);
                }
            else if (i == 2)
                {
                    Console.WriteLine("Que figura quieres agregar" +
                    "\nCirculo ingresa(0) \nRectangulo ingresa(1) \nRombo ingresa(2) \nIngresa 3 para salir,");
                    opcion = int.Parse(Console.ReadLine());
                }

            bool a = false;
            while (!a) {
                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Ingresa el radio del circulo");
                            int radio = int.Parse(Console.ReadLine());
                            AgregarCirculo(radio);
                            break;
                        case 1:
                            Console.WriteLine("Ingresa el lado 1 del rombo");
                            int lado1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el lado 2 del rombo");
                            int lado2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa la diagonal 1 del rombo");
                            int diagonal1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa la diagonal 2 del rombo");
                            int diagonal2 = int.Parse(Console.ReadLine());
                            AgregarRombo(lado1, lado2, diagonal1, diagonal2);
                            break;
                        case 2:
                            Console.WriteLine("Ingresa el lado 1 del rombo");
                            int ladoR1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el lado 2 del rombo");
                            int ladoR2 = int.Parse(Console.ReadLine());
                            AgregarRectangulo(ladoR1, ladoR2);
                            break;
                        case 3:
                            a = true;
                            break;
                        case 4:
                            Console.WriteLine("Crearemos un circulo de 15 a mano");
                            AgregarCirculo(15);
                            Console.ReadKey();
                            a = true;
                            break;
                        default:
                            break;
                        
                    }
            }
        }

        public void AgregarCirculo(int r)
        { 
            Circulo circulo = new Circulo(r);
            formas.Add(circulo);
            Console.WriteLine("Hemos agregado el Circulo \n");
        }

        public void AgregarRombo(int l1, int l2,int d1, int d2)
        {
            Rombo rombo = new Rombo(l1, l2, d1, d2);
            formas.Add(rombo);
            Console.WriteLine("Hemos agregado el Rombo \n");
        }

        void AgregarRectangulo(int lr1, int lr2)
        {
            Rectangulo rectangulo = new Rectangulo(lr1, lr2);
            formas.Add(rectangulo);
            Console.WriteLine("Hemos agregado el Rectangulo \n");
        }

        public double AreaTotal()
        {
            double areaTotal = 0;

            for (int i = 0; i < formas.Count; i++)
            {
                areaTotal += formas[i].Area();
            }
            return areaTotal;
        }

        public double PerimetroTotal()
        {
            double perimetroTotal = 0;

            for (int i = 0; i < formas.Count; i++)
            {
                perimetroTotal += formas[i].Perimetro();
            }
            return perimetroTotal;
        }
    }
}
