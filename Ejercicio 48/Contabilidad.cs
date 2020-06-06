using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Contabilidad<T, U> where T:Documento where U: Documento , new () //El tipo U deberá tener una restricción que indique que deberá tener un constructor por defecto
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        public List<T> Egresos
        {
            get { return egresos; }
            set { egresos = value; }
        }
        public List<U> Ingresos
        {
            get { return ingresos; }
            set { ingresos = value; }
        }
        //e.El operador + entre Contabilidad y T agregá un elemento a la lista egresos.
        // f.El operador +entre Contabilidad y U agregá un elemento a la lista ingresos.

        public static Contabilidad<T,U> operator +(Contabilidad<T, U> contabilidad, T egreso){

            contabilidad.Egresos.Add(egreso);
            return contabilidad;
            }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, U ingreso)
        {

            contabilidad.Ingresos.Add(ingreso);
            return contabilidad;
        }
   
    }
}
