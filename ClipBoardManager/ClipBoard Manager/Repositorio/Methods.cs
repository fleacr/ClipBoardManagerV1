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
using ClipBoard_Manager.Models;

namespace ClipBoard_Manager
{
    internal class Methods
    {
        //Cadena  de Conexion
        string cadena = "Data Source=DESKTOP-JKTQPIP\\SQLEXPRESS;Initial Catalog=ClipBoardManager; Integrated Security=True";
        public SqlConnection Conectarbd = new SqlConnection();

        public Methods()
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
        public void InsertOne(ProjectsClipBoardManager projectsClipBoardManager)
        {


            Conectarbd.Open();

            string query = "INSERT INTO ProjectsClipBoardManager (projectName, templateOne) SELECT @projectName, @templateOne WHERE NOT EXISTS (SELECT 1 FROM ProjectsClipBoardManager WHERE projectName = @projectName)";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            cmd.Parameters.Add("@projectName", SqlDbType.VarChar);
            cmd.Parameters.Add("@templateOne", SqlDbType.Text);

            cmd.Parameters["@projectName"].Value = projectsClipBoardManager.projectName;
            cmd.Parameters["@templateOne"].Value = projectsClipBoardManager.templateOne;

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

        public void InsertTwo(ProjectsClipBoardManager projectsClipBoardManager)
        {
            Conectarbd.Open();
            string query = "INSERT INTO ProjectsClipBoardManager (projectName, templateOne, templateTwo) SELECT @projectName, @templateOne, @templateTwo WHERE NOT EXISTS (SELECT 1 FROM ProjectsClipBoardManager WHERE projectName = @projectName)";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            cmd.Parameters.Add("@projectName", SqlDbType.VarChar);
            cmd.Parameters.Add("@templateOne", SqlDbType.Text);
            cmd.Parameters.Add("@templateTwo", SqlDbType.Text);

            cmd.Parameters["@projectName"].Value = projectsClipBoardManager.projectName;
            cmd.Parameters["@templateOne"].Value = projectsClipBoardManager.templateOne;
            cmd.Parameters["@templateTwo"].Value = projectsClipBoardManager.templateTwo; 

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

        public void InsertThree(ProjectsClipBoardManager projectsClipBoardManager)
        {
            Conectarbd.Open();
            string query = "INSERT INTO ProjectsClipBoardManager (projectName, templateOne, templateTwo, templateThree) SELECT @projectName, @templateOne, @templateTwo, @templateThree WHERE NOT EXISTS (SELECT 1 FROM ProjectsClipBoardManager WHERE projectName = @projectName)";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            cmd.Parameters.Add("@projectName", SqlDbType.VarChar);
            cmd.Parameters.Add("@templateOne", SqlDbType.Text);
            cmd.Parameters.Add("@templateTwo", SqlDbType.Text);
            cmd.Parameters.Add("@templateThree", SqlDbType.Text);

            cmd.Parameters["@projectName"].Value = projectsClipBoardManager.projectName;
            cmd.Parameters["@templateOne"].Value = projectsClipBoardManager.templateOne;
            cmd.Parameters["@templateTwo"].Value = projectsClipBoardManager.templateTwo;
            cmd.Parameters["@templateThree"].Value = projectsClipBoardManager.templateThree;

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

        public void InsertFour(ProjectsClipBoardManager projectsClipBoardManager)
        {
            Conectarbd.Open();
            string query = "INSERT INTO ProjectsClipBoardManager (projectName, templateOne, templateTwo, templateThree, templateFour) SELECT @projectName, @templateOne, @templateTwo, @templateThree, @templateFour WHERE NOT EXISTS (SELECT 1 FROM ProjectsClipBoardManager WHERE projectName = @projectName)";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            cmd.Parameters.Add("@projectName", SqlDbType.VarChar);
            cmd.Parameters.Add("@templateOne", SqlDbType.Text);
            cmd.Parameters.Add("@templateTwo", SqlDbType.Text);
            cmd.Parameters.Add("@templateThree", SqlDbType.Text);
            cmd.Parameters.Add("@templateFour", SqlDbType.Text);

            cmd.Parameters["@projectName"].Value = projectsClipBoardManager.projectName; ;
            cmd.Parameters["@templateOne"].Value = projectsClipBoardManager.templateOne; ;
            cmd.Parameters["@templateTwo"].Value = projectsClipBoardManager.templateTwo; ;
            cmd.Parameters["@templateThree"].Value = projectsClipBoardManager.templateThree;
            cmd.Parameters["@templateFour"].Value = projectsClipBoardManager.templateFour;

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



        public void InsertFive(ProjectsClipBoardManager projectsClipBoardManager)
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

            cmd.Parameters["@projectName"].Value = projectsClipBoardManager.projectName;
            cmd.Parameters["@templateOne"].Value = projectsClipBoardManager.templateOne;
            cmd.Parameters["@templateTwo"].Value = projectsClipBoardManager.templateTwo;
            cmd.Parameters["@templateThree"].Value = projectsClipBoardManager.templateThree;
            cmd.Parameters["@templateFour"].Value = projectsClipBoardManager.templateFour;
            cmd.Parameters["@templateFive"].Value = projectsClipBoardManager.templateFive;

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


        public void UpdateProject(ProjectsClipBoardManager projectsClipBoardManager, string projectNameId)
        {

            try
            {
                if (ValidaProject(projectsClipBoardManager.projectName)) 
                {
                    Conectarbd.Open();

                    string query = "UPDATE ProjectsClipBoardManager SET projectName = '" + projectsClipBoardManager.projectName + "', templateOne = '" + projectsClipBoardManager.templateOne + "', templateTwo = '" + projectsClipBoardManager.templateTwo + "', templateThree = '" + projectsClipBoardManager.templateThree + "', templateFour = '" + projectsClipBoardManager.templateFour + "', templateFive = '" + projectsClipBoardManager.templateFive + "' WHERE projectName = '" + projectNameId + "'";
                    SqlCommand cmd = new SqlCommand(query, Conectarbd);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("El proyecto se ha actualizado exitosamente.");
                    Conectarbd.Close();
                }                              
            }
            catch (Exception)
            {

                throw;
            }            
        }

        private bool ValidaProject(string projectName) 
        {
            try
            {
                Conectarbd.Open();
                string query = "SELECT * FROM ProjectsClipBoardManager WHERE projectName = '" + projectName + "'";
                SqlCommand cmd = new SqlCommand(query, Conectarbd);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) 
                {
                    Conectarbd.Close();
                    return true;
                }
                Conectarbd.Close();
                MessageBox.Show("No existe ningún pryecto con ese nombre");
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}