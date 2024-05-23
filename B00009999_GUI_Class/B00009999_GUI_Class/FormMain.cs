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

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            Form formTextBox=new FormTextBox();
            formTextBox.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formMidExam = new FormMidExam();
            formMidExam.Show();
        }

        private void button_TryCatch_Click(object sender, EventArgs e)
        {
            Form formTryCatch = new FormTryCatch();
            formTryCatch.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formTimer = new FormTimer();
            formTimer.Show();
        }

        private void btnGameFinalPaws_Click(object sender, EventArgs e)
        {
            Form form = new FormGameFinalPaws();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new FormCheckBox();
            form.Show();
        }
    }
}
