﻿using System;
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
    public partial class modificaPasswordForm : Form
    {
        public modificaPasswordForm()
        {
            InitializeComponent();
        }

        private void buttonShowHide1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                buttonShowHide1.Image = imageHidePassword.Image;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                buttonShowHide1.Image = imageShowPassword.Image;
            }
        }

        private void buttonShowHide2_Click(object sender, EventArgs e)
        {
            if (ConfirmPassword.UseSystemPasswordChar)
            {
                ConfirmPassword.UseSystemPasswordChar = false;
                buttonShowHide2.Image = imageHidePassword.Image;
            }
            else
            {
                ConfirmPassword.UseSystemPasswordChar = true;
                buttonShowHide2.Image = imageShowPassword.Image;
            }
        }
    }
}
