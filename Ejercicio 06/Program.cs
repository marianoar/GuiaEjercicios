using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /// EJERCICIO INCOMPLETO !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            /// 
            /*Escribir un programa que determine si un año es bisiesto.
             * Un año es bisiesto si es múltiplo de 4. 
             * Los años múltiplos de 100 no son bisiestos, 
             * salvo si ellos también son múltiplos de 400. 
             * Por ejemplo: el año 2000 es bisiesto pero 1900 no.
             * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.*/

            Console.Title = "Ejercicio 06";
            Console.WriteLine("Ejercicio 6 -- Calculo años bisiestos");
            #region Variables
            string input;
            bool isNumber;

            int anioInicio;
            int anioFin;
            int anio;
            int mult4, mult100, mult400;
            bool check4=false, check100=false, check400=false;
            bool esBisiesto;
            #endregion
            Console.Write("Ingrese un año inicial entero positivo: ");
            input = Console.ReadLine();
            isNumber = int.TryParse(input, out anioInicio);
            while ((!isNumber) || (anioInicio<1))
            {
                Console.Write("Error. Ingrese un año : ");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out anioInicio);
            }
            
                        Console.Write("Ingrese un año final entero positivo: ");
                        input = Console.ReadLine();
                        isNumber = int.TryParse(input, out anioFin);
                        while ((!isNumber) || (anioFin < 1))
                        {
                            Console.Write("Error. Ingrese un año : ");
                            input = Console.ReadLine();
                            isNumber = int.TryParse(input, out anioFin);
                        }


           for (int i = anioInicio; i <= anioFin; i++)
           {
          
                if ((i % 4 == 0 || i % 100 != 0) && (i % 400 == 0))
                {
                        Console.WriteLine("El año {0} es bisiesto:", i);
                        Console.ReadKey();
                    
                }
            }

            
            
        }
    }
}
