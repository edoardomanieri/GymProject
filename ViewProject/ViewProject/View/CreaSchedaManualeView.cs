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
    public partial class CreaSchedaManualeView : UserControl
    {
        public CreaSchedaManualeView()
        {
            InitializeComponent();
            panelASerie.Hide();
            panelATempo.Hide();

        }


        private void comboBoxEsecuzioneEsercizio_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxEsecuzioneEsercizio.Text.Equals("Esercizio a tempo"))
            {
                panelASerie.Hide();
                panelATempo.Show();
            }
            else if (comboBoxEsecuzioneEsercizio.Text.Equals("Esercizio a serie"))
            {
                panelATempo.Hide();
                panelASerie.Show();
            }
        }

    }
}
