using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dbconnexample
{
    public partial class Form1 : Form
    {
        private string connstring = "Server=localhost;Database=mysql_dbname;User Id=mysql_username;Password=mysql_password";
        private db newdb3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db newdb1 = new db();
            dataGridView1.DataSource = newdb1.Load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            db newdb2 = new db();
            int age = Convert.ToInt32(ageBox.Text);
            int rowAffected = newdb2.insert(nameBox.Text, emailBox.Text, age);
            nameBox.Text = "";
            emailBox.Text = "";
            ageBox.Text = "";
            msgLable.Text = rowAffected.ToString() + "  Row Affected";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            newdb3 = new db();
            dataGridView1.DataSource = newdb3.Load();
            msgLable.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(idBox.Text != "")
            {
                int id = Convert.ToInt32(idBox.Text);
                db deletedb = new db();

                int rowAffected = deletedb.delete(id);
                msgLable.Text = rowAffected.ToString() + "  Row Affected/deleted";
            }
            else
            {
                msgLable.Text = "Please enter the Id!";
            }
            
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLable_Click(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageLable_Click(object sender, EventArgs e)
        {

        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(idBox.Text != "")
            {
                UpdateForm edit1 = new UpdateForm(Convert.ToInt32(idBox.Text));
                edit1.Show();
            }
            else
            {
                msgLable.Text = "please insert id number!";
            }
            //this.Hide();
            //this.Close();
        }
    }
}
