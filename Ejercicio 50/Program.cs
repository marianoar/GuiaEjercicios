using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a=false;

            GuardarTexto <bool, string> objetoGuardarTexto = new GuardarTexto<bool, string>();

            Serializar<bool, string> objetoSerializar = new Serializar<bool, string>();

            Console.WriteLine(objetoGuardarTexto.Guardar(a));
            Console.WriteLine(objetoGuardarTexto.Leer());

            Console.WriteLine(objetoSerializar.Guardar(a));
            Console.WriteLine(objetoSerializar.Leer());

            Console.ReadKey();
        }
    }
}
