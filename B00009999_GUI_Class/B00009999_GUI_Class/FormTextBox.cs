using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B00009999_GUI_Class
{
    public partial class FormTextBox : Form
    {
        public FormTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("text box 被改變了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = tbInput.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a,b;
            try
            {
                a = Int32.Parse(textBox2.Text);
                b = Int32.Parse(textBox3.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字!");
                a = 0;
                b = 0;
            }

            int sum = a + b;
            label4.Text =sum.ToString();



        }
    }
}
