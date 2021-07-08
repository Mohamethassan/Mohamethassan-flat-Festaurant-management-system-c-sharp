using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restauant_Managing
{
    public partial class employee_info : UserControl
    {
        public employee_info()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newList = new ListViewItem(textBox1.Text);
            newList.SubItems.Add(textBox2.Text);
            newList.SubItems.Add(textBox3.Text);
            newList.SubItems.Add(textBox5.Text);
            newList.SubItems.Add(textBox4.Text);
            newList.SubItems.Add(textBox6.Text);
            listView1.Items.Add(newList);
            
            //
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox1.Focus();

        }
        
        public void cc()
        {
           
        }

        private void employee_info_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
