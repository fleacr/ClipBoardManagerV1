using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClipBoard_Manager
{
    public partial class Form3 : Form
    {
        Class1 manager = new Class1();
        public SqlConnection Conectarbd = new SqlConnection();
        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            UpdateProjectsComboBox(comboBox1);
        }

        public void UpdateProjectsComboBox(System.Windows.Forms.ComboBox comboBox1)
        {
            string cadena = "Data Source=DESKTOP-JKTQPIP\\SQLEXPRESS;Initial Catalog=ClipBoardManager; Integrated Security=True";
            Conectarbd = new SqlConnection(cadena);
            comboBox1.Items.Clear(); // Limpiar los elementos existentes en el ComboBox

            Conectarbd.Open();

            string query = "SELECT projectName FROM ProjectsClipBoardManager";
            SqlCommand cmd = new SqlCommand(query, Conectarbd);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string projectName = reader.GetString(0);
                comboBox1.Items.Add(projectName);
            }

            reader.Close();
            Conectarbd.Close();
            //Second test with GitHub
        }
    }
}
