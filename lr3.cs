using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0,5";
            textBox2.Text = "2";
            textBox3.Text = "1";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            textBox4.Text += "При x = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При y = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При z = " + textBox3.Text + Environment.NewLine;
            double c;
            if (x > y)
                c = Math.Pow(x * x - y, 3) + Math.Atan(x * x);
            else
                if (y > x)
                c = Math.Pow(y - x * x, 3) + Math.Atan(x * x);
            else
                c = Math.Pow(y + x * x, 3) + 0.5;
            textBox4.Text += "c = " + c.ToString() + Environment.NewLine;
        }

   
    }
}
