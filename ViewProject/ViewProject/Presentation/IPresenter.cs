using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Presentation
{
    public class IPresenter
    {
        private MainPersistanceManager _mpm;

        public IPresenter(MainPersistanceManager mpm)
        {
            _mpm = mpm;
        }
    }
}
