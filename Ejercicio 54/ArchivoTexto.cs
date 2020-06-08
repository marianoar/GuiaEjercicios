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
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Lectura del archivo :");
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
