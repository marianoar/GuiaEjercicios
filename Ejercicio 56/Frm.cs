using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_56
{
    public partial class Frm : Form
    {
  /* ojo falta hacer el punto d. Al hacer click sobre "Guardar", se deberá guardar el mismo archivo abierto (último guardado
  o abierto desde la interfaz). En el caso que no haya ningún "último archivo", se comportará  igual que el "Guardar Como…". Reutilizar código.*/
        string rutaArch = String.Empty;
        bool archivo=false;
        public Frm()
        {
            InitializeComponent();
        }
        private void Frm_Load(object sender, EventArgs e)
        {
            ContarCaracteres();
        }

        public string ContarCaracteres()
        {
            int a = richTextBox.Text.Length;
            toolStripStatusLabel.Text = a.ToString() + " caracteres.";
            return toolStripStatusLabel.Text;

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
            openFileDialog.InitialDirectory= @".\\";
          
           // openFileDialog.ShowDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                rutaArch = openFileDialog.FileName;

                //Read the contents of the file into a stream
               // var fileStream = openFileDialog.OpenFile();
                
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                         /* while (reader.ReadLine() != null)
                          {
                              richTextBox.Text = reader.ReadLine();
                              richTextBox.AppendText (reader.ReadLine());
                          }*/
                      richTextBox.Text = reader.ReadToEnd();
                    toolStripStatusLabel.Text=ContarCaracteres().ToString() + " caracteres.";
                    archivo = true;
                }
            }
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (archivo)
            {


            }
            else
            {



            }
            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @".\\";
            saveFileDialog1.FileName = string.Empty;
            saveFileDialog1.Filter = "Archivo de texto (*.txt)| *.txt";
            // string path = Directory.GetCurrentDirectory();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                    sw.Write(richTextBox.Text);

                    sw.Close();
                }
                catch (Exception)
                {

                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
