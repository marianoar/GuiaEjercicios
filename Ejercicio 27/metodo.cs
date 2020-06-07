using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    public class metodo
    {
        public static void Sort(Stack<int> stack)
        {

            Stack<int> auxiliar = new Stack<int>();

            while (stack.Count > 0)
            {
                int aux = stack.Pop();

                while (auxiliar.Count > 0 && aux < auxiliar.Peek())
                {
                    stack.Push(auxiliar.Pop());
                }
                auxiliar.Push(aux);
            }
            while (auxiliar.Count > 0)
            stack.Push(auxiliar.Pop());
        }

        public static void SortCola(Queue<int> cola)
        {
            /// INCOMPLETO
            Queue<int> auxiliar = new Queue<int>();

            while (cola.Count > 0)
            {
                int aux = cola.Peek();

                while (auxiliar.Count > 0 && aux < cola.Peek())
                {
                    cola.Enqueue(auxiliar.Dequeue());
                }
               // auxiliar.Enqueue(aux);
            }
            while (auxiliar.Count > 0) { }
               // cola.Enqueue(auxiliar.Dequeue());
        }
    }
}
