using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    class Serie
    {
        private uint _numeroRipetizioni;
        private Esercizio esercizio;

        public Serie(uint numeroRipetizioni, Esercizio esercizio)
        {
            _numeroRipetizioni = numeroRipetizioni;
            this.Esercizio = esercizio;
        }

        public Esercizio Esercizio { get => esercizio; set => esercizio = value; }
        public uint NumeroRipetizioni { get => _numeroRipetizioni; set => _numeroRipetizioni = value; }


    }
}
