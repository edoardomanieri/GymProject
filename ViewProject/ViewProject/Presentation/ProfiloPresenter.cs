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
    public class ProfiloPresenter
    {
        private MainPersistanceManager _mpm;
        private ProfiloView _view;
        private Utente _utente;

        public ProfiloPresenter(MainPersistanceManager mpm, ProfiloView view, Utente utente)
        {
            _mpm = mpm;
            _view = view;
            _utente = utente;

            _view.Load += OnLoad;
            _view.buttonModifica.Click += Click_ModificaDati;
            _view.buttonSalva.Click += Click_SalvaDati;
            _view.buttonCaricaFoto.Click += Click_CaricaFoto;
            _view.buttonRimuoviFoto.Click += Click_RimuoviFoto;
            _view.buttonIndietroProfilo.Click += Click_ButtonIndietro;
        }

        private void Click_ButtonIndietro(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)_view.FindForm();
            UserControl view = (SchermataPrincipaleView)ViewFactory.GetView("SchermataPrincipaleView");
            mainForm.SetView(view);
        }

        private void Click_RimuoviFoto(object sender, EventArgs e)
        {
            _utente.FotoPath = default(string);
            _view.pictureBoxFoto.BackgroundImage = null;
            _view.pictureBoxFoto.ImageLocation = default(string);

        }

        private void Click_CaricaFoto(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    _view.pictureBoxFoto.BackgroundImage = null;
                    _view.pictureBoxFoto.ImageLocation = imageLocation;
                    _utente.FotoPath = imageLocation;
                    try
                    {
                        _mpm.updateUtente(_utente);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errore", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Click_SalvaDati(object sender, EventArgs e)
        {
            if (!isCompleted())
            {
                MessageBox.Show("Inserire tutti i dati prima di salvare!");
                return;
            }
            _utente.Nome += _view.TextBoxNome.Text;
            _utente.Cognome = _view.TextBoxCognome.Text;
            _utente.DataDiNascita = new DateTime(int.Parse(_view.comboBoxAnno.Text), int.Parse(_view.comboBoxMese.Text), int.Parse(_view.comboBoxGiorno.Text));
            _utente.AltezzaInCm = (int)_view.numericUpDownAltezza.Value;
            _utente.PesoInKg = (int)_view.numericUpDownPeso.Value;
            if (_view.RadioButtonMaschio.Checked)
                _utente.Sesso = Sesso.Maschio;
            else
                _utente.Sesso = Sesso.Femmina;

            {
                try
                {
                    _mpm.updateUtente(_utente);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _view.TextBoxCognome.ReadOnly = true;
            _view.TextBoxNome.ReadOnly = true;
            _view.comboBoxGiorno.Enabled = false;
            _view.comboBoxMese.Enabled = false;
            _view.comboBoxAnno.Enabled = false;
            _view.RadioButtonMaschio.Enabled = false;
            _view.RadioButtonFemmina.Enabled = false;
            _view.numericUpDownPeso.Enabled = false;
            _view.numericUpDownAltezza.Enabled = false;
            
        }

        private void Click_ModificaDati(object sender, EventArgs e)
        {
            _view.TextBoxCognome.ReadOnly = false;
            _view.TextBoxNome.ReadOnly = false;
            _view.comboBoxGiorno.Enabled = true;
            _view.comboBoxMese.Enabled = true;
            _view.comboBoxAnno.Enabled = true;
            _view.RadioButtonMaschio.Enabled = true;
            _view.RadioButtonFemmina.Enabled = true;
            _view.numericUpDownPeso.Enabled = true;
            _view.numericUpDownAltezza.Enabled = true;

        }

        private bool isCompleted()
        {
            return !(string.IsNullOrEmpty(_view.TextBoxCognome.Text) ||
                string.IsNullOrEmpty(_view.TextBoxNome.Text) ||
                string.IsNullOrEmpty(_view.comboBoxAnno.Text) ||
                string.IsNullOrEmpty(_view.comboBoxGiorno.Text) ||
                string.IsNullOrEmpty(_view.comboBoxMese.Text));
        }

        private void OnLoad(object sender, EventArgs e)
        {

            _view.TextBoxNome.Text = _utente.Nome;
            _view.TextBoxCognome.Text = _utente.Cognome;
            _view.comboBoxGiorno.Text = _utente.DataDiNascita.Day.ToString();
            _view.comboBoxMese.Text = _utente.DataDiNascita.Month.ToString();
            _view.comboBoxAnno.Text = _utente.DataDiNascita.Year.ToString();
            if (_utente.Sesso.Equals(Sesso.Maschio))
                _view.RadioButtonMaschio.Checked = true;
            else
                _view.RadioButtonFemmina.Checked = false;
            _view.numericUpDownPeso.Value = _utente.PesoInKg;
            _view.numericUpDownAltezza.Value = _utente.AltezzaInCm;

            _view.TextBoxCognome.ReadOnly = true;
            _view.TextBoxNome.ReadOnly = true;
            _view.comboBoxGiorno.Enabled = false;
            _view.comboBoxMese.Enabled = false;
            _view.comboBoxAnno.Enabled = false;
            _view.RadioButtonMaschio.Enabled = false;
            _view.RadioButtonFemmina.Enabled = false;
            _view.numericUpDownPeso.Enabled = false;
            _view.numericUpDownAltezza.Enabled = false;
            if (_utente.FotoPath != default(string))
            {
                _view.pictureBoxFoto.BackgroundImage = null;
                _view.pictureBoxFoto.ImageLocation = _utente.FotoPath;

            }
        }


    }
}
