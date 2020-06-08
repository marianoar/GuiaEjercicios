using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtb.Text= "En la Asociación Astronomía propuesta se dictan cursos sobre esta ciencia y actividades afines. " +
                "Así, dictan cursos quienes están interesados en estos apasionantes temas, encuentran telescopios un espacio donde " +
                "les será posible, tanto adquirir conocimiento, como telescopios, como compartir sus inquietudes y vivencias."+
                " La propuesta es rica y diversa, telescopios cursos abarcando desde los conceptos mas básicos y elemental de la " +
                "Astronomía (Iniciación a la Astronomía) a temas más avanzados (Astrofísica, Cosmografía, El Sol y sus fenómenos, etc). " +
                "Asimismo, se dictan cursos de Manejo de Telescopios, Construcción de Telescopios, Fotografía Astronómica y " +
                "todo aquello que pueda resultarle útil o telescopios interesante al aficionado a la Astronomía compartir.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string[] txt = new string[0];
            
            txt=rtb.Text.Split(' ');

            for (int i = 0; i < txt.Length; i++)
            {
                txt[i] = txt[i].ToLower();
                txt[i] = txt[i].Trim(',');
                txt[i] = txt[i].Trim('.');
                txt[i] = txt[i].Trim('(');
                txt[i] = txt[i].Trim(')');
            }


            for (int i = 0; i < txt.Length; i++)
            {
               // try //
                if(!diccionario.ContainsKey(txt[i]))
                
                {
                    diccionario.Add(txt[i], 1); // si esta repetido tira exception
                }
                else
                {
                    diccionario[txt[i]]++;
                }
            }
            Dictionary<string, int> aux = new Dictionary<string, int>();

            diccionario = diccionario.OrderBy(word => word.Value).ToDictionary(a => a.Key, b => b.Value);
           
            diccionario=diccionario.Reverse().ToDictionary(a => a.Key, b => b.Value);
            int cont = 0;
            foreach (var item in diccionario)
            {
                MessageBox.Show(item.ToString());
                cont++;
                if (cont ==3)
                {
                    break;
                }
            }
            
    }
    }
}
