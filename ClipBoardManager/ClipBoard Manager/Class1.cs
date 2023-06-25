using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ClipBoard_Manager
{
    internal class Class1
    {
        //Cadena  de Conexion
        string cadena = "Data Source=DESKTOP-JKTQPIP\\SQLEXPRESS;Initial Catalog=ClipBoardManager; Integrated Security=True";
        public SqlConnection Conectarbd = new SqlConnection();
        public Class1()
        {
            Conectarbd.ConnectionString = cadena;
        } 

        //METHOD TO OPEN CONNECTION
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
                Console.WriteLine("Conexión exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
        }

        //METHOD TO CLOSE CONNECTION
        public void cerrar()
        {
            Conectarbd.Close();
        }


        //INSERT METHODS
        public void InsertOne(string projectName, string templateOne)
        {


            Conectarbd.Open();

            //string query = "INSERT INTO ProjectsClipBoardManager (projectName, templateOne) values (@projectName, @templateOne)";
            string query = "INSERT INTO ProjectsClipBoardManager (projectName, templateOne) SELECT @projectName, @templateOne WHERE NOT EXISTS (SELECT 1 FROM ProjectsClipBoardManager WHERE projectName = @projectName)";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            cmd.Parameters.Add("@projectName", SqlDbType.VarChar);
            cmd.Parameters.Add("@templateOne", SqlDbType.Text);

            cmd.Parameters["@projectName"].Value = projectName;
            cmd.Parameters["@templateOne"].Value = templateOne;

            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("El proyecto se ha guardado exitosamente.");
            }
            else
            {
                MessageBox.Show("Ya existe un proyecto con el mismo nombre. No se guardaron los datos.");
                Conectarbd.Close();
            }
        }

        public void InsertTwo(string projectName, string templateOne, string templateTwo)
        {
            Conectarbd.Open();
            string query = "INSERT INTO ProjectsClipBoardManager (projectName, templateOne, templateTwo) SELECT @projectName, @templateOne, @templateTwo WHERE NOT EXISTS (SELECT 1 FROM ProjectsClipBoardManager WHERE projectName = @projectName)";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            cmd.Parameters.Add("@projectName", SqlDbType.VarChar);
            cmd.Parameters.Add("@templateOne", SqlDbType.Text);
            cmd.Parameters.Add("@templateTwo", SqlDbType.Text);

            cmd.Parameters["@projectName"].Value = projectName;
            cmd.Parameters["@templateOne"].Value = templateOne;
            cmd.Parameters["@templateTwo"].Value = templateTwo;

            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("El proyecto se ha guardado exitosamente.");
            }
            else
            {
                MessageBox.Show("Ya existe un proyecto con el mismo nombre. No se guardaron los datos.");
                Conectarbd.Close();
            }
        }

        public void InsertThree(string projectName, string templateOne, string templateTwo, string templateThree)
        {
            Conectarbd.Open();
            string query = "INSERT INTO ProjectsClipBoardManager (projectName, templateOne, templateTwo, templateThree) SELECT @projectName, @templateOne, @templateTwo, @templateThree WHERE NOT EXISTS (SELECT 1 FROM ProjectsClipBoardManager WHERE projectName = @projectName)";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            cmd.Parameters.Add("@projectName", SqlDbType.VarChar);
            cmd.Parameters.Add("@templateOne", SqlDbType.Text);
            cmd.Parameters.Add("@templateTwo", SqlDbType.Text);
            cmd.Parameters.Add("@templateThree", SqlDbType.Text);

            cmd.Parameters["@projectName"].Value = projectName;
            cmd.Parameters["@templateOne"].Value = templateOne;
            cmd.Parameters["@templateTwo"].Value = templateTwo;
            cmd.Parameters["@templateThree"].Value = templateThree;

            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("El proyecto se ha guardado exitosamente.");
            }
            else
            {
                MessageBox.Show("Ya existe un proyecto con el mismo nombre. No se guardaron los datos.");
                Conectarbd.Close();
            }
        }

        public void InsertFour(string projectName, string templateOne, string templateTwo, string templateThree, string templateFour)
        {
            Conectarbd.Open();
            string query = "INSERT INTO ProjectsClipBoardManager (projectName, templateOne, templateTwo, templateThree, templateFour) SELECT @projectName, @templateOne, @templateTwo, @templateThree, @templateFour WHERE NOT EXISTS (SELECT 1 FROM ProjectsClipBoardManager WHERE projectName = @projectName)";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            cmd.Parameters.Add("@projectName", SqlDbType.VarChar);
            cmd.Parameters.Add("@templateOne", SqlDbType.Text);
            cmd.Parameters.Add("@templateTwo", SqlDbType.Text);
            cmd.Parameters.Add("@templateThree", SqlDbType.Text);
            cmd.Parameters.Add("@templateFour", SqlDbType.Text);

            cmd.Parameters["@projectName"].Value = projectName;
            cmd.Parameters["@templateOne"].Value = templateOne;
            cmd.Parameters["@templateTwo"].Value = templateTwo;
            cmd.Parameters["@templateThree"].Value = templateThree;
            cmd.Parameters["@templateFour"].Value = templateFour;

            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("El proyecto se ha guardado exitosamente.");
            }
            else
            {
                MessageBox.Show("Ya existe un proyecto con el mismo nombre. No se guardaron los datos.");
                Conectarbd.Close();
            }
        }



        public void InsertFive(string projectName, string templateOne, string templateTwo, string templateThree, string templateFour, string templateFive)
        {
            Conectarbd.Open();
            string query = "INSERT INTO ProjectsClipBoardManager (projectName, templateOne, templateTwo, templateThree, templateFour, templateFive) SELECT @projectName, @templateOne, @templateTwo, @templateThree, @templateFour, @templateFive WHERE NOT EXISTS (SELECT 1 FROM ProjectsClipBoardManager WHERE projectName = @projectName)";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            cmd.Parameters.Add("@projectName", SqlDbType.VarChar);
            cmd.Parameters.Add("@templateOne", SqlDbType.Text);
            cmd.Parameters.Add("@templateTwo", SqlDbType.Text);
            cmd.Parameters.Add("@templateThree", SqlDbType.Text);
            cmd.Parameters.Add("@templateFour", SqlDbType.Text);
            cmd.Parameters.Add("@templateFive", SqlDbType.Text);

            cmd.Parameters["@projectName"].Value = projectName;
            cmd.Parameters["@templateOne"].Value = templateOne;
            cmd.Parameters["@templateTwo"].Value = templateTwo;
            cmd.Parameters["@templateThree"].Value = templateThree;
            cmd.Parameters["@templateFour"].Value = templateFour;
            cmd.Parameters["@templateFive"].Value = templateFive;

            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("El proyecto se ha guardado exitosamente.");
            }
            else
            {
                MessageBox.Show("Ya existe un proyecto con el mismo nombre. No se guardaron los datos.");
                Conectarbd.Close();
            }
        }

        public void deleteAllData()
        {
            //Add user confirmation to delete
            {
                string query = "DELETE FROM ProjectsClipBoardManager";

                using (SqlCommand cmd = new SqlCommand(query, Conectarbd))
                {
                    try
                    {
                        Conectarbd.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Todos los proyectos se han eliminado");
                        Conectarbd.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message);    
                    }
                }
            }
        }

        public void DeleteProject(string projectNameDelete)
        {
            //Add user confirmation to delete


            Conectarbd.Open();
            string query = "DELETE FROM ProjectsClipBoardManager WHERE projectName = @projectName";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            cmd.Parameters.Add("@projectName", SqlDbType.VarChar);
            cmd.Parameters["@projectName"].Value = projectNameDelete;
            int rowsAffected = cmd.ExecuteNonQuery();
            Conectarbd.Close();


            if (rowsAffected > 0)
            {
                MessageBox.Show("El proyecto se ha eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("No se encontró ningun proyecto con el nombre especificado.");
                Conectarbd.Close();
            }
        }


        /*public void UpdateProjectsComboBox(ComboBox comboBox)
        {
            comboBox1.Items.Clear(); // Limpiar los elementos existentes en el ComboBox

            Conectarbd.Open();

            string query = "SELECT projectName FROM ProjectsClipBoardManager";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string projectName = reader.GetString(0);
                comboBox.Items.Add(projectName);
            }

            reader.Close();
            Conectarbd.Close();
        }*/
    }
}