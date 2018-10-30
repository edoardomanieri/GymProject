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
        private static MainPresenter _instance = null;

        public static MainPresenter GetInstance()
        {
            if (_instance == null)
                throw new InvalidOperationException("MainPresenter instance not created !");
            return _instance;
        }

        public static MainPresenter Create(MainForm mainForm, SchermataAutenticazioneView schermataAutenticazioneView)
        {
            if (_instance != null)
                throw new InvalidOperationException("MainPresenter instance already created !");

            _instance = new MainPresenter(mainForm, schermataAutenticazioneView);
            return _instance;
        }


        private MainPresenter(MainForm mainForm, SchermataAutenticazioneView schermataAutenticazioneView)
        {
            _mpm = MainPersistanceManager.Instance;
            _gestorePianiAllenamento = GestorePianiAllenamento.Instance;
            CreatePresenters();
            _mainForm = mainForm;
            _schermataAutenticazioneView = schermataAutenticazioneView;
            _schermataAutenticazioneView.buttonAccedi.Click += Autentica;
            _schermataAutenticazioneView.buttonCreaAccount.Click += SetCreaAccountView;
            _creaAccountView = (CreaAccountView)ViewFactory.GetView("CreaAccountView");
            _creaAccountView.buttonProcedi.Click += SaveUtente;
            _creaAccountView.buttonShowHide1.Click += ShowConfirmPassword;
            _creaAccountView.buttonShowHide2.Click += ShowPassword;
            _creaAccountView.buttonIndietro.Click += SetSchermataAutenticazioneView;
            _mainForm.SetView(_schermataAutenticazioneView);
        }

        private void CreatePresenters()
        {
            UserControl view;

            view = ViewFactory.GetView("CreaSchedaAutomaticaView");
            CreaSchedaAutomaticaPresenter.Create(_mpm, (CreaSchedaAutomaticaView) view, _gestorePianiAllenamento);

            view = ViewFactory.GetView("SchermataPrincipaleView");
            SchermataPrincipalePresenter.Create(_mpm, (SchermataPrincipaleView)view);

            view = ViewFactory.GetView("CreaSchedaManualeView");
            CreaSchedaManualePresenter .Create(_mpm, (CreaSchedaManualeView)view);

            view = ViewFactory.GetView("ProgressiView");
            ProgressiPresenter.Create(_mpm, (ProgressiView)view, _gestorePianiAllenamento);

            view = ViewFactory.GetView("ProfiloView");
            ProfiloPresenter.Create(_mpm, (ProfiloView)view);

            view = ViewFactory.GetView("VideoView");
            VideoPresenter.Create(_mpm, (VideoView)view);


        }

        private void SetCreaAccountView(object sender, EventArgs e)
        {
            _mainForm.Controls.Clear();
            _mainForm.Controls.Add(_creaAccountView);
        }

        private void SetSchermataAutenticazioneView(object sender, EventArgs e)
        {
            UserControl view = (SchermataAutenticazioneView)ViewFactory.GetView("SchermataAutenticazioneView");
            _mainForm.SetView(view);
        }

        private void ShowPassword(object sender, EventArgs e)
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

        private void ShowConfirmPassword(object sender, EventArgs e)
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

        private void SaveUtente(object sender, EventArgs e)
        {
            if (!_creaAccountView.isCompleted() || !_creaAccountView.CheckPassword())
                return;
            try
            {
                if (_mpm.CheckUsername(_creaAccountView.textBoxUsername.Text))
                {
                    MessageBox.Show("Username già presente");
                    return;
                }
                Sesso sesso = _creaAccountView.RadioButtonFemmina.Checked ? Sesso.Femmina : Sesso.Maschio;
                _utente = new Utente(_creaAccountView.textBoxUsername.Text, _creaAccountView.TextBoxNome.Text, _creaAccountView.TextBoxCognome.Text,
                   new DateTime(int.Parse(_creaAccountView.comboBoxAnno.Text), int.Parse(_creaAccountView.comboBoxMese.Text),
                   int.Parse(_creaAccountView.comboBoxGiorno.Text)), (int)_creaAccountView.numericUpDownPeso.Value,
                   (int)_creaAccountView.numericUpDownAltezza.Value, sesso);

                //inseriamo l'utente nel DB
                _mpm.SaveUtente(_utente, _creaAccountView.CreaPassword.Text);

                if (_creaAccountView.checkBoxAutomatica.Checked)
                {
                    UserControl view = (CreaSchedaAutomaticaView)ViewFactory.GetView("CreaSchedaAutomaticaView");
                    CreaSchedaAutomaticaPresenter.GetInstance().Utente = _utente;
                    _mainForm.SetView(view);
                }
                else
                {
                    SetUtente();
                    CreaSchedaManualeView view = (CreaSchedaManualeView)ViewFactory.GetView("CreaSchedaManualeView");
                    view.buttonIndietro.Visible = false;
                    view.buttonIndietro.Enabled = false;
                    _mainForm.SetView(view);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void SetUtente()
        {
            CreaSchedaAutomaticaPresenter.GetInstance().Utente = _utente;
            CreaSchedaManualePresenter.GetInstance().Utente = _utente;
            ProfiloPresenter.GetInstance().Utente = _utente;
            ProgressiPresenter.GetInstance().Utente = _utente;
            SchermataPrincipalePresenter.GetInstance().Utente = _utente;
        }

        private void Autentica(object sender, EventArgs e)
        {
            string username = _schermataAutenticazioneView.textBoxUsername.Text;
            string password = _schermataAutenticazioneView.textBoxPassword.Text;
            try
            {
                _utente = _mpm.Autentica(username, password);
                SetUtente();
                UserControl view = ViewFactory.GetView("SchermataPrincipaleView");
                _mainForm.SetView(view);
            }
            catch (SqlException)
            {
                MessageBox.Show("Errore nel database: verificare la procedura d'installazione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
