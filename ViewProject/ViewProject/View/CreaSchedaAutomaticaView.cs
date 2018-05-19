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
    public partial class CreaSchedaAutomaticaView : UserControl
    {
        private bool isCompletedModalita = false;
        private bool isCompletedObiettivo = false;

        public CreaSchedaAutomaticaView()
        {
            InitializeComponent();
        }

        private void buttonProcedi_Click(object sender, EventArgs e)
        {
            if (!IsCompleted())
            {
                MessageBox.Show("Inserire tutti i dati per proseguire!");
                return;
            }
            MainForm mainForm = (MainForm)this.FindForm();
            UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            mainForm.SetView(view);
        }

        public bool  IsCompleted()
        {
            return isCompletedModalita && isCompletedObiettivo;
        }

        private void comboBoxObiettivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            isCompletedObiettivo = true;
        }

        private void comboModalita_SelectedIndexChanged(object sender, EventArgs e)
        {
            isCompletedModalita = true;
        }
    }
}
