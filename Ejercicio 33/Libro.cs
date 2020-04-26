using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
	class Libro
	{

		private List<string> paginas;
		public Libro()
		{
			paginas = new List<string>();
			CargarPagina();
		}

		private void CargarPagina()
		{
			paginas.Add("pagina A");
			paginas.Add("pagina B");
			paginas.Add("pagina C");
		}
		
		public string this [int i]
		{
			get
			{
				if ((i > 0) && (i <paginas.Count))
				{
					return this.paginas[i-1]; // desacoplo numero pagina de numero indice
				}
				return string.Empty;
			}
			set
			{
				if ((i>=0)&&(i < paginas.Count))
				{
					paginas[i] = value;

				}else if (i>=paginas.Count) {
					paginas.Add(value);
				}
			}
			
		}


	}
}
