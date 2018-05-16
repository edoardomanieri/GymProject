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
    public partial class ProfiloView : UserControl
    {
        public ProfiloView()
        {
            InitializeComponent();
        }

        private void buttonCaricaFoto_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBoxFoto.BackgroundImage = null;
                    pictureBoxFoto.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errore", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonRimuoviFoto_Click(object sender, EventArgs e)
        {
            pictureBoxFoto.ImageLocation = null;
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            TextBoxNome.ReadOnly = false;
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            TextBoxNome.ReadOnly = true;
        }
    }
}
