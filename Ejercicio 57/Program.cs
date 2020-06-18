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
            Console.Title = "Ejercicio 57";

            Persona persona = new Persona("utn", "fra");
            string path = ".\\a.xml";

            try
            {
                Persona.Guardar(path, persona);
            }
            catch (Excepciones e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
