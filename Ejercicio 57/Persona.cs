using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Ejercicio_57
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona ( string nombre, string apellido) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona()
        {

        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }


        public static bool Guardar( string archivo, Persona datos)
        {
            XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                serializer.Serialize(writer, datos);
                return true;
            }
            catch (Excepciones e )
            {
                throw new Excepciones();
            }
            finally
            {
                writer.Close();
            }
        }
        /*
        public static void Guardar(Persona p)
        {
            XmlTextWriter writer = new XmlTextWriter(".\\ejercicio57.xml", Encoding.UTF8);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                serializer.Serialize(writer, p);
                
            }
            catch( Exception)
            {
                throw new Exception();
            }
        }*/

        /*  static Persona Leer(string archivo)
          {
              return Persona ;
          }*/
        public static Persona Leer(string archivo, out Persona datos)
        {
            XmlTextReader reader = new XmlTextReader(archivo);
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Persona));

                datos = (Persona)ser.Deserialize(reader);
                
                return datos;
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                reader.Close();
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n\n");
            sb.AppendLine(this.Apellido);
            sb.AppendLine(this.Nombre);
            return sb.ToString();
        }
    }
}
