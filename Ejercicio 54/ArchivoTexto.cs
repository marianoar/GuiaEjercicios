using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_54
{
    public static class ArchivoTexto
    {
        public static bool Guardar (string ruta, string info)
        {
            StreamWriter writer = new StreamWriter(ruta);
            writer.Write(info);
            writer.Close();
            return true;
        }

        public static bool Leer(string ruta)
        {
            try
            {
                StreamReader reader = new StreamReader(ruta);
                string linea;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nLectura del archivo :");
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
            catch
            {
                throw new FileNotFoundException();             
            }
            return true;

        }

    }
}
