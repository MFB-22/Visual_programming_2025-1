using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_bmiForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // btnBMI가 click 되었을떄 생기는 이벤트를 처리하는 함수
        private void btnBMI_Click(object sender, EventArgs e)
        {
            //double height = double.Parse(txtH.Text);
            //double weight = double.Parse(txtW.Text);
            //double bmi = weight / (height / 100 * height / 100);
            //lblBMI.Text = "BMI = " + bmi;

            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);
            h /= 100;
            double bmi = w / (h * h);
            lblBMI.Text = "BMI = " + bmi.ToString();

        }
    }
}
