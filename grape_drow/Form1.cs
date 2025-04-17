using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace grape_drow
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("그래프");
            chart1.ChartAreas[0].BackColor = Color.Black;
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].Color = Color.OrangeRed;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].LegendText = "랜덤 숫자";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Random r = new Random();
            for(int i=0; i<10; i++)
            {
                chart1.Series[0].Points.AddXY(i, r.Next(100));
            }
        }

    }
}
