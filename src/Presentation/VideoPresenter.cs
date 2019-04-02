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
        private static VideoPresenter _instance = null;


        public static VideoPresenter GetInstance()
        {
            if (_instance == null)
                throw new InvalidOperationException("VideoPresenter instance not created !");
            return _instance;
        }

        public static VideoPresenter Create(MainPersistanceManager mpm, VideoView view)
        {
            if (_instance != null)
                throw new InvalidOperationException("VideoPresenter instance already created !");

            _instance = new VideoPresenter(mpm, view);
            return _instance;
        }

        private VideoPresenter(MainPersistanceManager mpm, VideoView view)
        {
            _mpm = mpm;
            _view = view;

            _esercizi = (List<Esercizio>)_mpm.LoadAllEsercizi();
            _view.Load += CaricaEsercizi;
            _view.comboBoxFasciaMuscolareVideo.SelectedIndexChanged += SelectionChange_FasciaMuscolare;
            _view.listBoxEserciziVideo.SelectedIndexChanged += ShowVideo;
            _view.buttonIndietroVideo.Click += SetSchermataPrincipaleView;

        }

        private void SetSchermataPrincipaleView(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)_view.FindForm();
            UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            mainForm.SetView(view);
        }

        private void ShowVideo(object sender, EventArgs e)
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

        private void CaricaEsercizi(object sender, EventArgs e)
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
