using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_Dclock
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            lbldate.Font = new Font("맑은 고딕", 16, FontStyle.Bold);
            lbldate.ForeColor = Color.DarkOrange;
            lbltime.Font = new Font("맑은 고딕", 32, FontStyle.Bold);
            lbltime.ForeColor = Color.DarkBlue;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("yyyy년 mm월 dd일");
            lbltime.Text = DateTime.Now.ToString("tt h:mm:ss");

            lbldate.Location = new Point(ClientSize.Width / 2 - lbldate.Width / 2, ClientSize.Height / 2 - lbldate.Height / 2-30);
            lbltime.Location = new Point(ClientSize.Width / 2 - lbltime.Width / 2, ClientSize.Height / 2 - lbltime.Height / 2+20);
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
