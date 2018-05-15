using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Presentation
{
    public class CreaSchedaAutomaticaPresenter
    {

        private MainPersistanceManager _mpm;
        private CreaSchedaAutomaticaView _creaSchedaAutomaticaView;

        public CreaSchedaAutomaticaPresenter(MainPersistanceManager mpm, CreaSchedaAutomaticaView creaSchedaAutomaticaView)
        {
            mpm = _mpm;
            _creaSchedaAutomaticaView = creaSchedaAutomaticaView;


            _creaSchedaAutomaticaView.buttonProcedi.Click += Click_buttonProcedi;
        }

        private void Click_buttonProcedi(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
