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

            _creaSchedaAutomaticaView.Load += OnLoad;
            _creaSchedaAutomaticaView.buttonProcedi.Click += Click_buttonProcedi;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            foreach (TipoAllenamento tipoAllenamento in Enum.GetValues(typeof(TipoAllenamento)))
                _creaSchedaAutomaticaView.comboBoxObiettivo.Items.Add(tipoAllenamento.ToString());
            foreach (Risorsa risorsa in Enum.GetValues(typeof(Risorsa)))
                _creaSchedaAutomaticaView.comboModalita.Items.Add(risorsa.ToString());
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
            PianoAllenamento pianoAllenamento = _gestorePianiAllenamento.getOrUpdatePianoAllenamento((UtenteAutomatico)_utente, (List<Esercizio>)_mpm.LoadAllEsercizi());
            try
            {
                _mpm.SavePianoAllenamento(_utente, pianoAllenamento);
            }catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AvviaViewsEPresenter();
            MainForm mainForm = (MainForm)_creaSchedaAutomaticaView.FindForm();
            UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            mainForm.SetView(view);
        }


        private void AvviaViewsEPresenter()
        {
            UserControl view;

            view = ViewFactory.GetView("SchermataPrincipaleView");
            SchermataPrincipalePresenter schermataPrincipalePresenter = new SchermataPrincipalePresenter(_mpm, (SchermataPrincipaleView)view, _utente);

            view = ViewFactory.GetView("CreaSchedaManualeView");
            CreaSchedaManualePresenter creaSchedaManualePresenter = new CreaSchedaManualePresenter(_mpm, (CreaSchedaManualeView)view, _utente);

            view = ViewFactory.GetView("ProgressiView");
            ProgressiPresenter progressiPresenter = new ProgressiPresenter(_mpm, (ProgressiView)view, _utente, _gestorePianiAllenamento);

            view = ViewFactory.GetView("ProfiloView");
            ProfiloPresenter profiloView = new ProfiloPresenter(_mpm, (ProfiloView)view, _utente);

            view = ViewFactory.GetView("VideoView");
            VideoPresenter videoPresenter = new VideoPresenter(_mpm, (VideoView)view);
        }
    }
}
