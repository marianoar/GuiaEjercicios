using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 57"; // No hice el punto de excepciones

            Persona persona = new Persona("utn", "fra");
            Persona p2 = new Persona("algo", "arias");
            string path = ".\\a.xml";   //path bedeutet 'camino' auf English Sprache.

           /* PRUEBAS
            List<Persona> lista = new List<Persona>();
            lista.Add(persona);
            lista.Add(p2);
            */

            try
            {
               if(Persona.Guardar(path, p2))
                {
                    Console.Write(p2.ToString());
                    Console.Write("\nel archivo fue guardado.\n");
                }
                
                Persona p3;

                Console.Write("\nLectura del archivo:\n");

                Persona.Leer(path, out p3);

                Console.Write(p3.ToString());

            }
            catch (Excepciones e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
