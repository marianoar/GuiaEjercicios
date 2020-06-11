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
        public Frm()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaArch = String.Empty;
           
            openFileDialog.InitialDirectory= @"C:\Users\compa\Desktop\UTN\00PyL\GuiaEjercicios";
            openFileDialog.ShowDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                rutaArch = openFileDialog.FileName;

                //Read the contents of the file into a stream
               // var fileStream = openFileDialog.OpenFile();
                
                using (StreamReader reader = new StreamReader(rutaArch))
                {
                    while(reader.ReadLine()!=null)
                    {
                        richTextBox.Text = reader.ReadLine();
                        richTextBox.AppendText ( reader.ReadLine());
                    }
                    //contenido = reader.ReadToEnd();
                }
            }
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
