using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class SchermataAutenticazioneView : UserControl
    {
        public SchermataAutenticazioneView()
        {
            InitializeComponent();
        }

        


        int i = 0;

        private void buttonShowHide1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                buttonShowHide1.Image = imageHidePassword.Image;
                i = 1;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                buttonShowHide1.Image = imageShowPassword.Image;
                i = 0;
            }
        }

        private void SchermataAutenticazioneView_Load(object sender, EventArgs e)
        {

        }
    }
}
