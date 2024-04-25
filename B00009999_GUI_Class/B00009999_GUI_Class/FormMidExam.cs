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
    public partial class FormMidExam : Form
    {
        public FormMidExam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c=0;
            try
            {
                c = Int32.Parse(textBox1.Text);
            }
            catch
            {
                //MessageBox.Show("請輸入數字");
                label3.Text = "輸入錯誤!";
                return;//這個功能結束
            }
            //(攝氏) * (9 / 5) + 32
            double temp = 9.0 / 5.0;//double/double=double
            //小*小=小
            //大*小=大
            //大*大=大
            double f = c * temp + 32;
            label3.Text = f.ToString()+" F";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
