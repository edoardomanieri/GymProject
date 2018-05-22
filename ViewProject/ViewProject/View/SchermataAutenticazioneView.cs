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

<<<<<<< HEAD

        private void buttonShowHide1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                buttonShowHide1.Image = imageHidePassword.Image;
=======
        


        int i = 0;

        private void buttonShowHide1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                buttonShowHide1.Image = imageHidePassword.Image;
                i = 1;
>>>>>>> 57c9c0ba15e46139d1dabcf707614d5bb172cf67
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                buttonShowHide1.Image = imageShowPassword.Image;
<<<<<<< HEAD
            }
        }

=======
                i = 0;
            }
        }

        private void SchermataAutenticazioneView_Load(object sender, EventArgs e)
        {

        }
>>>>>>> 57c9c0ba15e46139d1dabcf707614d5bb172cf67
    }
}
