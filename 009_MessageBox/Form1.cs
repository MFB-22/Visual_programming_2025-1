using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_MessageBox
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("가장 간단한 메시지박스입니다.");
            MessageBox.Show("타이틀이 있는 메시지 박스", "타이틀");
            DialogResult r1 = MessageBox.Show("두개의 버튼을 갖는 메시지 박스", "타이틀",
                MessageBoxButtons.YesNo);
            DialogResult r2 = MessageBox.Show("세계의 버튼과 물음표 메세지 박스", "타이틀",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            DialogResult r3 = MessageBox.Show("세계의 버튼과 물음표 메세지 박스", "타이틀",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            MessageBox.Show("느낌표와 알람 메시지 박스", "느낌표와 알람소리",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            string msg = string.Format(" 당신의 선택은 {0} {1} {2}", r1.ToString(), r2.ToString(), r3.ToString());
            MessageBox.Show(msg);

        }
    }
}
