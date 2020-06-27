using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
        Thread thread;
        DateTime time = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Ejercicio 63";
            lblHora.Text = time.ToString();
            thread = new Thread(new ParameterizedThreadStart(MostrarTiempo));
            thread.Start();
        }

        public void MostrarTiempo(object obj)
        {

            while (true)
            {
                if (lblHora.InvokeRequired)
                {
                    lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblHora.Text = DateTime.Now.ToString("dd/M/yyyy hh:MM:ss");
                    });
                }
                Thread.Sleep(1000);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }
    }
}
