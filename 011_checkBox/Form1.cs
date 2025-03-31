using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_checkBox
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

            //IF (CHECKBOX1.CHECKED == TRUE)
            //    S += CHECKBOX1.TEXT + ", ";
            //IF (CHECKBOX2.CHECKED == TRUE)
            //    S += CHECKBOX2.TEXT + ", ";
            //IF (CHECKBOX3.CHECKED == TRUE)
            //    S += CHECKBOX3.TEXT + ", ";
            //IF (CHECKBOX4.CHECKED == TRUE)
            //    S += CHECKBOX4.TEXT + ", ";
            //IF (CHECKBOX5.CHECKED == TRUE)
            //    S += CHECKBOX5.TEXT;

            CheckBox[] cBox = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };

            // cBox 배열 안에 있는 각각의 item에 대해서
            foreach (var item in cBox)
            {
                if (item.Checked == true)
                    s += item.Text + " ";
            }

            MessageBox.Show(s);

            string t = "";
            
            foreach(var item in cBox)
            {
                t += string.Format("{0} : {1}\n", item.Text, item.Checked);
            }
            MessageBox.Show(t);
        }
    }
}
