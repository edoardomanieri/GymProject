using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.Presentation
{
    public class MainPresenter
    {
        private MainPersistanceManager _mainPersistanceManager;
        //view;

        public MainPresenter(MainPersistanceManager mainPersistanceManager)
        {
            _mainPersistanceManager = mainPersistanceManager;
            
        }
    }
}
