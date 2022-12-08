using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Rechner
{
    public partial class Form1 : Form
    {
        private Class1 MyRechner;
        private string Operation;
        private string Zahl1, Zahl2;

        public Form1()
        {
            InitializeComponent();
            MyRechner = new Class1();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (Operation == null)
            {
                Zahl1 += "1";
            }
            else
            {
                Zahl2 += "1";
            }

            refresh();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (Operation == null)
            {
                Zahl1 += "2";
            }
            else
            {
                Zahl2 += "2";
            }

            refresh();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (Operation == null)
            {
                Zahl1 += "3";
            }
            else
            {
                Zahl2 += "3";
            }

            refresh();
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (Operation == null)
            {
                Zahl1 += "4";
            }
            else
            {
                Zahl2 += "4";
            }

            refresh();

        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (Operation == null)
            {
                Zahl1 += "5";
            }
            else
            {
                Zahl2 += "5";
            }

            refresh();
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (Operation == null)
            {
                Zahl1 += "6";
            }
            else
            {
                Zahl2 += "6";
            }

            refresh();
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (Operation == null)
            {
                Zahl1 += "7";
            }
            else
            {
                Zahl2 += "7";
            }

            refresh();
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (Operation == null)
            {
                Zahl1 += "8";
            }
            else
            {
                Zahl2 += "8";
            }

            refresh();
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (Operation == null)
            {
                Zahl1 += "9";
            }
            else
            {
                Zahl2 += "9";
            }

            refresh();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (Operation == null)
            {
                Zahl1 += "0";
            }
            else
            {
                Zahl2 += "0";
            }

            refresh();
        }

        private void button_com_Click(object sender, EventArgs e)
        {
            if (Operation == null)
            {
                Zahl1 += ",";
            }
            else
            {
                Zahl2 += ",";
            }

            refresh();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            Operation = "+";
            textBox1.Text += "+";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            Operation = "-";
            textBox1.Text += "-";
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            Operation = "*";
            textBox1.Text += "*";
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            Operation = "/";
            textBox1.Text += "/";
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            MyRechner.Zahl1 = Convert.ToDouble(Zahl1);
            MyRechner.Zahl2 = Convert.ToDouble(Zahl2);

            if (Operation == "+")
            {
                textBox1.Text = MyRechner.Addieren().ToString();
            }

            if (Operation == "-")
            {
                textBox1.Text = MyRechner.Subtrahieren().ToString();
            }

            if (Operation == "*")
            {
                textBox1.Text = MyRechner.Multiplizieren().ToString();
            }

            if (Operation == "/")
            {
                textBox1.Text = MyRechner.Dividieren().ToString();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Zahl1 = null;
            Zahl2 = null;
            Operation = null;
            textBox1.Text = null;
        }

        void refresh()
        {
            textBox1.Text = Zahl1 + Operation + Zahl2;
        }
    }
}