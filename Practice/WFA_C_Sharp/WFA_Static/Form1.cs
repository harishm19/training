using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        class JointAccount
        {
            public static int Balance = 50000;

            public void withdrawal(int amt)
            {
                Balance -= amt;
                MessageBox.Show("the current balance is : " + Balance);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int amt = int.Parse(textBox1.Text);
            JointAccount jointAccount = new JointAccount();
            jointAccount.withdrawal(amt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amt = int.Parse(textBox1.Text);
            JointAccount jointAccount = new JointAccount();
            jointAccount.withdrawal(amt);
        }
    }
}
