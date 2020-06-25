using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Ejercicio_61
{
    public static class PersonaDAO
    {
        /*Crear una clase llamada PersonaDAO y agregarle 5 métodos:
         i. Guardar: guardará una nueva persona en la base de datos.
         ii. Leer: retornará la lista de personas de la base de datos.
         iii. LeerPorID: traerá una persona, filtrando por ID.
         iv. Modificar: modificará una persona a partir de su ID.
         Borrar: eliminará una persona de la base de datos a partir de su ID*/

        //i. Guardar: guardará una nueva persona en la base de datos.
       
         static List<Persona> lista;

         static SqlConnection connection;
         static SqlCommand command;

        public static void EstablecerConection()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=DESKTOP-NT5B90I\SQLEXPRESS; Initial Catalog=Personas;Integrated Security=True";
            command = new SqlCommand();
        }
        public static void Guardar(Persona p)
        {
            try
            {
                if ((connection != null) && (connection.State == ConnectionState.Closed))
                {
                    command.Parameters.Clear();
                    connection.Open();
                    
                    command.Connection = connection;

                    command.Parameters.Add(new SqlParameter("nombre", p.Nombre));
                    command.Parameters.Add(new SqlParameter("apellido", p.Apellido));
                    command.CommandText = "insert into Persona (apellido,nombre) values(@apellido, @nombre)";

                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    connection.Close();
                }else if(connection is null)
                {
                    MessageBox.Show("conexion nula o qdo abierta");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" lanzo excepcion");
            }
        }


        //Leer: retornará la lista de personas de la base de datos.
        public static List<Persona> Leer()
        {
            lista = new List<Persona>();

            try
            {
                if ((connection != null) && (connection.State == ConnectionState.Closed))
                {
                    command.Parameters.Clear();
                    connection.Open();

                    command.Connection = connection;

                    command.CommandText = "select * from persona";

                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    
                    while (sqlDataReader.Read())
                    {
                        Persona persona = new Persona(int.Parse(sqlDataReader[0].ToString()), sqlDataReader[1].ToString(), sqlDataReader[2].ToString());
                        lista.Add(persona);
                    }

                    connection.Close();
                }
                else if (connection is null)
                {
                    MessageBox.Show("conexion nula o qdo abierta");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" lanzo excepcion");
            }

            return lista;
         

        }

        //iii.LeerPorID: traerá una persona, filtrando por ID.

        public static Persona LeerPorId(int id)
        {
            Persona persona;
            try
            {
                if ((connection != null) && (connection.State == ConnectionState.Closed))
                {
                    
                    command.Parameters.Clear();
                    connection.Open();

                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("id", id));

                    command.CommandText = "select * from persona where id=@id";

                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        persona = new Persona(int.Parse(sqlDataReader[0].ToString()), sqlDataReader[1].ToString(), sqlDataReader[2].ToString());
                        connection.Close();
                        return persona;
                    }

                    
                }
                else if (connection is null)
                {
                    MessageBox.Show("conexion nula o qdo abierta");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" lanzo excepcion Leer x id");
            }
            finally
            {
                connection.Close();
            }
            return new Persona();
            
        }

        //Modificar: modificará una persona a partir de su ID.

        public static void Modificar(int id, string nombre, string apellido)
        {
            try
            {
                if ((connection != null) && (connection.State == ConnectionState.Closed))
                {
                    command.Parameters.Clear();
                    connection.Open();

                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("nombre", nombre ));
                    command.Parameters.Add(new SqlParameter("apellido", apellido));
                    command.Parameters.Add(new SqlParameter("id", id));
                    command.CommandText = "Update Persona set nombre=@nombre, apellido=@apellido where id=@id";

                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    connection.Close();
                }
                else if (connection is null)
                {
                    MessageBox.Show("conexion nula o qdo abierta");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" lanzo excepcion Modificar");
            }
        }

       // Borrar: eliminará una persona de la base de datos a partir de su ID

        public static void Borrar(int id)
        {
            try
            {
                if ((connection != null) && (connection.State == ConnectionState.Closed))
                {
                    command.Parameters.Clear();
                    connection.Open();

                    command.Connection = connection;
                   
                    command.Parameters.Add(new SqlParameter("id", id));
                    command.CommandText = "delete from Persona where id=@id";

                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    connection.Close();
                }
                else if (connection is null)
                {
                    MessageBox.Show("conexion nula o qdo abierta");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" lanzo excepcion Modificar");
            }

        }

    }
}
