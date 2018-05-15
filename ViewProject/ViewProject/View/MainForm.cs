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





            if (mpm.ThereIsASavedAccount())
            {
                SetView(ViewFactory.GetView("SchermataPrincipaleView"));
            }
            else
            {
                CreaAccountView view = (CreaAccountView)ViewFactory.GetView("CreaAccountView");
                CreaAccountPresenter creaAccountPresenter = new CreaAccountPresenter(mpm, view);
                SetView(view);
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

