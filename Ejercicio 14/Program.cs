using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*14.Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase(estáticos) que realicen el cálculo del área que corresponda:
            a. double CalcularCuadrado(double)
            b. double CalcularTriangulo(double, double)
            c. double CalcularCirculo(double)*/

            string opcion;
            double lado;
            double baseT;
            double altura;
            string ingreso;
            
            double area;
            bool flag=false;

            do
            {

                Console.WriteLine("Elija una opcion para calcular:\n a.- Cuadrado\n b.- Triangulo\n c.- Circulo");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "a":
                    case "A":
                        Console.WriteLine("----- Vamos a calcular el area de un cuadrado ------");

                        Console.WriteLine("Ingrese el valor del lado: ");
                        ingreso = Console.ReadLine();

                        while (!CalculoDeArea.ValidarEsNumero(ingreso))
                        {
                            Console.WriteLine("Error. ingrese nuevamente: ");
                            ingreso = Console.ReadLine();
                        }
                        double.TryParse(ingreso, out lado);
                        area = CalculoDeArea.CalcularCuadrado(lado);
                        Console.WriteLine("El area del cuadrado es: {0}", area);
                        flag = true;
                        break;
                    case "b":
                    case "B":
                        Console.WriteLine("------- Vamos a calcular el area de un triangulo ------");

                        Console.WriteLine("Ingrese el valor de base: ");
                        ingreso = Console.ReadLine();

                        while (!CalculoDeArea.ValidarEsNumero(ingreso))
                        {
                            Console.WriteLine("Error. ingrese nuevamente: ");
                            ingreso = Console.ReadLine();
                        }

                        Console.WriteLine("Ingrese el valor de la altura: ");
                        ingreso = Console.ReadLine();

                        while (!CalculoDeArea.ValidarEsNumero(ingreso))
                        {
                            Console.WriteLine("Error. ingrese nuevamente: ");
                            ingreso = Console.ReadLine();
                        }
                        double.TryParse(ingreso, out baseT);
                        double.TryParse(ingreso, out altura);
                        area = CalculoDeArea.CalcularTriangulo(baseT, altura);
                        Console.WriteLine("El area del triangulo es: {0}", area);
                        flag = true;
                        break;

                    case "c":
                    case "C":
                        Console.WriteLine("------ Vamos a calcular el area de un circulo -------" +
                            "");

                        Console.WriteLine("Ingrese el valor del radio: ");
                        ingreso = Console.ReadLine();

                        while (!CalculoDeArea.ValidarEsNumero(ingreso))
                        {
                            Console.WriteLine("Error. ingrese nuevamente: ");
                            ingreso = Console.ReadLine();
                        }
                        double.TryParse(ingreso, out lado);
                        area = CalculoDeArea.CalcularCirculo(lado);
                        Console.WriteLine("El area del circulo es: {0}", area);
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.ReadKey();
            } while (!flag);
        }
    }
}
