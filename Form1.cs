using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        string name;
        string description;
        int salary;
        string preview;
        string gender;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             name = textBox1.Text;
             description = textBox2.Text;
             salary = int.Parse(textBox3.Text);



            string gender;
            if (radioButton1.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            string preview;
            if (checkBox1.Checked)
            {
                preview = "good";
            }
            else
            {
                preview = "very good";
            }
            display();
            empty();




        }

        public void display()
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Description");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Preview");
            DataRow dr = dt.NewRow();
            dr[0] = name;
            dr[1] = description;
            dr[2] = salary;
            dr[3] = gender;
            dr[4] = preview;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;



        }
        public void empty()
        {
             textBox1.Text = " " ;
            textBox2.Text = " ";
             textBox3.Text = " ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
