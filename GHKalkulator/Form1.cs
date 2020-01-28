using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHKalkulator
{
    public partial class Form1 : Form
    {
        double[] mass = new double[2];
        string[] massZ = new string[1];

        int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonZap_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "+" && textBox1.Text != "-" && textBox1.Text != "/" && textBox1.Text != "*")
            {
                textBox1.Text += ",";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "+" && textBox1.Text != "-" && textBox1.Text != "/" && textBox1.Text != "*")
            {
                mass[n] = Convert.ToDouble(textBox1.Text);
                massZ[0] = "+";
                textBox1.Text = "+";
                if (n == 0)
                {
                    n = 1;
                }
                else { n = 0; }
            }
            else { }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "+" && textBox1.Text != "-" && textBox1.Text != "/" && textBox1.Text != "*")
            {
                mass[n] = Convert.ToDouble(textBox1.Text);
                massZ[0] = "-";
                textBox1.Text = "-";
                if (n == 0)
                {
                    n = 1;
                }
                else { n = 0; }
            }
            else { }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "+" && textBox1.Text != "-" && textBox1.Text != "/" && textBox1.Text != "*")
            {
                mass[n] = Convert.ToDouble(textBox1.Text);
                massZ[0] = "/";
                textBox1.Text = "/";
                if (n == 0)
                {
                    n = 1;
                }
                else { n = 0; }
            }
            else { }
        }

        private void buttonUmn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "+" && textBox1.Text != "-" && textBox1.Text != "/" && textBox1.Text != "*")
            {
                mass[n] = Convert.ToDouble(textBox1.Text);
                massZ[0] = "*";
                textBox1.Text = "*";
                if (n == 0)
                {
                    n = 1;
                }
                else { n = 0; }
            }
            else { }
        }

        private void buttonCel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void buttonVichislen_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                mass[n] = Convert.ToDouble(textBox1.Text.Substring(1, textBox1.Text.Length - 1));
                //MessageBox.Show(mass[0]+" "+massZ[0]+" "+mass[1]);

                if (massZ[0] == "+")
                {
                    double vichisl = mass[0] + mass[1];
                    textBox1.Text = "" + vichisl;
                }
                else if (massZ[0] == "-")
                {
                    double vichisl = mass[0] - mass[1];
                    textBox1.Text = "" + vichisl;
                }
                else if (massZ[0] == "*")
                {
                    double vichisl = mass[0] * mass[1];
                    textBox1.Text = "" + vichisl;
                }
                else if (massZ[0] == "/")
                {
                    double vichisl = mass[0] / mass[1];
                    textBox1.Text = "" + vichisl;
                }
            }
        }
    }
}