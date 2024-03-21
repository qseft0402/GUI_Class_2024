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
    public partial class FormMain : Form
    {
        Form formButton = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            //btnButton.Text = "我已經被按過了";
            if (formButton == null) { 
                formButton = new FormButton();
                formButton.Show();
            }
            else
            {
                formButton.Close();
                formButton = new FormButton();
                formButton.Show();
            }


        }
    }
}
