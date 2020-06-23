using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_61
{
    public class Persona
    {
		private string apellido;
		private string nombre;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		private int id;

		public int Id
		{
			get { return  id; }
			set {  id = value; }
		}
		public Persona(int id, string apellido, string nombre):this (apellido, nombre)
		{
			this.id = id;

		}
		public Persona(string nombre, string apellido):this()
		{
			this.apellido = apellido;
			this.nombre = nombre;
		}
		public Persona()
		{

		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(Id.ToString());
			sb.Append(" - "+Apellido);
			sb.AppendLine(", " + Nombre);
			
			return sb.ToString();
		}



	}
}
