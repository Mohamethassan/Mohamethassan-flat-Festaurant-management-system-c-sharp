using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restauant_Managing
{
    public partial class delivery : UserControl
    {
        public delivery()
        {
            InitializeComponent();
            
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblname.Text = name1.Text;
            lbladdress.Text = address.Text;
            lblphone.Text = phone.Text;

            int num1, num2, num3, num4, num5, num6;
            int n111 = 0;
            if (checkBox1.Checked)
            {
                num1 = int.Parse(pizza.Text);
                n111 += num1;
            }
            int n112 = 0;
            if (checkBox2.Checked)
            {
                num2 = int.Parse(pasta.Text);
                n112 += num2;
            }
            int n113 = 0;
            if (checkBox3.Checked)
            {
                num3 = int.Parse(chicken.Text);
                n113 += num3;
            }

            int n114 = 0;
            if (checkBox4.Checked)
            {
                num4 = int.Parse(beans.Text);
                n114 += num4;

            }
            int n115 = 0;
            if (checkBox5.Checked)
            {
                num5 = int.Parse(rice.Text);
                n115 += num5;

            }
            int n116 = 0;
            if (checkBox6.Checked)
            {
                num6 = int.Parse(meat.Text);
                n116 += num6;

            }

            int sumfood =calculate(n111, n112, n113, n114, n115, n116);
            //////////////////////////////////////////////////////////////////////////
            int num11, num12, num13, num14, num15, num16;
            int n121 = 0;
            if (checkBox7.Checked)
            {
                num11 = int.Parse(apple.Text);
                n121 += num11;
            }
            int n122 = 0;
            if (checkBox8.Checked)
            {
                num12 = int.Parse(mango.Text);
                n122 += num12;
            }
            int n123 = 0;
            if (checkBox9.Checked)
            {
                num13 = int.Parse(lemon.Text);
                n123 += num13;
            }

            int n124 = 0;
            if (checkBox10.Checked)
            {
                num14 = int.Parse(green.Text);
                n124 += num14;

            }
            int n125 = 0;
            if (checkBox11.Checked)
            {
                num15 = int.Parse(carroto.Text);
                n125 += num15;

            }
            int n126 = 0;
            if (checkBox12.Checked)
            {
                num16 = int.Parse(watermelon.Text);
                n126 += num16;

            }
            int sumdrink = calculate2(n111, n112, n113, n114, n115, n116);
            //////////////////////////////////////////////////////////////////////////
            int all_sum = sumfood + sumdrink;
            totaldollar.Text = all_sum.ToString();
            int shiling = all_sum * 25;
            lblsh.Text = shiling.ToString();


        }
        private int calculate(int num1, int num2, int num3, int num4, int num5, int num6) {
            int sum = 0;
            int num11 = num1 * 20;
            sum += num11;
            int num21 = num2 * 12;
            sum += num21;
            int num31 = num3 * 6;
            sum += num31;
            int num41 = num4 * 2;
            sum += num41;
            int num51 = num5 * 7;
            sum += num51;
            int num61 = num6 * 8;
            sum += num61;
            int totalfood = sum;
            return totalfood;

        }
        private int calculate2(int num1, int num2, int num3, int num4, int num5, int num6)
        {
            int sum = 0;
            int num11 = num1 * 1;
            sum += num11;
            int num21 = num2 * 1;
            sum += num21;
            int num31 = num3 * 1;
            sum += num31;
            int num41 = num4 * 1;
            sum += num41;
            int num51 = num5 * 1;
            sum += num51;
            int num61 = num6 * 1;
            sum += num61;
            int totalfood = sum;
            return totalfood;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

