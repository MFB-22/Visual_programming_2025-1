﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_login
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string PW = textBox2.Text;

            if (ID.Equals("abcd") && PW.Equals("1234"))
            { 
                textBox3.Text ="login success";
            }
            else
            {
                textBox3.Text = "login fail";
            }
        }
    }
}
