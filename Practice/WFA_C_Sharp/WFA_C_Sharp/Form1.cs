using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class InubeException : ApplicationException
        {
            public InubeException(string message): base(message)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                string Name = textBox1.Text;

                int age = int.Parse(textBox2.Text);

                if(age <18)
                {
                    throw new InubeException("you are below 18");
                }

                string Result = Name + age;

                textBox3.Text = Result;
            }
            catch(Exception ee)
            {
                MessageBox.Show("not in proper format");
            }
            finally
            {
                MessageBox.Show("hey am finally");
            }
        }
    }
}
