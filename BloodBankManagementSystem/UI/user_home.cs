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
    public partial class user_home : Form
    {
        public user_home()
        {
            InitializeComponent();
        }

        private void updateUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_donor ad = new add_donor();
            ad.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_donor dd = new delete_donor();
            dd.ShowDialog();
        }

        private void allDonorDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            donor_data dd = new donor_data();
            dd.ShowDialog();
        }

        private void deleteUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delete_user du = new delete_user();
            du.ShowDialog();
        }

        private void usersDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            users_data ud = new users_data();
            ud.ShowDialog();
        }
    }
}
