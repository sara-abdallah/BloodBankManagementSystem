using BloodBankManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int move = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            panel2.Width += 5;
            
            if (move== 715)
            {
                timer1.Stop();
                this.Hide();
                login l = new login();
                l.ShowDialog();
            }
            else
            {
                move += 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
