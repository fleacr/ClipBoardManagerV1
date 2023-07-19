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
        string cadena = "Data Source=DESKTOP-JKTQPIP\\SQLEXPRESS;Initial Catalog=ClipBoardManager; Integrated Security=True";
        SqlDataAdapter adapter;
        DataTable dt;
        Methods manager = new Methods();
        public SqlConnection Conectarbd = new SqlConnection();
        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            UpdateProjectsComboBox(comboBox1);
            showData();
        }

        public void showData()
        {
            adapter = new SqlDataAdapter("select * from ProjectsClipBoardManager", cadena);
            dt = new DataTable();
            adapter.Fill(dt);

            // Asignar nombre a las columnas del grid
            dt.Columns[0].ColumnName = "Project Name";
            dt.Columns[1].ColumnName = "Template 1";
            dt.Columns[2].ColumnName = "Template 2";
            dt.Columns[3].ColumnName = "Template 3";
            dt.Columns[4].ColumnName = "Template 4";
            dt.Columns[5].ColumnName = "Template 5";

            dataGridView1.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox5.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadena = "Data Source=DESKTOP-JKTQPIP\\SQLEXPRESS;Initial Catalog=ClipBoardManager; Integrated Security=True";
            Conectarbd = new SqlConnection(cadena);

            string projectName = comboBox1.Text;
            string strQuery = "SELECT templateOne, templateTwo, templateThree, templateFour, templateFive FROM ProjectsClipBoardManager WHERE projectName = '" + projectName + "'";
            

            Conectarbd.Open();
            
            SqlCommand cmd = new SqlCommand(strQuery, Conectarbd);            
            SqlDataReader reader = cmd.ExecuteReader();              
            

            while (reader.Read())
            {
                if (reader["templateOne"].ToString() != string.Empty)
                {
                    textBox1.Text = reader.GetString(0);
                }

                if (reader["templateTwo"].ToString() != string.Empty) 
                {
                    textBox2.Text = reader.GetString(1);
                }

                if (reader["templateThree"].ToString() != string.Empty) 
                {
                    textBox3.Text = reader.GetString(2);
                }

                if (reader["templateFour"].ToString() != string.Empty) 
                {
                    textBox4.Text = reader.GetString(3);
                }

                if (reader["templateFive"].ToString() != string.Empty)
                {
                    textBox5.Text = reader.GetString(4);
                }
            }

            reader.Close();
            Conectarbd.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
        }
    }
}
