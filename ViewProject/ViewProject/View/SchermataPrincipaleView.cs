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
    public partial class SchermataPrincipaleView : UserControl
    {
        public SchermataPrincipaleView()
        {
            InitializeComponent();
<<<<<<< HEAD
=======

            
        }

        private void buttonProfilo_Click(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("ProfiloView");
            MainForm mainForm = (MainForm)this.FindForm();
            mainForm.SetView(view);

        }

        private void buttonProgressi_Click(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("ProgressiView");
            MainForm mainForm = (MainForm)this.FindForm();
            mainForm.SetView(view);
        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("VideoView");
            MainForm mainForm = (MainForm)this.FindForm();
            mainForm.SetView(view);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("CreaAccountView");
            MainForm mainForm = (MainForm)this.FindForm();
            mainForm.SetView(view);
        }

        private void buttonModificaScheda_Click(object sender, EventArgs e)
        {
            CreaSchedaManualeView view = (CreaSchedaManualeView)ViewFactory.GetView("CreaSchedaManualeView");
            MainForm mainForm = (MainForm)this.FindForm();
            view.buttonIndietro.Visible = true;
            view.buttonIndietro.Enabled = true;
            mainForm.SetView(view);
        }

        private void buttonFrase_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetFrase(), "La frase pensata per te:");
        }
        public string GetFrase()
        {
            int da = 1;
            int a = 43;
            Random random = new Random();
            int numeroCasuale = random.Next(da, a);
            string line = "";
            StringBuilder frase = new StringBuilder();
>>>>>>> 57c9c0ba15e46139d1dabcf707614d5bb172cf67

        }
    }
}
