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

        public CreaSchedaManualePresenter(MainPersistanceManager mpm, CreaSchedaManualeView view, Utente utente)
        {
            _mpm = mpm;
            _utente = utente;
            _view = view;
            isCompleted_GiornoSettimana = false;
 
            _view.Load += OnLoad;
            _view.buttonAggiungiEsercizio.Click += Click_AggiungiEsercizio;
            _view.giornoSettimana.SelectedValueChanged += Change_GiornoSettimana;
            _view.buttonSalvaGiornata.Click += Click_SalvaGiorno;
            _view.buttonEliminaEsercizio.Click += Click_EliminaEsercizio;
            _view.buttonSalvaScheda.Click += Click_SalvaScheda;
            _view.comboBoxEsecuzioneEsercizio.TextChanged += TextChanged_TipoEsercizio;
            _view.giornoSettimana.SelectionChangeCommitted += SelectionChange_GiornoSettimana;
            _view.listBoxEsecuzioneEsercizi.SelectedValueChanged += SelectionChange_EsecuzioneEsercizi;
            _view.comboBoxFasciaMuscolare.SelectedIndexChanged += SelectionChange_FasciaMuscolare;
            _view.buttonIndietro.Click += Click_ButtonIndietro;
  

        }


        private void Click_ButtonIndietro(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)_view.FindForm();
            UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            mainForm.SetView(view);
        }

        private void SelectionChange_FasciaMuscolare(object sender, EventArgs e)
        {
            _view.comboBoxEserciziSerie.Items.Clear();
            foreach(Esercizio esercizio in _mpm.LoadAllEsercizi())
            {
                if (esercizio.FasciaMuscolare.Equals(MainPersistanceManager.getFasciaMuscolare(_view.comboBoxFasciaMuscolare.Text)))
                    _view.comboBoxEserciziSerie.Items.Add(esercizio);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            try
            {
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
                    _pianoAllenamento = new PianoAllenamento();
                    //creo il primo giorno
                    _pianoAllenamento.addGiornoAllenamento(new GiornoAllenamento());
                    _pianoAllenamento.GiorniAllenamento[0].Changed += ChangeGiornoAllenamento;
                }

                _pianoAllenamento.Changed += ChangePiano;
            }
            catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SelectionChange_EsecuzioneEsercizi(object sender, EventArgs e)
        {
            if(_view.listBoxEsecuzioneEsercizi.SelectedItem != null)
                _esercizioSelezionato = (EsecuzioneEsercizio)_view.listBoxEsecuzioneEsercizi.SelectedItem;
        }

        private void SelectionChange_GiornoSettimana(object sender, EventArgs e)
        {
            _numeroGiorno = int.Parse(_view.giornoSettimana.SelectedItem.ToString()) - 1;
        }

        private void TextChanged_TipoEsercizio(object sender, EventArgs e)
        {
            if (_view.comboBoxEsecuzioneEsercizio.Text.Equals("Esercizio a tempo"))
            {
                _view.comboBoxEserciziTempo.Items.Clear();
                _view.panelASerie.Hide();
                _view.panelATempo.Show();
                foreach (Esercizio esercizio in _mpm.LoadAllEsercizi())
                {
                    if (esercizio.FasciaMuscolare.Equals(FasciaMuscolare.Cardio))
                        _view.comboBoxEserciziSerie.Items.Add(esercizio.ToString());
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

        private void Click_SalvaScheda(object sender, EventArgs e)
        {
            if (_pianoAllenamento.GiorniAllenamento.Last().ListaEsecuzioniEsercizi.Count == 0)
                _pianoAllenamento.removeGiornoAllenamento(_pianoAllenamento.GiorniAllenamento.Last());
            try
            {
                _mpm.SavePianoAllenamento(_utente, _pianoAllenamento);
            }
            catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (MessageBox.Show("La scheda contiene " + (_view.giornoSettimana.Items.Count - 1) + " giorni di allenamento.\nTerminare e Salvare le modifiche ?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MainForm mainForm = (MainForm)_view.FindForm();
                SchermataPrincipaleView view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
                //cambio la proprietà per innescare il cambiamento scheda
                view.Scheda = true;
                mainForm.SetView(view);
            }
        }



        private void Click_EliminaEsercizio(object sender, EventArgs e)
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

        private void Change_GiornoSettimana(object sender, EventArgs e)
        {
            isCompleted_GiornoSettimana = true;
            popolaListaEsecuzioneEsercizi();
        }

        private void ChangeGiornoAllenamento(object sender, EventArgs e)
        {
            //aggiorno la lista box
            popolaListaEsecuzioneEsercizi();

        }

        private void Click_SalvaGiorno(object sender, EventArgs e)
        {
            try
            {
                _pianoAllenamento.GiorniAllenamento[_numeroGiorno].TempoDiRecuperoInSec = (int)_view.tempoRecupero.Value;
                //è stata aggiunta una giornata
                if (_view.giornoSettimana.Items.Count == _numeroGiorno + 1)
                {
                    RipopolaGiorniAggiungendoneUno();
                    _pianoAllenamento.addGiornoAllenamento(new GiornoAllenamento());
                    _pianoAllenamento.GiorniAllenamento[_numeroGiorno + 1].Changed += ChangeGiornoAllenamento;
                    _view.giornoSettimana.SelectedItem = _numeroGiorno + 1;
                }
            }
            catch (Exception)
            {
                //messaggio di errore : non si puo salvare un giorno senza aver messo almeno un esercizio
                return;
            }
        }

        private void Click_AggiungiEsercizio(object sender, EventArgs e)
        {
            if (!isCompleted_GiornoSettimana)
            {
                MessageBox.Show("Inserire tutti i dati necessari");
                return;
            }
            Esercizio esercizio = _mpm.GetEsercizioByName(_view.comboBoxEserciziSerie.Text);
            EsecuzioneEsercizio esecuzioneEsercizio;
            //da sistemare questa condizione
            if(_view.comboBoxEsecuzioneEsercizio.Text.Equals("Esercizio a serie"))
            {
                int numeroSerie = (int)_view.numeroSerie.Value;
                int numeroRipetizioni = (int)_view.numeroRipetizioni.Value;
                int tempoRecupero = (int)_view.tempoRecupero.Value;
                esecuzioneEsercizio = new EsecuzioneEsercizioASerie(esercizio, tempoRecupero, numeroRipetizioni, numeroSerie);

            }
            else
            {
                int tempo = (int)_view.numericUpDownTempo.Value;
                esecuzioneEsercizio = new EsecuzioneEsercizioATempo(esercizio, tempo);
            }

            try
            {
                _pianoAllenamento.GiorniAllenamento[_numeroGiorno].addEsecuzioneEsercizio(esecuzioneEsercizio);
            }
            catch(Exception)
            {
                _pianoAllenamento.addGiornoAllenamento(new GiornoAllenamento());
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


        private void ChangePiano(object sender, EventArgs e)
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
