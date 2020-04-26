using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        public static bool ValidarEsNumero(string input)
        {
            bool esNumber;
            int numero;
            esNumber = int.TryParse(input, out numero);
            return esNumber;
        }
        public static double CalcularCuadrado(double lado)
        {
            double area = lado * lado;
            return area;
        }
        public static double CalcularTriangulo(double baseT, double altura)
        {
            double area = baseT * altura / 2;
            return area;
        }
        public static double CalcularCirculo(double radio)
        {
            double area;
            area = Math.PI * Math.Pow(radio,2);
            return area;

        }
    }
}
