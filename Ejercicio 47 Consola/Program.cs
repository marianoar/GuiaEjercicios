using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_47;

namespace Ejercicio_47
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo Basquet 2020");

            EquipoBasquet equipoBasquet1 = new EquipoBasquet("Moron", new DateTime(1979, 04, 28));

            EquipoBasquet equipoBasquet2 = new EquipoBasquet("Defensores UTN", new DateTime(1986, 12, 6));

            EquipoBasquet equipoBasquet3 = new EquipoBasquet("Midland", new DateTime(1998, 03, 03));

            EquipoBasquet equipoBasquet4 = new EquipoBasquet("Lafe", new DateTime(1998, 03, 03));

            if (torneoBasquet + equipoBasquet1){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Agrego al equipo  " + equipoBasquet1.Nombre + " al " + torneoBasquet.Nombre);
            }
            if (torneoBasquet + equipoBasquet2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Agrego al equipo  " + equipoBasquet2.Nombre + " al " + torneoBasquet.Nombre);
            }
            if (torneoBasquet + equipoBasquet2) // No deberia entrar pues ya existe
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Agrego al equipo  " + equipoBasquet2.Nombre + " al " + torneoBasquet.Nombre);
            }
            if (torneoBasquet + equipoBasquet3)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Agrego al equipo  " + equipoBasquet3.Nombre + " al " + torneoBasquet.Nombre);
            }
            if (torneoBasquet + equipoBasquet4)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Agrego al equipo  " + equipoBasquet4.Nombre + " al " + torneoBasquet.Nombre);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(torneoBasquet.Mostrar());

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadKey();
        }
    }
}
