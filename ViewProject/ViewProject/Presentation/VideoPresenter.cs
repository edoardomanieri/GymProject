using Palestra.model;
using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        private void SelectionChange_Esercizio(object sender, EventArgs e)
        {
            Esercizio esercizio = (Esercizio)_view.listBoxEserciziVideo.SelectedItem;
            esercizio.GetDescrizione();
            _view.textBoxDescrizione.Text = esercizio.Descrizione;

            string path = "..\\..\\resources\\video\\" + esercizio.Nome + ".mp4";
            if(File.Exists(path))
                _view.axWindowsMediaPlayer.URL = path;
            else
            {
                //show dialog video non disponibile
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
