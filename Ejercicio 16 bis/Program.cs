using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16_bis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16 bis";

            byte cantidad = 3;
          
            Alumno[] alumnos = new Alumno[cantidad];

          //  Alumno alumnos = new Alumno();
          
            Alumno alumno1 = new Alumno();
            alumno1.nombre = "Emilio";
            alumno1.apellido = "Puerta";
            alumno1.legajo = 997;
            Alumno alumno2 = new Alumno();
            alumno2.nombre = "Maria";
            alumno2.apellido = "Ventana";
            alumno2.legajo = 134;
            Alumno alumno3 = new Alumno();
            alumno3.nombre = "Jorge";
            alumno3.apellido = "Garcia";
            alumno3.legajo = 255;

            string ingreso;
            byte nota1;
            byte nota2;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Ingrese primer nota para el alumno {0}: ", i);
                ingreso = Console.ReadLine();

                while (!Alumno.ValidarEsNumero(ingreso))
                {
                    Console.WriteLine("Error. Ingrese nuevamente segunda nota para el alumno {0}:", i);
                    ingreso = Console.ReadLine();
                }
                byte.TryParse(ingreso, out nota1);

                Console.WriteLine("Ingrese segunda nota para el alumno {0}: ", i);
                ingreso = Console.ReadLine();

                while (!Alumno.ValidarEsNumero(ingreso))
                {
                    Console.WriteLine("Error. Ingrese nuevamente segunda nota para el alumno {0}:", i);
                    ingreso = Console.ReadLine();
                }
                byte.TryParse(ingreso, out nota2);
                if (i == 1)
                {
                    alumno1.Estudiar(nota1, nota2);
                    alumno1.CalcularFinal();
                }
                if (i == 2)
                {
                    alumno2.Estudiar(nota1, nota2);
                }
                if (i == 3)
                {
                    alumno3.Estudiar(nota1, nota2);
                }
            }

            Console.WriteLine("{0}", alumno1.Mostrar());
            Console.WriteLine("{0}", alumno2.Mostrar());
            Console.WriteLine("{0}", alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
