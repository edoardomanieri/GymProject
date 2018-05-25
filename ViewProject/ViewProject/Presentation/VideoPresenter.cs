using ViewProject.model;
using ViewProject.Persistence;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewProject.View;
using System.Windows.Forms;

namespace ViewProject.Presentation
{
    public class VideoPresenter
    {

        private MainPersistanceManager _mpm;
        private VideoView _view;
        private List<Esercizio> _esercizi;

        public VideoPresenter(MainPersistanceManager mpm, VideoView view)
        {
            _mpm = mpm;
            _view = view;

            _esercizi = (List<Esercizio>)_mpm.LoadAllEsercizi();
            _view.Load += OnLoad;
            _view.comboBoxFasciaMuscolareVideo.SelectedIndexChanged += SelectionChange_FasciaMuscolare;
            _view.listBoxEserciziVideo.SelectedIndexChanged += SelectionChange_Esercizio;
            _view.buttonIndietroVideo.Click += Click_ButtonIndietro;

        }

        private void Click_ButtonIndietro(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)_view.FindForm();
            UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            mainForm.SetView(view);
        }

        private void SelectionChange_Esercizio(object sender, EventArgs e)
        {
            Esercizio esercizio = (Esercizio)_view.listBoxEserciziVideo.SelectedItem;
            _view.textBoxDescrizione.Text = esercizio.Descrizione;

            string path = "..\\..\\resources\\video\\" + esercizio.Nome + ".mp4";
            if(File.Exists(path))
                _view.axWindowsMediaPlayer.URL = path;
            else
            {
                MessageBox.Show("Video non disponibile");
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            _view.listBoxEserciziVideo.Items.Clear();
            foreach (Esercizio esercizio in _esercizi)
                _view.listBoxEserciziVideo.Items.Add(esercizio);

        }

        private void SelectionChange_FasciaMuscolare(object sender, EventArgs e)
        {
            _view.listBoxEserciziVideo.Items.Clear();
            foreach (Esercizio esercizio in _esercizi)
            {
                if (esercizio.FasciaMuscolare.Equals(MainPersistanceManager.getFasciaMuscolare(_view.comboBoxFasciaMuscolareVideo.Text)))
                    _view.listBoxEserciziVideo.Items.Add(esercizio);
            }
        }
    }
}
