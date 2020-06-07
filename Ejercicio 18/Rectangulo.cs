using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public int lado;
        public int h;

       /* Realizar los métodos getters para los atributos privados área y perímetro*/
        private float Area()
        {
            return h * lado;

        }
        private float Perimetro()
        {
            return h * 2 + lado * 2;

        }

        public float GetArea()
        {
            return this.Area();
        }
        public float GetPerimetro()
        {
            return this.Perimetro();
        }


        /*La base de todos los rectángulos de esta clase será siempre horizontal. Por lo tanto, debe
           tener un constructor para construir el rectángulo por medio de los vértices 1 y 3 (utilizar el
           método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para
           obtener la distancia entre puntos).*/

        public Rectangulo (Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice3 = vertice3;
            vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
            
            h = Math.Abs(vertice3.GetX() - vertice1.GetX());
            lado = Math.Abs(vertice4.GetY() - vertice2.GetY());

            Area();
            Perimetro();
        }

        public static string Mostrar(Rectangulo rectangulo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Area : " + rectangulo.GetArea());
            sb.Append(" y Perimetro : " + rectangulo.GetPerimetro());
            return sb.ToString();
        }
    }
}