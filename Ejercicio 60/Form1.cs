using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Ejercicio_60
{
    public partial class Form1 : Form
    {
        SqlCommand command;
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();

            cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-NT5B90I\SQLEXPRESS; Initial Catalog=AdventureWorks;Integrated Security=True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private bool Conectar()
        {
           // StringBuilder sb = new StringBuilder();

            cn.Open();
            command = new SqlCommand();
            command.Connection = cn;
            command.CommandText = "select productid, name, productnumber from Production.Product";
           
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read()) {
                listBox.Items.Add("ProductId: " + sqlDataReader[0].ToString() + " - Nombre: " + sqlDataReader[1].ToString() + " - Product number: " + sqlDataReader[2].ToString());
            }
            cn.Close();
            return true;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (Conectar())
            {
               // MessageBox.Show("Concexion realizada");
            }
            else
            {
                MessageBox.Show("algo fallo");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            command.Parameters.Clear();
            cn.Open();
            command = new SqlCommand();
            command.Connection = cn;
         //   command.CommandText = "insert into Production.Product ( Name, ProductNumber, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, DaysToManufacture, SellStartDate) values('"+txtName.Text+"', '"+txtNumber.Text+"', 3,1,0,0,0,0)";

            command.CommandText = "insert into Production.Product ( Name, ProductNumber, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, DaysToManufacture, SellStartDate) values(@nombre, @productnumber, 3,1,0,0,0,0)";
            command.Parameters.Add(new SqlParameter("nombre", txtName.Text));
            command.Parameters.Add(new SqlParameter("productnumber", txtNumber.Text));

            SqlDataReader sqlDataReader = command.ExecuteReader();

            listBox.Refresh();
            cn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtid.Text, out int a) && (txtid.Text != string.Empty))
                {
                    cn.Open();
                    command = new SqlCommand();
                    command.Connection = cn;
                    command.Parameters.Add(new SqlParameter("id", txtid.Text));
                    command.CommandText = "update Production.Product set name='Mariano' where ProductID =@id";
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    cn.Close();
                }
            }
            catch(Exception )
            {
                MessageBox.Show("Cannot insert duplicate key row in object 'Production.Product' with unique index 'AK_Product_Name'");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                 if (int.TryParse(txtid.Text, out int a) && (txtid.Text != string.Empty)){
                    cn.Open();
                    command = new SqlCommand();
                    command.Connection = cn;
                    command.Parameters.Add(new SqlParameter("id", txtid.Text));
                    command.CommandText = "delete from Production.Product where ProductID =@id";
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    cn.Close();
                 }
            }
            catch
            {

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
          //  if (cn.State != ConnectionState.Open)
         //   {
                cn.Open();
         //   }
            command = new SqlCommand();
            command.Connection = cn;
            command.CommandText = "select productid, name, productnumber from Production.Product";

            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                listBox.Items.Add("ProductId: " + sqlDataReader[0].ToString() + " - Nombre: " + sqlDataReader[1].ToString() + " - Product number: " + sqlDataReader[2].ToString());
            }

            cn.Close();
        }
    }
}
