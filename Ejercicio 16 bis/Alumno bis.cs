using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16_bis
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public void CalcularFinal()
        {
            /*El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o iguales a 4, 
             * caso contrario la inicializará con -1. 
             * Para darle un valor a la nota final utilice el método de instancia Next de la clase Random.*/

            if (nota1 >= 4 && nota2 >= 4)
            {
                notaFinal = 5;//new Random().Next(4,11);
            }
            else
            {
                notaFinal = -1;
            }

        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }

        public string Mostrar()
        {/*El método Mostrar, expondrá en la consola todos los datos de los alumnos. 
           La nota final se mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".*/

            string retorno;
            if (notaFinal != -1)
            {
                return retorno = "Nombre: " + nombre + "\nApellido:" + apellido + "\nLegajo:" + legajo + "\nNota Final:" + notaFinal;
            }
            else
            {
                return retorno = "Nombre: " + nombre + "\nApellido: " + apellido + "\nLegajo:" + legajo + "\nNota Final: Alumno Desparobado"; ;
            }



        }

        public static bool ValidarEsNumero(string input)
        {
            bool esNumber;
            int numero;
            esNumber = int.TryParse(input, out numero);
            if (numero < 0 || numero > 10)
            {
                esNumber = false;
            }
            return esNumber;
        }
    }
}
