using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class EsecuzioneEsercizioATempo : EsecuzioneEsercizio
    {
        private int _tempo;

        public EsecuzioneEsercizioATempo(Esercizio esercizio, int tempo) : base(esercizio)
        {
            int _tempo = tempo;
        }

        public int Tempo { get => _tempo; set => _tempo = value; }
    }
}
