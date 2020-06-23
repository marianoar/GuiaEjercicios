using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ejercicio_61
{
    public partial class Frm : Form
    {
        // SqlConnection connection;
        // SqlCommand command;
        List<Persona> personas = new List<Persona>();
        public List<Persona> Personas
        {
            get
            {
                return personas;
            }
            set 
            { 
                personas = value;
            }
        }
        public Frm()
        {
            InitializeComponent();
            try
            {
              //  connection = new SqlConnection();
              //  connection.ConnectionString = @"Data Source=DESKTOP-NT5B90I\SQLEXPRESS; Initial Catalog=Personas;Integrated Security=True";
            }
            catch
            {

            }

        }

        private void Frm_Load(object sender, EventArgs e)
        {
            PersonaDAO.EstablecerConection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            Persona persona = new Persona(txtBoxApellido.Text, txtBoxNombre.Text);
            PersonaDAO.Guardar(persona);
            txtBoxApellido.Clear();
            txtBoxNombre.Clear();
            personas = PersonaDAO.Leer();
            RefreshListBox();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            personas=PersonaDAO.Leer();
            RefreshListBox();
        }
        public void RefreshListBox()
        {
            ltbPersonas.Items.Clear();
            for (int i = 0; i < personas.Count; i++)
            {
                ltbPersonas.Items.Add(personas[i].ToString());
            }
        }

        private void ltbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ltbPersonas_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
