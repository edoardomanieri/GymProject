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
    public class CreaSchedaAutomaticaPresenter
    {

        private MainPersistanceManager _mpm;
        private CreaSchedaAutomaticaView _creaSchedaAutomaticaView;
        private Utente _utente;
        private GestorePianiAllenamento _gestorePianiAllenamento;

        public CreaSchedaAutomaticaPresenter(MainPersistanceManager mpm, CreaSchedaAutomaticaView creaSchedaAutomaticaView, Utente utente, GestorePianiAllenamento gestorePianiAllenamento)
        {
            _mpm = mpm;
            _creaSchedaAutomaticaView = creaSchedaAutomaticaView;
            _gestorePianiAllenamento = gestorePianiAllenamento;
            _utente = utente;


            _creaSchedaAutomaticaView.buttonProcedi.Click += Click_buttonProcedi;
        }

        private void Click_buttonProcedi(object sender, EventArgs e)
        {
            if (!_creaSchedaAutomaticaView.IsCompleted())
            {
                MessageBox.Show("Inserire tutti i dati per proseguire!");
                return;
            }
            Risorsa risorsa = MainPersistanceManager.getRisorsa(_creaSchedaAutomaticaView.comboModalita.Text).Value;
            TipoAllenamento tipo = MainPersistanceManager.getTipoAllenamento(_creaSchedaAutomaticaView.comboBoxObiettivo.Text).Value;
            int numeroAllenamenti = (int)_creaSchedaAutomaticaView.numericUpDownAllenamenti.Value;
           
            //verra per forza invocata dopo che un utente è gia stato salvato
            try
            {
                _mpm.SaveUtenteAutomatico(_utente, risorsa, numeroAllenamenti, tipo);
            }catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //creo e salvo il pianoAllenamento automatico
            _utente = new UtenteAutomatico(_utente.Username,_utente.Nome,_utente.Cognome, _utente.DataDiNascita, _utente.PesoInKg, _utente.AltezzaInCm,_utente.Sesso, risorsa,numeroAllenamenti,tipo);
            PianoAllenamento pianoAllenamento = _gestorePianiAllenamento.getPianoAllenamento((UtenteAutomatico)_utente, (List<Esercizio>)_mpm.LoadAllEsercizi());
            try
            {
                _mpm.SavePianoAllenamento(_utente, pianoAllenamento);
            }catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MainForm mainForm = (MainForm)_creaSchedaAutomaticaView.FindForm();
            UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            mainForm.SetView(view);
        }
    }
}
