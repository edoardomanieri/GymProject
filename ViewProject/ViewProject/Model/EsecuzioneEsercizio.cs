using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class EsecuzioneEsercizio : IPersistable
    {
        private Esercizio _esercizio;
        private int _ID;

        public EsecuzioneEsercizio(Esercizio esercizio)
        {
            Esercizio = esercizio;
        }

        public Esercizio Esercizio { get => _esercizio; set => _esercizio = value; }
        public int ID { get => _ID; set => _ID = value; }
    }
}
