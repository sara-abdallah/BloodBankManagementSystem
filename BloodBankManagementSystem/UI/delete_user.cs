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
    public partial class delete_user : Form
    {
        public delete_user()
        {
            InitializeComponent();
        }
        userBll u = new userBll();
        userDal dal = new userDal();
        private void button2_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(textBox1.Text);
            bool success = dal.Delete(u);
            if (success == true)
            {
                MessageBox.Show("User deleted Successfully");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Failed to delete User");
            }
        }

        private void delete_user_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
