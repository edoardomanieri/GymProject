using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class Serie
    {
        private int _numeroRipetizioni;
        private Esercizio esercizio;

        public Serie(int numeroRipetizioni, Esercizio esercizio)
        {
            _numeroRipetizioni = numeroRipetizioni;
            this.Esercizio = esercizio;
        }

        public Esercizio Esercizio { get => esercizio; set => esercizio = value; }
        public int NumeroRipetizioni { get => _numeroRipetizioni; set => _numeroRipetizioni = value; }


    }
}
