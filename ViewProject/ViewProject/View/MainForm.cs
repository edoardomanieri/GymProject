
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

            SchermataAutenticazioneView view = (SchermataAutenticazioneView)ViewFactory.GetView("SchermataAutenticazioneView");
            MainPresenter mainPresenter = new MainPresenter(this, view);
            SetView(view);

        }


        public void SetView(UserControl view)
        {
            _mainPanel.Controls.Clear();
            _mainPanel.Controls.Add(view);
        }
    }
}

