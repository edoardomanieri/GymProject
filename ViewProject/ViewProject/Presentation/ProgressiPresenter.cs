using ViewProject.model;
using ViewProject.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ViewProject.View;

namespace ViewProject.Presentation
{
    public class ProgressiPresenter
    {
        private MainPersistanceManager _mpm;
        private ProgressiView _view;
        private Utente _utente;
        private List<Allenamento> _allenamenti;
        private GestorePianiAllenamento _gpa;
        private int _countAllenamenti;
        private static ProgressiPresenter _instance = null;
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

        public static ProgressiPresenter GetInstance()
        {
            if (_instance == null)
                throw new InvalidOperationException("ProgressiPresenter instance not created !");
            return _instance;
        }

        public static ProgressiPresenter Create(MainPersistanceManager mpm, ProgressiView view, GestorePianiAllenamento gpa)
        {
            if (_instance != null)
                throw new InvalidOperationException("ProgressiPresenter instance already created !");

            _instance = new ProgressiPresenter(mpm, view, gpa);
            return _instance;
        }

        private ProgressiPresenter(MainPersistanceManager mpm, ProgressiView view, GestorePianiAllenamento gpa)
        {
            _mpm = mpm;
            _view = view;
            _gpa = gpa;
            _countAllenamenti = 0;

            this.utenteChanged = CaricaAllenamenti;
            _view.Load += CaricaAllenamenti;
            _view.buttonSalvaAllenamentoProgressi.Click += SalvaAllenamento;
            _view.buttonIndietroProgressi.Click += SetSchermataPrincipaleView;
        }

        private void SetSchermataPrincipaleView(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)_view.FindForm();
            SchermataPrincipaleView view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            view.Scheda = true;
            mainForm.SetView(view);
  
        }

        private void SalvaAllenamento(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi di voler salvare l'allenamento del " + _view.dateTimePickerDataAllenamento.Value.Day.ToString() + "/" + _view.dateTimePickerDataAllenamento.Value.Month.ToString() + "/" + _view.dateTimePickerDataAllenamento.Value.Year.ToString() + " ?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int durata = (int)_view.numericUpDownDurataProgressi.Value;
                int peso = (int)_view.numericUpDownPesoProgressi.Value == 0 ? _utente.PesoInKg : (int)_view.numericUpDownPesoProgressi.Value;
                DateTime data = _view.dateTimePickerDataAllenamento.Value;

                Allenamento allenamento = new Allenamento(durata, data, peso);
                try
                {
                    _mpm.SaveAllenamento(_utente, allenamento);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _allenamenti.Add(allenamento);
                _countAllenamenti++;


                _view.chartDurata.DataSource = null;
                _view.chartDurata.DataSource = _allenamenti;
                _view.chartDurata.DataBind();

                _view.chartPeso.DataSource = null;
                _view.chartPeso.DataSource = _allenamenti;
                _view.chartPeso.DataBind();



                if (_countAllenamenti % 10 == 0 && _utente is UtenteAutomatico)
                {                  
                       if (MessageBox.Show("Complimenti hai completato la scheda, puoi proseguire con la prossima scheda", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            PianoAllenamento newPianoAllenamento = _gpa.getOrUpdatePianoAllenamento((UtenteAutomatico)_utente, (List<Esercizio>)_mpm.LoadAllEsercizi());
                            _mpm.SavePianoAllenamento(_utente, newPianoAllenamento);
                        }
                        
                }

                _view.progressBarAllenamenti.Value = _countAllenamenti % 10;

                _view.labelContatore.Text = (_countAllenamenti).ToString();
                _view.circularProgressBar.Value = (_countAllenamenti % 10) * 10;
                _view.circularProgressBar.Text = ((_countAllenamenti % 10) * 10).ToString() + "%";
            }
        }

        private void CaricaAllenamenti(object sender, EventArgs e)
        {
            try
            {
                _allenamenti = (List<Allenamento>)_mpm.LoadAllAllenamenti(_utente);
                _countAllenamenti = _allenamenti.Count;
            }
            catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _view.chartDurata.DataSource = _allenamenti;
            _view.chartDurata.Series["Durata"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            _view.chartDurata.Series["Durata"].XValueMember = "data";
            _view.chartDurata.Series["Durata"].YValueMembers = "durataInMinuti";
            _view.chartDurata.DataBind();

            _view.chartPeso.DataSource = _allenamenti;
            _view.chartPeso.Series["Peso"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            _view.chartPeso.Series["Peso"].XValueMember = "data";
            _view.chartPeso.Series["Peso"].YValueMembers = "pesoInKg";
            _view.chartPeso.DataBind();

            _view.progressBarAllenamenti.Value = _countAllenamenti % 10;
            _view.labelContatore.Text = (_countAllenamenti).ToString();

            _view.circularProgressBar.Value = (_countAllenamenti % 10) * 10;
            _view.circularProgressBar.Text = ((_countAllenamenti % 10) * 10).ToString() + "%";
        }
    }
}
