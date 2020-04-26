using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int dia, mes, anio;
            string input;
            bool isNumber;
            #region input fecha nacimiento
            Console.WriteLine("ingrese una dia de nacimiento: ");
            input = Console.ReadLine();
            isNumber = int.TryParse(input, out dia);
            while ((!isNumber) || (dia < 1) || (dia>31))
            {
                Console.Write("Error. Ingrese un dia  valido: ");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out dia);
            }

            Console.WriteLine("ingrese un mes de nacimiento: ");
            input = Console.ReadLine();
            isNumber = int.TryParse(input, out mes);
            while ((!isNumber) || (mes < 1) || (mes > 12))
            {
                Console.Write("Error. Ingrese un mes valido : ");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out mes);
            }

            Console.WriteLine("ingrese una año de nacimiento: ");
            input = Console.ReadLine();
            isNumber = int.TryParse(input, out anio);
            while ((!isNumber) || (anio < 1000) || (anio>9999))
            {
                Console.Write("Error. Ingrese un año (mayor a 1000): ");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out anio);
            }
            #endregion

            DateTime fecha = DateTime.Now;
            DateTime fechaNac = new DateTime(anio,mes,dia);

            Console.WriteLine("Hoy es {0} / {1} / {2}", fecha.Day, fecha.Month, fecha.Year);
            Console.WriteLine("Su fecha de nacimiento fue {0} / {1} / {2}", fechaNac.Day, fechaNac.Month, fechaNac.Year);


            TimeSpan diferencia = fecha.Subtract(fechaNac);

            Console.WriteLine("Han pasado {0} días", diferencia.Days);
            int aux = ((int)diferencia.Days)/365;
            Console.WriteLine("usted tiene {0} años", aux);

            // Console.WriteLine("ingrese una fecha: dd/mm/aa");
            //auxilio=Console.ReadLine();

            //  string aux;

            //aux=fecha.ToString("dd/MM/yy");
            //Convert.ToString(fecha);
            //
            // Console.WriteLine("fecha en Date time: {0}", aux);
            // Console.WriteLine("fecha ingresadoa: {0}", fechaNac);

            // Console.WriteLine("fecha en string aux: {0}", aux);
            /*
            
            DateTime fecha;
            fecha=DateTime.Now;
            
            */
            Console.ReadKey();
        }
    }
}
