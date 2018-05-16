using Palestra.model;
using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Presentation
{
    public class CreaSchedaAutomaticaPresenter
    {

        private MainPersistanceManager _mpm;
        private CreaSchedaAutomaticaView _creaSchedaAutomaticaView;

        public CreaSchedaAutomaticaPresenter(MainPersistanceManager mpm, CreaSchedaAutomaticaView creaSchedaAutomaticaView)
        {
            mpm = _mpm;
            _creaSchedaAutomaticaView = creaSchedaAutomaticaView;


            _creaSchedaAutomaticaView.buttonProcedi.Click += Click_buttonProcedi;
        }

        private void Click_buttonProcedi(object sender, EventArgs e)
        {
            if (!_creaSchedaAutomaticaView.isCompleted())
                return;
            Risorsa risorsa = MainPersistanceManager.getRisorsa(_creaSchedaAutomaticaView.comboModalita.Text).Value;
            TipoAllenamento tipo = MainPersistanceManager.getTipoAllenamento(_creaSchedaAutomaticaView.comboBoxObiettivo.Text).Value;
            int numeroAllenamenti = (int)_creaSchedaAutomaticaView.numericUpDownAllenamenti.Value;

            //verra per forza invocata dopo che un utente è gia stato salvato
            _mpm.SaveUtenteAutomatico(risorsa, numeroAllenamenti, tipo);
            
            //creo e salvo il pianoAllenamento automatico
            UtenteAutomatico utente = (UtenteAutomatico)_mpm.LoadUtente();
            GestorePianiAllenamento gpa = GestorePianiAllenamento.Instance;
            PianoAllenamento pianoAllenamento = gpa.getPianoAllenamento(utente, (List<Esercizio>)_mpm.LoadAllEsercizi());
            _mpm.SavePianoAllenamento(utente, pianoAllenamento);

        }
    }
}
