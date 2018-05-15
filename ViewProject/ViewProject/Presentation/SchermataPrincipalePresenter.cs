using Palestra.model;
using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Presentation
{
    public class SchermataPrincipalePresenter
    {
        MainPersistanceManager _mpm;
        SchermataPrincipaleView _schermataPrincipaleView;

        public SchermataPrincipalePresenter(MainPersistanceManager mpm, SchermataPrincipaleView schermataPrincipaleView)
        {
            _mpm = mpm;
            _schermataPrincipaleView = schermataPrincipaleView;

            _schermataPrincipaleView.panelSchermataPrincipale.Enter += OnLoad_SchermataPrincipale;
            _schermataPrincipaleView.buttonReset.Click += Click_ButtonReset;
        }

        private void Click_ButtonReset(object sender, EventArgs e)
        {
            Utente utente = _mpm.LoadUtente();
            _mpm.Reset(utente);
        }

        private void OnLoad_SchermataPrincipale(object sender, EventArgs e)
        {
            Utente utente = _mpm.LoadUtente();
            PianoAllenamento piano = _mpm.LoadPianoAllenamento(utente);

            //impostare tabella
        }
    }
}
