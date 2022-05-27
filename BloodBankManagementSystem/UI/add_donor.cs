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
    public partial class add_donor : Form
    {
        public add_donor()
        {
            InitializeComponent();
        }
        donorBll u = new donorBll();
        stockBll su = new stockBll();
        stockDal sd = new stockDal();
        donorDal dal = new donorDal();
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.ssd = textBox3.Text;
            u.name = textBox1.Text;
            u.phone = textBox4.Text;
            u.email = textBox2.Text;
            u.address = textBox5.Text;
            u.gender = comboBox1.Text;
            u.blood_group = comboBox2.Text;
            u.added_date = DateTime.Now;
            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("New Donor added Successfully");
                su.BloodTypeName = comboBox2.Text;
                su.Quantity++;
                sd.Update(su);
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Add New Donor");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_donor_Load(object sender, EventArgs e)
        {

        }
    }
}
