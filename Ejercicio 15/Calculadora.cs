using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static bool ValidarEsNumero(string input)
        {
            bool esNumber;
            int numero;
            esNumber = int.TryParse(input, out numero);
            return esNumber;
        }

        public static bool ValidaS_N(char c)
        {
            if ((c == 'S') || (c == 's'))
            {
                return true;
            }
            else
                return false;
        }
        public static double Calcular(double valor1, double valor2, char operacion)
        {
            double resultado=0;
            switch (operacion)
            {
                case '+':
                    resultado = valor1 + valor2 ;
                    break;
                case '-':
                    resultado = valor1 - valor2;
                    break;
                case '*':
                    resultado = valor1 * valor2;
                    break;
                case '/':
                    if (Validar(valor2))
                    {
                        resultado = valor1 / valor2;
                    }else
                    {
                        Console.WriteLine("No se puede dividir por 0");
                    }
                    break;
                default:
                    
                    break;
            }
            return resultado;
        }

        private static bool Validar(double valor2)
        {
            if (valor2 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
