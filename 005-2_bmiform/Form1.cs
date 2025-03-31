using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_bmiform
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = double.Parse(textBox1.Text);
            double weight = double.Parse(textBox2.Text);
            double bmi = weight / (height / 100 * height / 100);
            label3.Text = "BMi = " + bmi.ToString("0.00");
            //label3.Text = string.Format("당신의 BMI ={0:F1}",bmi);

            if (bmi < 20)
            {
                label4.Text = "저체중입니다.";
                pictureBox1.BackColor = Color.Blue;
            }
            else if (20 <= bmi && bmi < 25)
            {
                label4.Text = "정상체중입니다.";
                pictureBox1.BackColor = Color.Green;
            }
            else if (25 <= bmi && bmi < 30)
            {
                label4.Text = "경도비만입니다.";
                pictureBox1.BackColor = Color.Yellow;
            }
            else if (30 <= bmi && bmi < 40)
            {
                label4.Text = "비만입니다.";
                pictureBox1.BackColor = Color.Orange;
            }
            else if (bmi >= 40)
            {
                label4.Text = "고도비만입니다.";
                pictureBox1.BackColor = Color.Red;
            }
        }
    }
}
