using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewProject.View;

namespace ViewProject
{
    public partial class CreaAccountView : UserControl
    {

        public CreaAccountView()
        {
            InitializeComponent();
        }
        
        int i = 0;

        private void buttonShowHide1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                CreaPassword.UseSystemPasswordChar = false;
                buttonShowHide1.Image = imageHidePassword.Image;
                i = 1;
            }
            else
            {
                CreaPassword.UseSystemPasswordChar = true;
                buttonShowHide1.Image = imageShowPassword.Image;
                i = 0;
            }
        }
        int j = 0;
        private void buttonShowHide2_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                ConfirmPassword.UseSystemPasswordChar = false;
                buttonShowHide2.Image = imageHidePassword.Image;
                j = 1;
            }
            else
            {
                ConfirmPassword.UseSystemPasswordChar = true;
                buttonShowHide2.Image = imageShowPassword.Image;
                j = 0;
            }
        }

        private void checkBoxAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxManuale.Checked = false;
        }

        private void checkBoxManuale_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAutomatica.Checked = false;
        }

        private void buttonProcedi_Click(object sender, EventArgs e)
        {
 
            MainForm mainForm = (MainForm)this.FindForm();
            if (!isCompleted())
            {
                // show dialog inserire tutti i paramentri
            }
            if (checkBoxAutomatica.Checked)
            {
                UserControl view = (CreaSchedaAutomaticaView)ViewFactory.GetView("CreaSchedaAutomaticaView");
                mainForm.SetView(view);
            }
            else
            {
                CreaSchedaManualeView view = (CreaSchedaManualeView)ViewFactory.GetView("CreaSchedaManualeView");
                view.buttonIndietro.Visible = false;
                view.buttonIndietro.Enabled = false;
                mainForm.SetView(view);
            }


        }

        public bool CheckPassword()
        {
            if (CreaPassword.Text.Equals(ConfirmPassword.Text))
                return true;
            MessageBox.Show("Le Password devono essere uguali");
            return false;
        }

        public bool isCompleted()
        {
            if (string.IsNullOrEmpty(TextBoxNome.Text) ||
                 string.IsNullOrEmpty(TextBoxCognome.Text))
                return false;
            if (!RadioButtonFemmina.Checked && !RadioButtonMaschio.Checked)
                return false;
            if (!checkBoxAutomatica.Checked && !checkBoxManuale.Checked)
                return false;
            if (comboBoxGiorno.SelectedIndex == -1 ||
                comboBoxAnno.SelectedIndex == -1 ||
                comboBoxMese.SelectedIndex == -1)
                return false;
            return true;
        }
    }
}
