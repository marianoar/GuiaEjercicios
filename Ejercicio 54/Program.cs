using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_42;
using System.IO;

namespace Ejercicio_54
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int a = 0;
            string ruta = @"C:\Users\compa\Desktop\UTN\00PyL\GuiaEjercicios\fecha.txt";
           
            try
            {
                OtraClase obj = new OtraClase();
            }
            catch (Exception e)
            {
              
               ArchivoTexto.Guardar(ruta, $"Tercera Exception {e}"); //  excepcion MiException
               //Console.WriteLine($"Tercera Exception - - - \n {e}");
            }
            finally
            {
                ArchivoTexto.Leer(ruta);
            }
            
            Console.ReadKey();
        }
    }
}
