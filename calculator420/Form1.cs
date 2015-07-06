using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator420
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            double firstArgument, secondArgument;
            if (double.TryParse(A.Text, out firstArgument) &&
                double.TryParse(B.Text, out secondArgument))
            {
                Result.Text = Convert.ToString(firstArgument + secondArgument);
            }
            else
            {
                Result.Text = "Error";
            }
        }
    }
}
