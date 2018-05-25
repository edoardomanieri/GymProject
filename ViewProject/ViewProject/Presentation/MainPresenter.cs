using ViewProject.model;
using ViewProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewProject.View;
using System.Data.SqlClient;

namespace ViewProject.Presentation
{
    public class MainPresenter
    {
        private MainPersistanceManager _mpm;
        private SchermataAutenticazioneView _schermataAutenticazioneView;
        private CreaAccountView _creaAccountView;
        private MainForm _mainForm;
        private Utente _utente;
        private GestorePianiAllenamento _gestorePianiAllenamento;

        public MainPresenter(MainForm mainForm, SchermataAutenticazioneView schermataAutenticazioneView)
        {
            _mpm = MainPersistanceManager.Instance;
            _gestorePianiAllenamento = GestorePianiAllenamento.Instance;
            _mainForm = mainForm;
            _schermataAutenticazioneView = schermataAutenticazioneView;
            _schermataAutenticazioneView.buttonAccedi.Click += OnAccesso;
            _schermataAutenticazioneView.buttonCreaAccount.Click += OnCreaAccount;
            _mainForm.SetView(_schermataAutenticazioneView);

        }

        private void OnCreaAccount(object sender, EventArgs e)
        {
            _creaAccountView = (CreaAccountView)ViewFactory.GetView("CreaAccountView");
            _creaAccountView.buttonProcedi.Click += Click_ButtonProcedi;
            _mainForm.SetView(_creaAccountView);
            _creaAccountView.buttonShowHide1.Click += Click_ButtonHide1;
            _creaAccountView.buttonShowHide2.Click += Click_ButtonHide2;
            _creaAccountView.buttonIndietro.Click += Click_ButtonIndietroCreaAccount;
        }

        private void Click_ButtonIndietroCreaAccount(object sender, EventArgs e)
        {
            UserControl view = (SchermataAutenticazioneView)ViewFactory.GetView("SchermataAutenticazioneView");
            _mainForm.SetView(view);
        }

        private void Click_ButtonHide2(object sender, EventArgs e)
        {
            if (_creaAccountView.ConfirmPassword.UseSystemPasswordChar)
            {
                _creaAccountView.ConfirmPassword.UseSystemPasswordChar = false;
                _creaAccountView.buttonShowHide2.Image = _creaAccountView.imageHidePassword.Image;
            }
            else
            {
                _creaAccountView.ConfirmPassword.UseSystemPasswordChar = true;
                _creaAccountView.buttonShowHide2.Image = _creaAccountView.imageShowPassword.Image;
            }
        }

        private void Click_ButtonHide1(object sender, EventArgs e)
        {
            if (_creaAccountView.CreaPassword.UseSystemPasswordChar)
            {
                _creaAccountView.CreaPassword.UseSystemPasswordChar = false;
                _creaAccountView.buttonShowHide1.Image = _creaAccountView.imageHidePassword.Image;

            }
            else
            {
                _creaAccountView.CreaPassword.UseSystemPasswordChar = true;
                _creaAccountView.buttonShowHide1.Image = _creaAccountView.imageShowPassword.Image;
            }
        }

        private void Click_ButtonProcedi(object sender, EventArgs e)
        {
            if (!_creaAccountView.isCompleted() || !_creaAccountView.CheckPassword())
                return;
            Sesso sesso = _creaAccountView.RadioButtonFemmina.Checked ? Sesso.Femmina : Sesso.Maschio;
            _utente = new Utente(_creaAccountView.textBoxUsername.Text, _creaAccountView.TextBoxNome.Text, _creaAccountView.TextBoxCognome.Text,
               new DateTime(int.Parse(_creaAccountView.comboBoxAnno.Text), int.Parse(_creaAccountView.comboBoxMese.Text),
               int.Parse(_creaAccountView.comboBoxGiorno.Text)), (int)_creaAccountView.numericUpDownPeso.Value,
               (int)_creaAccountView.numericUpDownAltezza.Value, sesso);

            //inseriamo l'utente nel DB
            try
            {
                _mpm.SaveUtente(_utente, _creaAccountView.CreaPassword.Text);
            }catch(SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (!_creaAccountView.isCompleted())
            {
                // show dialog inserire tutti i paramentri
            }
            if (_creaAccountView.checkBoxAutomatica.Checked)
            {
                UserControl view = (CreaSchedaAutomaticaView)ViewFactory.GetView("CreaSchedaAutomaticaView");
                CreaSchedaAutomaticaPresenter creaSchedaAutomaticaPresenter = new CreaSchedaAutomaticaPresenter(_mpm, (CreaSchedaAutomaticaView)view, _utente, _gestorePianiAllenamento);
                _mainForm.SetView(view);
            }
            else
            {
                AvviaViewsEPresenter();
                CreaSchedaManualeView view = (CreaSchedaManualeView)ViewFactory.GetView("CreaSchedaManualeView");
                view.buttonIndietro.Visible = false;
                view.buttonIndietro.Enabled = false;
                _mainForm.SetView(view);
            }

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

        private void OnAccesso(object sender, EventArgs e)
        {
            string username = _schermataAutenticazioneView.textBoxUsername.Text;
            string password = _schermataAutenticazioneView.textBoxPassword.Text;
            try
            {
                _utente = _mpm.Autentica(username, password);
                AvviaViewsEPresenter();
                UserControl view = ViewFactory.GetView("SchermataPrincipaleView");
                _mainForm.SetView(view);
            }
            catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
