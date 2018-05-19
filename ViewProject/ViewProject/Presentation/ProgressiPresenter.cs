using ViewProject.model;
using ViewProject.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Presentation
{
    public class ProgressiPresenter
    {
        private MainPersistanceManager _mpm;
        private ProgressiView _view;
        private Utente _utente;
        private List<Allenamento> _allenamenti;

        public ProgressiPresenter(MainPersistanceManager mpm, ProgressiView view, Utente utente)
        {
            _mpm = mpm;
            _view = view;
            _utente = utente;

            _view.Load += OnLoad;
            _view.buttonSalvaAllenamentoProgressi.Click += Click_SalvaAllenamento;
        }

        private void Click_SalvaAllenamento(object sender, EventArgs e)
        {
            int durata = (int)_view.numericUpDownDurataProgressi.Value;
            int peso = (int)_view.numericUpDownPesoProgressi.Value == 0 ? _utente.PesoInKg : (int)_view.numericUpDownPesoProgressi.Value;
            DateTime data = _view.dateTimePickerDataAllenamento.Value;

            Allenamento allenamento = new Allenamento(durata, data, peso);
            _mpm.SaveAllenamento(_utente, allenamento);
            _allenamenti.Add(allenamento);


            _view.chartDurata.DataSource = null;
            _view.chartDurata.DataSource = _allenamenti;
            _view.chartDurata.DataBind();

            _view.chartPeso.DataSource = null;
            _view.chartPeso.DataSource = _allenamenti;
            _view.chartPeso.DataBind();

            _view.progressBarAllenamenti.Value = _allenamenti.Count;
            _view.labelContatore.Text = (_allenamenti.Count).ToString();

            _view.circularProgressBar.Value = _allenamenti.Count * 10;
            _view.circularProgressBar.Text = (_allenamenti.Count * 10).ToString() + "%";
        }

        private void OnLoad(object sender, EventArgs e)
        {

            _allenamenti =(List<Allenamento>) _mpm.LoadAllAllenamenti(_utente);

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

            _view.progressBarAllenamenti.Value = _allenamenti.Count;
            _view.labelContatore.Text = (_allenamenti.Count).ToString();

            _view.circularProgressBar.Value = _allenamenti.Count * 10;
            _view.circularProgressBar.Text = (_allenamenti.Count * 10).ToString() + "%";
        }
    }
}
