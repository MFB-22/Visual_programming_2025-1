using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_greadcalc
{
    public partial class Form1: Form
    {
        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "인체의 구조와기능1";
            textBox2.Text = "일반수학1";
            textBox3.Text = "설계 및 프로잭트 기본";
            textBox4.Text = "비주얼 프로그레밍";
            textBox5.Text = "전기전자공학이론 및 실험";
            textBox6.Text = "기업가정신과 리더십";
            textBox7.Text = "영어1";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
