using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WAF_One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            textBox1.ForeColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            textBox1.BackColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = fontDialog1.ShowDialog();

            if(res==DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }
        StreamReader sr;
        StreamWriter sw;
        FileStream fs;
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog();
            if(res==DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                try
                {
                    fs = new FileStream(filename, FileMode.Create);

                    sw = new StreamWriter(fs);

                    sw.Write(textBox1.Text);
                }
                catch(Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    sw.Flush();

                    sw.Close();

                    fs.Close();
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if(res==DialogResult.OK)
            {
                string filename2 = openFileDialog1.FileName;
                try
                {
                    fs = new FileStream(filename2, FileMode.Open);
                    sr = new StreamReader(fs);
                    textBox1.Text = sr.ReadToEnd();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {

                    fs.Close();

                    sw.Close();
                }
            }
        }
    }
}
