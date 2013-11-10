using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string op1, op2, op3, op4, op5, op6, op7;
         

            if (optMale.Checked == true)
            {
                op1=" ชาย" ;
            }
            else
            {
                op1=" หญิง" ;
            }
            
            if (opt1.Checked == true)
            {
                op2=" น้อยกว่า 20 ปี" ;
            }
            else if (opt2.Checked == true)
            {
               op2=" 20-40 ปี" ;
            }
            else 
            {
               op2 =" มากกว่า 40 ปี" ;
            }
            
            if (apt1.Checked == true)
            {
                op3 =" ต่ำกว่า 5 ปี" ;
            }
            else if (apt2.Checked == true)
            {
                op3=" 5-10 ปี";
            }
            else 
            {
                op3 =" มากกว่า 10 ปี" ;

            }
            
            if (bpt1.Checked == true)
            {
                op4=" พอสมควร" ;
            }
            else 
            {
                op4=" ไม่เคยเลยหรือน้อย" ;

            }
            
            if (cpt1.Checked == true)
            {
                op5 =" ทุกครั้ง";
            }
            else if (cpt2.Checked == true)
            {
                op5=" บางครั้ง" ;
            }
            else 
            {
                op5 =" ไม่เคยเลย" ;

            }
            
            if (dpt1.Checked == true)
            {
                op6=" เข้าศูนย์" ;
            }
            else if (dpt2.Checked == true)
            {
                op6 =" ด้วยตัวเอง" ;
            }
            else 
            {
                op6=" เข้าอู่" ;


            }
            
            if (fpt1.Checked == true)
            {
                op7=" มากที่สุด" ;
            }
            else if (fpt2.Checked == true)
            {
                op7=" พอสมควร" ;
            }
            else 
            {
                op7 =" ไม่เคย" ;


            }
            Form2 frm = new Form2(op1,op2,op3,op4,op5,op6,op7 );
            frm.Show();
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

