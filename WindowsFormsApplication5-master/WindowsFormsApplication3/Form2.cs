﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2(string op1,string op2,string op3,string op4,string op5,string op6,string op7)
        {
            InitializeComponent();
            label1.Text = op1;
            label2.Text = op2;
            label3.Text = op3;
            label4.Text = op4;
            label5.Text = op5;
            label6.Text = op6;
            label7.Text = op7;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
