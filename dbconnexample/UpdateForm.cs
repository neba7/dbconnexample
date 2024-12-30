using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbconnexample
{
    public partial class UpdateForm : Form
    {
        string[] datas = null;
        int id;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            db newdb = new db();
            datas = newdb.select_one(id);
            nameBox.Text = datas[1];
            emailBox.Text = datas[2];
            ageBox.Text = datas[3];
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(nameBox.Text != "" && emailBox.Text != "" && ageBox.Text != "")
            {
                db newdb2 = new db();
                int age = Convert.ToInt32(ageBox.Text);
                int row = newdb2.Update(id,nameBox.Text,emailBox.Text,age);

                msgLable.Text = row.ToString() + " Rows Affected/Updated";

                //this.Close();
            }
            else
            {
                msgLable.Text = "Please Fill the fields!";
            }
        }
    }
}
