using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);


            if (Addition.Checked)
            {
                int sum = num1 + num2;
                MessageBox.Show("The sum = " + sum.ToString());
            }
            else if (Subtraction.Checked)
            {
                int sub = num1 - num2;
                MessageBox.Show("The subtraction =  " + sub.ToString());
            }
            else if (Multiplication.Checked)
            {
                int mul = num1 * num2;
                MessageBox.Show("The multiplication =  " + mul.ToString());
            }
            else if (Division.Checked)
            {
                double div = (double)num1 / num2;
                MessageBox.Show("The division = " + div.ToString());
            }
            else
            {
                MessageBox.Show("Please select operator from the list.");
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
