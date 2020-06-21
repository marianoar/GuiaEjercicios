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
             
               // sb.AppendLine("ProductId: "+sqlDataReader[0].ToString()+" - Nombre: "+sqlDataReader[1].ToString()+" - Product number: "+ sqlDataReader[2].ToString());
                listBox.Items.Add("ProductId: " + sqlDataReader[0].ToString() + " - Nombre: " + sqlDataReader[1].ToString() + " - Product number: " + sqlDataReader[2].ToString());
            }
          //  MessageBox.Show(sb.ToString());
            //listBox.Items.Add(sb);
            listBox.Refresh();
            
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

            cn.Open();
            command = new SqlCommand();
            command.Connection = cn;
         //   command.CommandText = "insert into Production.Product ( Name, ProductNumber, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, DaysToManufacture, SellStartDate) values('"+txtName.Text+"', '"+txtNumber.Text+"', 3,1,0,0,0,0)";
            
            command.CommandText = "insert into Production.Product ( Name, ProductNumber, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, DaysToManufacture, SellStartDate) values(@nombre, @productnumber, 3,1,0,0,0,0)";
            command.Parameters.Add(new SqlParameter("nombre", txtName.Text));
            command.Parameters.Add(new SqlParameter("productnumber", txtNumber.Text));

            SqlDataReader sqlDataReader = command.ExecuteReader();
          
            // command.CommandText += txtName.Text;
            // command.CommandText += txtNumber.Text;
            //command.CommandText = "select productid, name, productnumber from Production.Product where name=" + txtName.Text;

            //  MessageBox.Show(sb.ToString());
            //listBox.Items.Add(sb);
            listBox.Refresh();
       
            /*
           
            while (sqlDataReader.Read())
            {

                sb.AppendLine("ProductId: " + sqlDataReader[0].ToString() + " - Nombre: " + sqlDataReader[1].ToString() + " - Product number: " + sqlDataReader[2].ToString());

            }
            MessageBox.Show(sb.ToString());
            listBox.Items.Add(sb);
            listBox.Refresh();
            */
            cn.Close();
        

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
          
            SqlDataReader sqlDataReader =(SqlDataReader)listBox.SelectedItem;

            MessageBox.Show(sqlDataReader[2].ToString());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cn.Open();
            command = new SqlCommand();
            command.Connection = cn;
            command.CommandText = "select productid, name, productnumber from Production.Product";
            //command.CommandText = "delete from into Production.Product ( Name, ProductNumber, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, DaysToManufacture, SellStartDate) values('" + txtName.Text + "', '" + txtNumber.Text + "', 3,1,0,0,0,0)";

        }
    }
}
