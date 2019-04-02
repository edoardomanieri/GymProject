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
