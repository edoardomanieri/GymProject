using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class EsecuzioneEsercizio
    {
        private Esercizio _esercizio;

        public EsecuzioneEsercizio(Esercizio esercizio)
        {
            Esercizio = esercizio;
        }

        public Esercizio Esercizio { get => _esercizio; set => _esercizio = value; }

    }
}
