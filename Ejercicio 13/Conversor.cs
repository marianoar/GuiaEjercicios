using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {
        public static string DecimalBinario(int entero)
        {
            string binario = " ";
            while (entero > 0)
            {
                binario = (entero % 2).ToString() + binario;
                entero = entero / 2;
            }
            return binario;
        }

    public static int BinarioADecimal(string binario)
    {
        char[] numBinario = binario.ToCharArray();
        
        Array.Reverse(numBinario);
        int sum = 0;

        for (int i = 0; i < numBinario.Length; i++)
        {
            if (numBinario[i] == '1')
            {
                // Usamos la potencia de 2, según la posición
                sum += (int)Math.Pow(2, i);
            }
        }
        return sum;
        }
    }
}
