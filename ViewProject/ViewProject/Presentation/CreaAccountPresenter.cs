using Palestra.model;
using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewProject;
using ViewProject.Presentation;

namespace Palestra.Presentation
{
    public class CreaAccountPresenter 
    {
        private MainPersistanceManager _mpm;
        private CreaAccountView _creaAccountView;

        public CreaAccountPresenter(MainPersistanceManager mpm, CreaAccountView creaAccountView)
        {
            mpm = _mpm;
            _creaAccountView = creaAccountView;


            _creaAccountView.buttonProcedi.Click += Click_buttonProcedi;
        }

        private void Click_buttonProcedi(object sender, EventArgs e)
        {
            if (!_creaAccountView.isCompleted())
                return;
            Sesso sesso = _creaAccountView.RadioButtonFemmina.Checked ? Sesso.Femmina : Sesso.Maschio;
            Utente utente = new Utente(_creaAccountView.TextBoxNome.Text, _creaAccountView.TextBoxCognome.Text, 
                new DateTime(int.Parse(_creaAccountView.comboBoxAnno.Text), int.Parse(_creaAccountView.comboBoxMese.Text), 
                int.Parse(_creaAccountView.comboBoxGiorno.Text)),(int) _creaAccountView.numericUpDownPeso.Value, 
                (int)_creaAccountView.numericUpDownAltezza.Value, sesso);

            //inseriamo l'utente nel DB
            _mpm.SaveUtente(utente);
        }
    }
}
