using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_temperturecalc
{
    public partial class Form1: Form
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
            if (textBox2.Text == "" && textBox1.Text == "")
                return;
            if (textBox1.Text != "")
            {
                double f = double.Parse(textBox1.Text) * 9 / 5 + 32;
                textBox2.Text = f.ToString("#.##");
            }
            if (textBox2.Text != "")
            {
                double C = (double.Parse(textBox2.Text) - 32) * 5 / 9;
                textBox1.Text = C.ToString("#.##");
            }
        }
    }
}
