
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewProject.model;
using ViewProject.Persistence;
using ViewProject.View;

namespace ViewProject.Presentation
{
    public class SchermataPrincipalePresenter
    {
        private MainPersistanceManager _mpm;
        private SchermataPrincipaleView _schermataPrincipaleView;
        private Utente _utente;
        private static SchermataPrincipalePresenter _instance = null;
        private event EventHandler utenteChanged;

        public Utente Utente
        {
            get => _utente;
            set
            {
                _utente = value;
                if (_utente != default(Utente))
                    OnUtenteChanged();
            }
        }


        private void OnUtenteChanged()
        {
            utenteChanged?.Invoke(this, EventArgs.Empty);
        }


        public static SchermataPrincipalePresenter GetInstance()
        {
            if (_instance == null)
                throw new InvalidOperationException("SchermataPrincipalePresenter instance not created !");
            return _instance;
        }

        public static SchermataPrincipalePresenter Create(MainPersistanceManager mpm, SchermataPrincipaleView view)
        {
            if (_instance != null)
                throw new InvalidOperationException("SchermataPrincipalePresenter instance already created !");

            _instance = new SchermataPrincipalePresenter(mpm, view);
            return _instance;
        }


        private SchermataPrincipalePresenter(MainPersistanceManager mpm, SchermataPrincipaleView schermataPrincipaleView)
        {
            _mpm = mpm;
            _schermataPrincipaleView = schermataPrincipaleView;

            this.utenteChanged += ShowPianoAllenamento;
            _schermataPrincipaleView.SchedaChanged += ShowPianoAllenamento;
            _schermataPrincipaleView.Load += ShowPianoAllenamento;
            _schermataPrincipaleView.buttonReset.Click += EliminaAccount;
            _schermataPrincipaleView.buttonProfilo.Click += SetProfiloView;
            _schermataPrincipaleView.buttonProgressi.Click += buttonProgressi_Click;
            _schermataPrincipaleView.buttonVideo.Click += buttonVideo_Click;
            _schermataPrincipaleView.buttonModificaScheda.Click += buttonModificaScheda_Click;
            _schermataPrincipaleView.buttonFrase.Click += buttonFrase_Click;
            _schermataPrincipaleView.dataGridViewScheda.CellDoubleClick += ShowVideoPerEsercizio;
            _schermataPrincipaleView.buttonEsci.Click += Logout;
        }

        private void Logout(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler uscire?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                UserControl view = ViewFactory.GetView("SchermataAutenticazioneView");
                MainForm mainForm = (MainForm)_schermataPrincipaleView.FindForm();
                mainForm.SetView(view);
            }
        }

        private void ShowVideoPerEsercizio(object sender, EventArgs e)
        {
            string esercizioString = _schermataPrincipaleView.dataGridViewScheda.CurrentCell.FormattedValue.ToString();
            Esercizio esercizio = _mpm.GetEsercizioByName(esercizioString);
            VideoView view = (VideoView)ViewFactory.GetView("VideoView");
            MainForm mainForm = (MainForm)_schermataPrincipaleView.FindForm();
            mainForm.SetView(view);
            view.comboBoxFasciaMuscolareVideo.Text = esercizio.FasciaMuscolare.ToString();
            view.listBoxEserciziVideo.Text = esercizio.ToString();
            view.textBoxDescrizione.Text = esercizio.Descrizione;
            string path = "..\\..\\resources\\video\\" + esercizio.Nome + ".mp4";
            if (File.Exists(path))
                view.axWindowsMediaPlayer.URL = path;
        }

        private void SetProfiloView(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("ProfiloView");
            MainForm mainForm = (MainForm)_schermataPrincipaleView.FindForm();
            mainForm.SetView(view);

        }

        private void buttonProgressi_Click(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("ProgressiView");
            MainForm mainForm = (MainForm)_schermataPrincipaleView.FindForm();
            mainForm.SetView(view);
        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("VideoView");
            MainForm mainForm = (MainForm)_schermataPrincipaleView.FindForm();
            mainForm.SetView(view);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            UserControl view = ViewFactory.GetView("CreaAccountView");
            MainForm mainForm = (MainForm)_schermataPrincipaleView.FindForm();
            mainForm.SetView(view);
        }

        private void buttonModificaScheda_Click(object sender, EventArgs e)
        {
            CreaSchedaManualeView view = (CreaSchedaManualeView)ViewFactory.GetView("CreaSchedaManualeView");
            MainForm mainForm = (MainForm)_schermataPrincipaleView.FindForm();
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

            System.IO.StreamReader file = new System.IO.StreamReader(@"../../Frasi.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.ElementAt(0).Equals('#'))
                {
                    line = line.Remove(0, 1);
                    if (line.Equals(numeroCasuale.ToString()))
                    {
                        while (!(line = file.ReadLine()).Equals("FINE"))
                        {
                            frase.Append(line);
                        }
                        file.Close();
                        return frase.ToString();
                    }
                }
            }
            file.Close();
            return frase.ToString();
        }

        private void EliminaAccount(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler cancellare l'account? Tutti i progressi verranno persi", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                _mpm.Reset(_utente);
                UserControl view = ViewFactory.GetView("SchermataAutenticazioneView");
                MainForm mainForm = (MainForm)_schermataPrincipaleView.FindForm();
                mainForm.SetView(view);
            }
        }

        private void ShowPianoAllenamento(object sender, EventArgs e)
        {
            PianoAllenamento piano = _mpm.LoadPianoAllenamento(_utente);
            int numeroGiorni = 0;

            _schermataPrincipaleView.dataGridViewScheda.Rows.Clear();
            foreach (GiornoAllenamento giorno in piano.GiorniAllenamento)
            {
                _schermataPrincipaleView.dataGridViewScheda.Rows.Add(null, "");
                numeroGiorni++;
                foreach (EsecuzioneEsercizio esercizio in giorno.ListaEsecuzioniEsercizi)
                {
                    if (esercizio is EsecuzioneEsercizioASerie)
                    {
                        EsecuzioneEsercizioASerie esSerie = (EsecuzioneEsercizioASerie)esercizio;
                        _schermataPrincipaleView.dataGridViewScheda.Rows.Add(numeroGiorni, esercizio.Esercizio.Nome, esSerie.NumeroSerie, esSerie.NumeroRipetizioni, esSerie.TempoDiRecuperoInSec, esSerie.Carico, null);
                    }
                    else
                    {
                        EsecuzioneEsercizioATempo esTempo = (EsecuzioneEsercizioATempo)esercizio;
                        _schermataPrincipaleView.dataGridViewScheda.Rows.Add(numeroGiorni, esercizio.Esercizio.Nome, null, null, null, null, esTempo.Tempo);
                    }
                }
            }

        }
    }
}
