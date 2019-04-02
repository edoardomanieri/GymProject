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
        

        private void checkBoxAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxManuale.Checked = false;
        }

        private void checkBoxManuale_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAutomatica.Checked = false;
        }

        public bool CheckPassword()
        {
            if (CreaPassword.Text.Equals(ConfirmPassword.Text))
                return true;
            MessageBox.Show("Le Password inserite non corrispondono.");
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
