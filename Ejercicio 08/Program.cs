using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Por teclado se ingresa el valor hora, el nombre, la antigüedad(en años) y la cantidad de horas trabajadas
             * en el mes de N empleados de una fábrica.
             * calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el valor hora 
             * por la cantidad de horas trabajadas), 
             * hay que sumarle la cantidad de años trabajados multiplicados por $ 150, 
             * y al total de todas esas operaciones restarle el 13 % en concepto de descuentos.
             * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto, 
             * el total de descuentos y el valor neto a cobrar*/

            Console.Title = "Ejercicio 08"; /// EJERCICIO INCOMPLETO

            string ingreso;
            int number;
            bool isNumber;

            string nombre;
            
            int valorHora;
            int antiguedad;
            int horasTrabajadas;
            int sueldoBruto;
            int sueldoNeto;
            int plusAntiguedad=150;
            int aportes;
            int descuentoAportes=13;

          //  string[] listado; 

            Console.WriteLine("Ingrese nombre empleado:");
            nombre= Console.ReadLine();
           
            Console.WriteLine("ingrese el Valor Hora: ");
            ingreso = Console.ReadLine();
            isNumber = int.TryParse(ingreso, out number);
            while ((!isNumber) || (number < 0))
            {
                Console.WriteLine("Error. ingrese nuevamente Valor hora: ");
                ingreso = Console.ReadLine();
                isNumber = int.TryParse(ingreso, out number);
            }
            valorHora = number;

            Console.WriteLine("ingrese años de antigüedad: ");
            ingreso = Console.ReadLine();
            isNumber = int.TryParse(ingreso, out number);
            while ((!isNumber) || (number < 0))
            {
                Console.WriteLine("Error. ingrese nuevamente antiguedad: ");
                ingreso = Console.ReadLine();
                isNumber = int.TryParse(ingreso, out number);
            }
            antiguedad = number;

            Console.WriteLine("ingrese las horas trabajadas en el mes: ");
            ingreso = Console.ReadLine();
            isNumber = int.TryParse(ingreso, out number);
            while ((!isNumber) || (number < 0))
            {
                Console.WriteLine("Error. Ingrese horas trabajadas: ");
                ingreso = Console.ReadLine();
                isNumber = int.TryParse(ingreso, out number);
            }
            horasTrabajadas = number;
            sueldoBruto = horasTrabajadas * valorHora + antiguedad * plusAntiguedad;
            aportes = sueldoBruto * descuentoAportes / 100;
            sueldoNeto = sueldoBruto - aportes;

            Console.WriteLine(" - - - - - - Recibo de Sueldo - - - - - - ");
            Console.WriteLine("Nombre empleado:{0}", nombre);
            Console.WriteLine("Antigüedad empleado:{0}", antiguedad);
            Console.WriteLine("Valor hora ingresado:{0}", valorHora);
            Console.WriteLine("Aportes empleado:{0}", aportes);

            Console.WriteLine("Su sueldo bruto es: {0}", sueldoBruto);
            Console.WriteLine("Su sueldo neto es: {0}", sueldoNeto);

            Console.ReadKey();

        }
    }
}
