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
        Class1 manager = new Class1();
        string cadena = "Data Source=DESKTOP-JKTQPIP\\SQLEXPRESS;Initial Catalog=ClipBoardManager; Integrated Security=True";
        SqlDataAdapter adapter;
        DataTable dt;
        string projectNameDelete = "";
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
            dataGridView1.DataSource = dt;
        }


        private void button2_Click(object sender, EventArgs e)
        {
   
            switch (cases)
            {
                case 0:
                    MessageBox.Show("No ha cargado ningún template aún, no se han guardado datos");
                    break;

                case 1:
                    Class1 manager = new Class1();
                    manager.InsertOne(textBox1.Text, textBox2.Text);
                    showData();
                    break; 

                case 2:
                    Class1 managerTwo = new Class1();
                    managerTwo.InsertTwo(textBox1.Text, textBox2.Text, textBox3.Text);
                    showData();
                    break;

                case 3:
                    Class1 managerThree = new Class1();
                    managerThree.InsertThree(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    showData();
                    break;

                case 4:
                    Class1 managerFour = new Class1();
                    managerFour.InsertFour(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    showData();
                    break;

                case 5:
                    Class1 managerFive = new Class1();
                    managerFive.InsertFive(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
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
    }
}
