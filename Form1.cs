using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCALC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(txtn1.Text);
            int B = Convert.ToInt32(txtn2.Text);
            int C = A + B;
            txtvlalor.Text = Convert.ToString(C);
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(txtn1.Text);
            int B = Convert.ToInt32(txtn2.Text);
            int C = A - B;
            txtvlalor.Text = Convert.ToString(C);
        }

        private void btnvezes_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(txtn1.Text);
            int B = Convert.ToInt32(txtn2.Text);
            int C = A * B;
            txtvlalor.Text = Convert.ToString(C);
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            decimal A = Convert.ToDecimal(txtn1.Text);
            decimal B = Convert.ToDecimal(txtn2.Text);
            decimal C = A / B;
            txtvlalor.Text = Convert.ToString(C);
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(txtn1.Text);
            int C = A;
            txtvlalor.Text = Convert.ToString(Math.Sqrt(A));
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtvlalor.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {     
                decimal um = Convert.ToInt32(1);
                txtn1.Text = txtn1.Text + um;
              
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            decimal dois = Convert.ToInt32(2);
            txtn1.Text = txtn1.Text + dois;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            decimal tres = Convert.ToInt32(3);
            txtn1.Text = txtn1.Text + tres;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            decimal quatro = Convert.ToInt32(4);
            txtn1.Text = txtn1.Text + quatro;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            decimal cinco = Convert.ToInt32(5);
            txtn1.Text = txtn1.Text + cinco;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            decimal seis = Convert.ToInt32(6);
            txtn1.Text = txtn1.Text + seis;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            decimal sete = Convert.ToInt32(7);
            txtn1.Text = txtn1.Text + sete;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            decimal oito = Convert.ToInt32(8);
            txtn1.Text = txtn1.Text + oito;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            decimal nove = Convert.ToInt32(9);
            txtn1.Text = txtn1.Text + nove;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            decimal zero = Convert.ToInt32(0);
            txtn1.Text = txtn1.Text + zero;
        }
    }
}
