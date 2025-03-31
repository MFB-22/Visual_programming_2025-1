using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_RadioButton
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            if (radioButton1.Checked)
                s += "국적 : 대한민국\n";
            if (radioButton2.Checked)
                s += "국적 : 중국\n";
            if (radioButton3.Checked)
                s += "국적 : 일본\n";
            if (radioButton4.Checked)
                s += "국적 : 그 외 국가\n";

            if (radioButton5.Checked)
                s += "성별 : 남성";
            if (radioButton6.Checked)
                s += "성별 : 여성";

            MessageBox.Show(s, "결과");
        }
    }
}
