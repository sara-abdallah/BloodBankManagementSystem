using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }
        userBll u = new userBll();
        userDal dal = new userDal();
        public void clear()
        {
            name.Text = "";
            email.Text = "";
            ssd.Text = "";
            phone.Text = "";
            address.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

            u.ssd = ssd.Text;
            u.name = name.Text;
            u.phone = phone.Text;
            u.email = email.Text;
            u.address = address.Text;
            u.password = textBox6.Text;
            u.username = textBox7.Text;
            u.added_date = DateTime.Now;
            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("Successfully Registered");
            }
            else
            {
                MessageBox.Show("Failed Registration");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void add_user_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
