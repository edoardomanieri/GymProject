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

        private void buttonSalvaScheda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("La scheda contiene " + (giornoSettimana.Items.Count - 1) + " giorni di allenamento.\nTerminare e Salvare le modifiche ?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MainForm mainForm = (MainForm)this.FindForm();
                UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
                mainForm.SetView(view);
            }

        }

        private void buttonIndietro_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.FindForm();
            UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            mainForm.SetView(view);
        }
    }
}
