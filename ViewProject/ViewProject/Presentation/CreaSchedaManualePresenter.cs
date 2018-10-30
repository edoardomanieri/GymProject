using ViewProject.model;
using ViewProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ViewProject.View;

namespace ViewProject.Presentation
{
    public class CreaSchedaManualePresenter
    {
        private PianoAllenamento _pianoAllenamento;
        private MainPersistanceManager _mpm;
        private CreaSchedaManualeView _view;
        private int _numeroGiorno;
        private EsecuzioneEsercizio _esercizioSelezionato;
        private bool isCompleted_GiornoSettimana;
        private Utente _utente;
        private TempoRecuperoForm _tempoRecuperoForm;
        private int _tempoRecupero;
        private static CreaSchedaManualePresenter _instance = null;
        private event EventHandler utenteChanged;

        public Utente Utente
        {
            get => _utente;
            set
            {
                _utente = value;
                //lo invoco solo se l'utente è stato modificato
                if (_utente != default(Utente))
                    OnUtenteChanged();
            }
        }

        private void OnUtenteChanged()
        {
            utenteChanged?.Invoke(this, EventArgs.Empty);
        }

        public static CreaSchedaManualePresenter GetInstance()
        {
            if (_instance == null)
                throw new InvalidOperationException("CreaSchedaManualePresenter instance not created !");
            return _instance;
        }

        public static CreaSchedaManualePresenter Create(MainPersistanceManager mpm, CreaSchedaManualeView view)
        {
            if (_instance != null)
                throw new InvalidOperationException("CreaSchedaManualePresenter instance already created !");

            _instance = new CreaSchedaManualePresenter(mpm, view);
            return _instance;
        }

        private CreaSchedaManualePresenter(MainPersistanceManager mpm, CreaSchedaManualeView view)
        {
            _mpm = mpm;
            _view = view;
            isCompleted_GiornoSettimana = false;
            _tempoRecuperoForm = new TempoRecuperoForm();

            this.utenteChanged += CaricaPianoAllenamento;
            _view.Load += CaricaPianoAllenamento;
            _view.buttonAggiungiEsercizio.Click += AggiungiEsecuzioneEsercizio;
            _view.giornoSettimana.SelectedValueChanged += PopolaLista;
            _view.buttonSalvaGiornata.Click += SalvaGiornoAllenamento;
            _view.buttonEliminaEsercizio.Click += RimuoviEsecuzioneEsercizio;
            _view.buttonSalvaScheda.Click += SalvaPianoAllenamento;
            _view.comboBoxEsecuzioneEsercizio.TextChanged += ShowPanelPerTipoEsercizio;
            _view.giornoSettimana.SelectionChangeCommitted += ChangeSelectedGiornoSettimana;
            _view.listBoxEsecuzioneEsercizi.SelectedValueChanged += ChangeSelectedEsercizio;
            _view.comboBoxFasciaMuscolare.SelectedIndexChanged += CaricaEserciziPerFasciaMuscolare;
            _view.buttonIndietro.Click += SetSchermataPrincipaleView;
            _tempoRecuperoForm.buttonConferma.Click += GetTempoRecupero;
        }

        private void GetTempoRecupero(object sender, EventArgs e)
        {
            _tempoRecupero = (int)_tempoRecuperoForm.recuperoGiornoAllenamento.Value;
            _tempoRecuperoForm.Close();
        }


        private void SetSchermataPrincipaleView(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)_view.FindForm();
            UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            mainForm.SetView(view);
        }

        private void CaricaEserciziPerFasciaMuscolare(object sender, EventArgs e)
        {
            _view.comboBoxEserciziSerie.Items.Clear();
            foreach(Esercizio esercizio in _mpm.LoadAllEsercizi())
            {
                if (esercizio.FasciaMuscolare.Equals(MainPersistanceManager.getFasciaMuscolare(_view.comboBoxFasciaMuscolare.Text)))
                    _view.comboBoxEserciziSerie.Items.Add(esercizio);
            }
        }

