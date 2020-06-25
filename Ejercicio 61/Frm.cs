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

// faltarian validaciones solamente en los txtbox o en las funciones de los botones(ej eliminar una persona q no existe)
namespace Ejercicio_61
{
    public partial class Frm : Form
    {
        List<Persona> personas;
        Persona p;
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
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            PersonaDAO.EstablecerConection();
            personas = new List<Persona>();
            p = new Persona();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            Persona persona = new Persona(txtBoxApellido.Text, txtBoxNombre.Text);
            PersonaDAO.Guardar(persona);
            LimpiarTextBox();
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

        private void ltbPersonas_DoubleClick(object sender, EventArgs e)
        {
           
            
            p= PersonaDAO.LeerPorId(personas[ltbPersonas.SelectedIndex].Id);

            txtBoxApellido.Text = p.Apellido;
            txtBoxNombre.Text = p.Nombre;
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(txtBoxNombre.Text) && (!String.IsNullOrWhiteSpace(txtBoxApellido.Text))))
            {

                PersonaDAO.Modificar(p.Id, txtBoxApellido.Text, txtBoxNombre.Text) ;
                personas = PersonaDAO.Leer();
                RefreshListBox();
                LimpiarTextBox();

                p = new Persona();
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PersonaDAO.Borrar(p.Id);
            personas.Remove(personas[ltbPersonas.SelectedIndex]);
            RefreshListBox();
            LimpiarTextBox();
        }

        private void LimpiarTextBox()
        {
            txtBoxApellido.Clear();
            txtBoxNombre.Clear();
        }
    }
}
