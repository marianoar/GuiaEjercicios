using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 18";
            /* f. Probar las funcionalidades de las clases Punto y Rectangulo.
                i. Generar un nuevo Rectangulo.
                ii. Imprimir por pantalla los valores de área y perímetro.
                g. Desarrollar un método de clase que muestre todos los datos del rectángulo que recibe como
                parámetro.*/
            Rectangulo rectangulo1 = new Rectangulo(new Punto(0, 0), new Punto(8, 5));
            Console.WriteLine("Area {0} y perimetro: {1}",rectangulo1.GetArea(), rectangulo1.GetPerimetro());
            Console.WriteLine(Rectangulo.Mostrar(rectangulo1));

            Console.ReadKey();

        }
    }
}
