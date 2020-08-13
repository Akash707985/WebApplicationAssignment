using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassCalcLib;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Operators cal;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cal = new Operators();
            cal.num1 = Convert.ToInt32(textBox1.Text);
            cal.num2 = Convert.ToInt32(textBox2.Text);
            label3.Text = "Addition of the two numbers:" + cal.Add().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cal = new Operators();
            cal.num1 = Convert.ToInt32(textBox1.Text);
            cal.num2 = Convert.ToInt32(textBox2.Text);
            label3.Text = "Subtraction of the two numbers:" + cal.Subtract().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cal = new Operators();
            cal.num1 = Convert.ToInt32(textBox1.Text);
            cal.num2 = Convert.ToInt32(textBox2.Text);
            label3.Text = "Multipication of the two numbers:" + cal.Multiply().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cal = new Operators();
            cal.num1 = Convert.ToInt32(textBox1.Text);
            cal.num2 = Convert.ToInt32(textBox2.Text);
            label3.Text = "Division of the two numbers:" + cal.Divide().ToString();
        }
    }
}
