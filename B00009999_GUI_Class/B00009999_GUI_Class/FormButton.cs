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
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (btnClick.Text == "請按我一下")
                btnClick.Text = "我已經被按過了";
            else if (btnClick.Text == "我已經被按過了")
                btnClick.Text = "請按我一下";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "下方按鈕已被按過";
            label1.Size = new System.Drawing.Size(100, 20);
            label1.BackColor = System.Drawing.Color.Green;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string tmp = labCount.Text; //抓到label的數字字串
            int sum=Int32.Parse(tmp)+1; //將字串轉為int並+1
            labCount.Text = sum.ToString(); //把sum轉乘string放到labCount的Text
        }
    }
}
