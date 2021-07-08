using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauant_Managing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            redpanel.Height = button1.Height;
            redpanel.Top = button1.Top;
            dashboard1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            redpanel.Height = button7.Height;
            redpanel.Top = button7.Top;
            aboutMe1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            redpanel.Height = button1.Height;
            redpanel.Top = button1.Top;
            dashboard1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            redpanel.Height = button2.Height;
            redpanel.Top = button2.Top;
            dash21.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            redpanel.Height = button3.Height;
            redpanel.Top = button3.Top;
            drink1211.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            redpanel.Height = button4.Height;
            redpanel.Top = button4.Top;
            delivery1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            redpanel.Height = button6.Height;
            redpanel.Top = button6.Top;
            employee_info1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new LogingForm2().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void delivery1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