        private void CaricaPianoAllenamento(object sender, EventArgs e)
        {
            try
            {
                _view.giornoSettimana.Items.Clear();
                if (_mpm.ThereIsAPianoAllenamento(_utente))
                {
                    _pianoAllenamento = _mpm.LoadPianoAllenamento(_utente);
                    foreach (GiornoAllenamento giornoAllenamento in _pianoAllenamento.GiorniAllenamento)
                    {
                        giornoAllenamento.Changed += ChangeGiornoAllenamento;
                        RipopolaGiorniAggiungendoneUno();
                    }
                }
                else
                {
                    RipopolaGiorniAggiungendoneUno();
                    _pianoAllenamento = new PianoAllenamento();
                }

                _pianoAllenamento.Changed += RipopolaGiorni;
                popolaListaEsecuzioneEsercizi();
            }
            catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ChangeSelectedEsercizio(object sender, EventArgs e)
        {
            if(_view.listBoxEsecuzioneEsercizi.SelectedItem != null)
                _esercizioSelezionato = (EsecuzioneEsercizio)_view.listBoxEsecuzioneEsercizi.SelectedItem;
        }

        private void ChangeSelectedGiornoSettimana(object sender, EventArgs e)
        {
            _numeroGiorno = int.Parse(_view.giornoSettimana.SelectedItem.ToString()) - 1;
        }

        private void ShowPanelPerTipoEsercizio(object sender, EventArgs e)
        {
            if (_view.comboBoxEsecuzioneEsercizio.Text.Equals("Esercizio a tempo"))
            {
                _view.comboBoxEserciziTempo.Items.Clear();
                _view.panelASerie.Hide();
                _view.panelATempo.Show();
                foreach (Esercizio esercizio in _mpm.LoadAllEsercizi())
                {
                    if (esercizio.FasciaMuscolare.Equals(FasciaMuscolare.Cardio))
                        _view.comboBoxEserciziTempo.Items.Add(esercizio.ToString());
                }

            }
            else if (_view.comboBoxEsecuzioneEsercizio.Text.Equals("Esercizio a serie"))
            {
                _view.comboBoxEserciziSerie.Items.Clear();
                _view.panelATempo.Hide();
                _view.panelASerie.Show();
                foreach (Esercizio esercizio in _mpm.LoadAllEsercizi())
                {
                    if(!esercizio.FasciaMuscolare.Equals(FasciaMuscolare.Cardio))
                        _view.comboBoxEserciziSerie.Items.Add(esercizio.ToString());
                }
            }
        }

        private void SalvaPianoAllenamento(object sender, EventArgs e)
        {
            int numeroGiorni = _view.giornoSettimana.Items.Count;
            if (_view.listBoxEsecuzioneEsercizi.Items.Count == 0)
                numeroGiorni--;
            try
            {
                _mpm.SavePianoAllenamento(_utente, _pianoAllenamento);
            }
            catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (MessageBox.Show("La scheda contiene " + numeroGiorni + " giorni di allenamento.\nTerminare e Salvare le modifiche ?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MainForm mainForm = (MainForm)_view.FindForm();
                SchermataPrincipaleView view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
                //cambio la proprietà per innescare il cambiamento scheda
                view.Scheda = true;
                mainForm.SetView(view);
            }
        }



        private void RimuoviEsecuzioneEsercizio(object sender, EventArgs e)
        {
            try
            {
                _pianoAllenamento.GiorniAllenamento[_numeroGiorno].removeEsecuzioneEsercizio(_esercizioSelezionato);
                //sono stati rimossi tutti gli esercizi
                if (_pianoAllenamento.GiorniAllenamento[_numeroGiorno].ListaEsecuzioniEsercizi.Count == 0)
                {
                    _pianoAllenamento.removeGiornoAllenamento(_pianoAllenamento.GiorniAllenamento[_numeroGiorno]);
                }

                popolaListaEsecuzioneEsercizi();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void PopolaLista(object sender, EventArgs e)
        {
            isCompleted_GiornoSettimana = true;
            popolaListaEsecuzioneEsercizi();
        }

        private void ChangeGiornoAllenamento(object sender, EventArgs e)
        {
            //aggiorno la list box
            popolaListaEsecuzioneEsercizi();

        }

        private void SalvaGiornoAllenamento(object sender, EventArgs e)
        {
                if (_view.giornoSettimana.Items.Count == _numeroGiorno + 1 && _view.giornoSettimana.Items.Count < 7 && _view.listBoxEsecuzioneEsercizi.Items.Count != 0)
                {
                    RipopolaGiorniAggiungendoneUno();
                    _view.giornoSettimana.SelectedItem = _numeroGiorno + 2;
                    _numeroGiorno++;
                    popolaListaEsecuzioneEsercizi();
                }        
        }

        private void AggiungiEsecuzioneEsercizio(object sender, EventArgs e)
        {
            if (!isCompleted_GiornoSettimana)
            {
                MessageBox.Show("Inserire tutti i dati necessari");
                return;
            }
            
            EsecuzioneEsercizio esecuzioneEsercizio;
            //da sistemare questa condizione
            if(_view.comboBoxEsecuzioneEsercizio.Text.Equals("Esercizio a serie"))
            {
                Esercizio esercizio = _mpm.GetEsercizioByName(_view.comboBoxEserciziSerie.Text);
                int numeroSerie = (int)_view.numeroSerie.Value;
                int numeroRipetizioni = (int)_view.numeroRipetizioni.Value;
                int tempoRecupero = (int)_view.tempoRecupero.Value;
                esecuzioneEsercizio = new EsecuzioneEsercizioASerie(esercizio, tempoRecupero, numeroRipetizioni, numeroSerie);

            }
            else
            {
                Esercizio esercizio = _mpm.GetEsercizioByName(_view.comboBoxEserciziTempo.Text);
                int tempo = (int)_view.numericUpDownTempo.Value;
                esecuzioneEsercizio = new EsecuzioneEsercizioATempo(esercizio, tempo);
            }

            try
            {
                _pianoAllenamento.GiorniAllenamento[_numeroGiorno].addEsecuzioneEsercizio(esecuzioneEsercizio);
            }
            catch(Exception)
            {
                _tempoRecuperoForm.ShowDialog();
                _pianoAllenamento.addGiornoAllenamento(new GiornoAllenamento(_tempoRecupero));
                _pianoAllenamento.GiorniAllenamento[_numeroGiorno].Changed += ChangeGiornoAllenamento;
                _pianoAllenamento.GiorniAllenamento[_numeroGiorno].addEsecuzioneEsercizio(esecuzioneEsercizio);
            }

        }

        private void popolaListaEsecuzioneEsercizi()
        {
            _view.listBoxEsecuzioneEsercizi.Items.Clear();
            try
            { 
            foreach (EsecuzioneEsercizio esecuzione in _pianoAllenamento.GiorniAllenamento[_numeroGiorno].ListaEsecuzioniEsercizi)

                {
                    _view.listBoxEsecuzioneEsercizi.Items.Add(esecuzione);
                }
            }
            catch
            {
                return;
            }             
        }


        private void RipopolaGiorni(object sender, EventArgs e)
        {

            try
            {
                if(_pianoAllenamento.GiorniAllenamento[_numeroGiorno] == null)
                    RipopolaGiorniTogliendoneUno();
            }
            catch (Exception)
            {
                RipopolaGiorniTogliendoneUno();
            }


        }

        private void RipopolaGiorniTogliendoneUno()
        {
            
            int numeroGiorni = _view.giornoSettimana.Items.Count;
            _view.giornoSettimana.Items.Clear();
            for (int i = 1; i < numeroGiorni; i++)
            {
                _view.giornoSettimana.Items.Add(i);
            }
        }

        private void RipopolaGiorniAggiungendoneUno()
        {
            
            int numeroGiorni = _view.giornoSettimana.Items.Count;
            _view.giornoSettimana.Items.Clear();
            for (int i = 1; i <= numeroGiorni + 1; i++)
            {
                _view.giornoSettimana.Items.Add(i);
            }
        }

    }
}
