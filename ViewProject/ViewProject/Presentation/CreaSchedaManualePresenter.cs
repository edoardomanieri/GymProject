using Palestra.model;
using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Presentation
{
    public class CreaSchedaManualePresenter
    {
        private PianoAllenamento _pianoAllenamento;
        private MainPersistanceManager _mpm;
        private CreaSchedaManualeView _view;
        private List<GiornoAllenamento> _giorniAllenamento;

        public CreaSchedaManualePresenter(MainPersistanceManager mpm, CreaSchedaManualeView view)
        {
            _mpm = mpm;
            _view = view;

            if (_mpm.ThereIsAPianoAllenamento())
            {
                Utente utente = _mpm.LoadUtente();
                _pianoAllenamento = _mpm.LoadPianoAllenamento(utente);
            }
            else
            {
                _pianoAllenamento = new PianoAllenamento();
            }

            _pianoAllenamento.Changed += ChangePiano;
            _view.buttonAggiungiEsercizio.Click += Click_AggiungiEsercizio;

            _view.giornoSettimana.SelectedValueChanged += Change_GiornoAllenamento;

        }

        private void Change_GiornoAllenamento(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Click_AggiungiEsercizio(object sender, EventArgs e)
        {
            Esercizio esercizio = _mpm.GetEsercizioByName(_view.comboBoxEsercizi.Text);
            int numeroSerie = (int)_view.numeroSerie.Value;
            int numeroRipetizioni = (int)_view.numeroRipetizioni.Value;
            int tempoRecupero = (int)_view.tempoRecupero.Value;

            //nella classe pianoAllenamento aggiungere il metodo addEsercizioInGiornoAllenamento(int numeroGiorno, EsecuzioneEsercizio esecuzioneEsercizio)
            //nel model aggiungere toString e equals
            //nell'inserimento scheda manuale non è possibile mettere esercizi a tempo per il momento(paul)
        }

        private void ChangePiano(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
