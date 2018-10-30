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
        private static CreaSchedaAutomaticaPresenter _instance = null;

        public Utente Utente { get => _utente; set => _utente = value; }

        public static CreaSchedaAutomaticaPresenter GetInstance()
        {
            if (_instance == null)
                throw new InvalidOperationException("CreaSchedaAutomaticaPresenter instance not created !");
            return _instance;
        }

        public static CreaSchedaAutomaticaPresenter Create(MainPersistanceManager mpm, CreaSchedaAutomaticaView creaSchedaAutomaticaView, GestorePianiAllenamento gestorePianiAllenamento)
        {
            if (_instance != null)
                throw new InvalidOperationException("CreaSchedaAutomaticaPresenter instance already created !");

            _instance = new CreaSchedaAutomaticaPresenter(mpm, creaSchedaAutomaticaView, gestorePianiAllenamento);
            return _instance;
        }

        private CreaSchedaAutomaticaPresenter(MainPersistanceManager mpm, CreaSchedaAutomaticaView creaSchedaAutomaticaView, GestorePianiAllenamento gestorePianiAllenamento)
        {
            _mpm = mpm;
            _creaSchedaAutomaticaView = creaSchedaAutomaticaView;
            _gestorePianiAllenamento = gestorePianiAllenamento;


            _creaSchedaAutomaticaView.Load += CaricaObbiettiviERisorse;
            _creaSchedaAutomaticaView.buttonProcedi.Click += SaveUtenteAutomatico;
        }

        private void CaricaObbiettiviERisorse(object sender, EventArgs e)
        {
            foreach (TipoAllenamento tipoAllenamento in Enum.GetValues(typeof(TipoAllenamento)))
                _creaSchedaAutomaticaView.comboBoxObiettivo.Items.Add(tipoAllenamento.ToString());
            foreach (Risorsa risorsa in Enum.GetValues(typeof(Risorsa)))
                _creaSchedaAutomaticaView.comboModalita.Items.Add(risorsa.ToString());
        }

        private void SaveUtenteAutomatico(object sender, EventArgs e)
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
                _utente = new UtenteAutomatico(_utente.Username, _utente.Nome, _utente.Cognome, _utente.DataDiNascita, _utente.PesoInKg, _utente.AltezzaInCm, _utente.Sesso, risorsa, numeroAllenamenti, tipo);
                PianoAllenamento pianoAllenamento = _gestorePianiAllenamento.getOrUpdatePianoAllenamento((UtenteAutomatico)_utente, (List<Esercizio>)_mpm.LoadAllEsercizi());
                _mpm.SavePianoAllenamento(_utente, pianoAllenamento);
                SetUtente();
                MainForm mainForm = (MainForm)_creaSchedaAutomaticaView.FindForm();
                UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
                mainForm.SetView(view);
            }
            catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void SetUtente()
        {
            CreaSchedaManualePresenter.GetInstance().Utente = _utente;
            ProfiloPresenter.GetInstance().Utente = _utente;
            ProgressiPresenter.GetInstance().Utente = _utente;
            SchermataPrincipalePresenter.GetInstance().Utente = _utente;
        }
    }

    }
