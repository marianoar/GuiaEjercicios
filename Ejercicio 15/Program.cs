using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            double valor1, valor2, resultado;
            string aux;
            char continua;
            char operacion;
            do
            {
                Console.WriteLine("Ingrese el primer valor: ");
                ingreso = Console.ReadLine();

                while (!Calculadora.ValidarEsNumero(ingreso))
                {
                    Console.WriteLine("Error. ingrese nuevamente: ");
                    ingreso = Console.ReadLine();
                }
                double.TryParse(ingreso, out valor1);

                Console.WriteLine("Ingrese el segundo valor: ");
                ingreso = Console.ReadLine();

                while (!Calculadora.ValidarEsNumero(ingreso))
                {
                    Console.WriteLine("Error. ingrese nuevamente: ");
                    ingreso = Console.ReadLine();
                }
                double.TryParse(ingreso, out valor2);

                Console.WriteLine("Ingrese su operacion: + - * /  ");
                ingreso = Console.ReadLine();
                operacion = Convert.ToChar(ingreso);

                resultado = Calculadora.Calcular(valor1, valor2, operacion);
                Console.WriteLine("El resultado de la operacion es :{0}", resultado);

                Console.WriteLine("Desea continuar sumando? S/N");
                aux = Console.ReadLine();
                continua = Convert.ToChar(aux);
            } while (Calculadora.ValidaS_N(continua));
        }
    }
}
