using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restauant_Managing
{
    public partial class LogingForm2 : Form
    {
        public LogingForm2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "mohamed" && textBox2.Text == "9494")
            {
                new Form1().Show();
            }
            else
            {
                MessageBox.Show("WAA QALAD PASSWORD AAD GALISE");
            }
        }
    }
}
