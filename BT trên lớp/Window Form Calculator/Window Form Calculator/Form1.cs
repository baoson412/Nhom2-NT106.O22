using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Form_Calculator
{
    public partial class Form1 : Form
    {
        double value1;
        double value2;
        double result = 0;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            sign = "+";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            sign = "-";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            sign = "*";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            sign = "/";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            value2 = Convert.ToDouble(textBox1.Text);
            label2.Text = textBox1.Text;
            if (sign == "+")
            {
                result = value1 + value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "-")
            {
                result = value1 - value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "*")
            {
                result = value1 * value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "/")
            {
                result = value1 / value2;
                textBox1.Text = Convert.ToString(result);
            }
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
