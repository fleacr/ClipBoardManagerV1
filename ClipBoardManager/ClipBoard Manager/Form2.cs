using ClipBoard_Manager.Models;
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

namespace ClipBoard_Manager
{
    public partial class Form2 : Form
    {
        Methods manager = new Methods();
        string cadena = "Data Source=DESKTOP-JKTQPIP\\SQLEXPRESS;Initial Catalog=ClipBoardManager; Integrated Security=True";
        SqlDataAdapter adapter;
        DataTable dt;
        string projectNameDelete = "";
        string projectNameId = string.Empty;
        public Form2()
        {
            InitializeComponent();
        }
        public int cases = 0;
        public bool deleteText = true;


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


        private void button2_Click(object sender, EventArgs e)
        {
            ProjectsClipBoardManager projectsClipBoardManager = new ProjectsClipBoardManager();
            Methods manager = new Methods();

            switch (cases)
            {
                case 0:
                    MessageBox.Show("No ha cargado ningún template aún, no se han guardado datos");
                    break;

                case 1:
                                        
                    projectsClipBoardManager.projectName = textBox1.Text;
                    projectsClipBoardManager.templateOne = textBox2.Text;
                    manager.InsertOne(projectsClipBoardManager);
                    showData();
                    break; 

                case 2:                   
                    projectsClipBoardManager.projectName = textBox1.Text;
                    projectsClipBoardManager.templateOne = textBox2.Text;
                    projectsClipBoardManager.templateTwo = textBox3.Text;
                    manager.InsertTwo(projectsClipBoardManager);
                    showData();
                    break;

                case 3:
                    projectsClipBoardManager.projectName = textBox1.Text;
                    projectsClipBoardManager.templateOne = textBox2.Text;
                    projectsClipBoardManager.templateTwo = textBox3.Text;
                    projectsClipBoardManager.templateThree = textBox4.Text;
                    manager.InsertThree(projectsClipBoardManager);
                    showData();
                    break;

                case 4:
                    projectsClipBoardManager.projectName= textBox1.Text;   
                    projectsClipBoardManager.templateOne= textBox2.Text;
                    projectsClipBoardManager.templateTwo = textBox3.Text;
                    projectsClipBoardManager.templateThree = textBox4.Text;
                    projectsClipBoardManager.templateFour = textBox5.Text;
                    manager.InsertFour(projectsClipBoardManager);
                    showData();
                    break;

                case 5:
                    projectsClipBoardManager.projectName = textBox1.Text;
                    projectsClipBoardManager.projectName = textBox2.Text;
                    projectsClipBoardManager.projectName = textBox3.Text;
                    projectsClipBoardManager.projectName = textBox4.Text;
                    projectsClipBoardManager.projectName = textBox5.Text;
                    projectsClipBoardManager.projectName = textBox6.Text;
                    manager.InsertFive(projectsClipBoardManager);
                    showData();
                    break;

                default:
                    MessageBox.Show("Opción no soportada, no se han guardado datos");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            quantity = Convert.ToInt32(comboBox1.Text);

            switch (quantity)
            {
                case 0:
                    MessageBox.Show("No se ha generado ningún template");
                    break;
                case 1:
                    label2.Visible = true;
                    textBox2.Visible = true;
                    label3.Visible = false;
                    textBox3.Visible = false;
                    label4.Visible = false;
                    textBox4.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label6.Visible = false;
                    textBox6.Visible = false;
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    cases = 1;
                    break;
                case 2:
                    label2.Visible = true;
                    textBox2.Visible = true;
                    label3.Visible = true;
                    textBox3.Visible = true;
                    label4.Visible = false;
                    textBox4.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label6.Visible = false;
                    textBox6.Visible = false;
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    cases = 2;
                    break;
                case 3:
                    label2.Visible = true;
                    textBox2.Visible = true;
                    label3.Visible = true;
                    textBox3.Visible = true;
                    label4.Visible = true;
                    textBox4.Visible = true;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label6.Visible = false;
                    textBox6.Visible = false;
                    textBox5.Text = "";
                    textBox6.Text = "";
                    cases = 3;
                    break;
                case 4:
                    label2.Visible = true;
                    textBox2.Visible = true;
                    label3.Visible = true;
                    textBox3.Visible = true;
                    label4.Visible = true;
                    textBox4.Visible = true;
                    label5.Visible = true;
                    textBox5.Visible = true;
                    label6.Visible = false;
                    textBox6.Visible = false;
                    textBox6.Text = "";
                    cases = 4;
                    break;
                case 5:
                    label2.Visible = true;
                    textBox2.Visible = true;
                    label3.Visible = true;
                    textBox3.Visible = true;
                    label4.Visible = true;
                    textBox4.Visible = true;
                    label5.Visible = true;
                    textBox5.Visible = true;
                    label6.Visible = true;
                    textBox6.Visible = true;
                    cases = 4;
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string message = "¿Está seguro que desea eliminar todos los proyectos?";
            string title = "Ventana de confirmación";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {
                //The user clicks the "No" button and the box just close
            }
            else
            {
                manager.deleteAllData();
                showData();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (deleteText == true)
            {
                textBox1.Text = "";
                deleteText = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            projectNameDelete = textBox1.Text;
            if (textBox1.Text == "")
            {
                MessageBox.Show("El campo está vacío, escriba el nombre del proyecto que desea eliminar");
            }
            else
            {
                string message = "¿Está seguro que desea eliminar este proyecto?";
                string title = "Ventana de confirmación";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.No)
                {
                    //The user clicks the "No" button and the box just close
                }
                else
                {
                    manager.DeleteProject(projectNameDelete);
                    showData();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProjectsClipBoardManager projectsClipBoardManager = new ProjectsClipBoardManager();

            projectsClipBoardManager.projectName = textBox1.Text;
            projectsClipBoardManager.templateOne = textBox2.Text;
            projectsClipBoardManager.templateTwo = textBox3.Text;
            projectsClipBoardManager.templateThree = textBox4.Text;
            projectsClipBoardManager.templateFour = textBox5.Text;
            projectsClipBoardManager.templateFive = textBox6.Text;
            
            manager.UpdateProject(projectsClipBoardManager, projectNameId);
            showData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                projectNameId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
