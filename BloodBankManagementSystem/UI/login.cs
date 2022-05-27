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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        loginBll l = new loginBll();
        loginDal dal = new loginDal();
        private void button1_Click(object sender, EventArgs e)
        {
            l.username = textBox1.Text;
            l.password = textBox2.Text;
            bool isSuccess = dal.logincheck(l);
            if (isSuccess == true)
            {
                user_home uh = new user_home();
                uh.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            add_user au = new add_user();
            au.ShowDialog();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
