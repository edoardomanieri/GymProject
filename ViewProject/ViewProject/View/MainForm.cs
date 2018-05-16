using Palestra.Persistence;
using Palestra.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewProject.Presentation;

namespace ViewProject.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
            MainPersistanceManager mpm = new MainPersistanceManager();
            //inizializzo presenter 
            UserControl view;

            view = ViewFactory.GetView("CreaSchedaAutomaticaView");
            CreaSchedaAutomaticaPresenter creaSchedaAutomaticaPresenter = new CreaSchedaAutomaticaPresenter(mpm, (CreaSchedaAutomaticaView)view);

            view = ViewFactory.GetView("SchermataPrincipaleView");
            SchermataPrincipalePresenter schermataPrincipalePresenter = new SchermataPrincipalePresenter(mpm, (SchermataPrincipaleView)view);

            view = ViewFactory.GetView("CreaAccountView");
            CreaAccountPresenter creaAccountPresenter = new CreaAccountPresenter(mpm, (CreaAccountView)view);


            if (mpm.ThereIsASavedAccount())
            {
                SetView(ViewFactory.GetView("SchermataPrincipaleView"));
            }
            else
            {
                SetView(ViewFactory.GetView("CreaAccountView"));
            }

           

        }


        public void SetView(UserControl view)
        {
             view.Dock = DockStyle.Fill;
            _mainPanel.Controls.Clear();
            _mainPanel.Controls.Add(view);
        }
    }
}

