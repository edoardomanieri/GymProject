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
        public CreaSchedaAutomaticaView()
        {
            InitializeComponent();
        }

        private void buttonProcedi_Click(object sender, EventArgs e)
        {
            if (!isCompleted())
            {
                //show dialog
                return;
            }
            MainForm mainForm = (MainForm)this.FindForm();
            UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            mainForm.SetView(view);
        }

        private bool isCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
