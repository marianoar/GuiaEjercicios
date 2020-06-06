using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 48";
            /*
            a.Crear un constructor que no reciba parámetros en Contabilidad para inicializar las listas.
            b.El constructor sin parámetros de Recibo asignará 0 como número de documento.
            c.Tanto el tipo genérico T como el U deberán ser del tipo Documento o uno de sus derivados.
                    
            g.Generar el código necesario para probar dichas clases*/

            Contabilidad <Factura, Recibo > contabilidad = new Contabilidad<Factura, Recibo >();
            Console.WriteLine(" Instancio clase Contabilidad con sus dos listas");

            Recibo recibo = new Recibo();
            Recibo recibo2 = new Recibo(1275);

            Console.WriteLine(" agrego recibos");

            Factura factura = new Factura(122);
            Factura factura2 = new Factura(500);

            Console.WriteLine(" agrego facturas");

            contabilidad += recibo;
            contabilidad += recibo2;
            contabilidad += factura;
            contabilidad += factura2;

            Console.WriteLine(" agrego tod a la lista contailidad");

            for (int i = 0; i < contabilidad.Egresos.Count; i++)
            {
                Console.WriteLine(contabilidad.Egresos[i].Numero.ToString());
            }
            for (int i = 0; i < contabilidad.Ingresos.Count; i++)
            {
                Console.WriteLine(contabilidad.Ingresos[i].Numero.ToString());
            }
            
           // Console.WriteLine(contabilidad.ToString());
            Console.ReadKey();

        }
    }
}
