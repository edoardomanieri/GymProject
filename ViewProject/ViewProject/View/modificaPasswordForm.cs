using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject.View
{
    public partial class ModificaPasswordForm : Form
    {
        public ModificaPasswordForm()
        {
            InitializeComponent();
        }
        private void buttonShowHide1_Click(object sender, EventArgs e)
        {
            if (textBoxVecchiaPassword.UseSystemPasswordChar)
            {
                textBoxVecchiaPassword.UseSystemPasswordChar = false;
                buttonShowHide1.Image = imageHidePassword.Image;
            }
            else
            {
                textBoxVecchiaPassword.UseSystemPasswordChar = true;
                buttonShowHide1.Image = imageShowPassword.Image;
            }
        }
        private void buttonShowHide2_Click(object sender, EventArgs e)
        {
            if (textBoxNuovaPassword.UseSystemPasswordChar)
            {
                textBoxNuovaPassword.UseSystemPasswordChar = false;
                buttonShowHide2.Image = imageHidePassword.Image;
            }
            else
            {
                textBoxNuovaPassword.UseSystemPasswordChar = true;
                buttonShowHide2.Image = imageShowPassword.Image;
            }
        }


        private void buttonShowHide3_Click(object sender, EventArgs e)
        {
            if (textBoxConfermaPassword.UseSystemPasswordChar)
            {
                textBoxConfermaPassword.UseSystemPasswordChar = false;
                buttonShowHide3.Image = imageHidePassword.Image;
            }
            else
            {
                textBoxConfermaPassword.UseSystemPasswordChar = true;
                buttonShowHide3.Image = imageShowPassword.Image;
            }

        }

        

        
    }
}
