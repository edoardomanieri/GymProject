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
            if (tempo <= 0)
                throw new ArgumentException();
            _tempo = tempo;
        }

        public int Tempo
        {
            get => _tempo;
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _tempo = value;
            }
        }

        public override bool Equals(object obj)
        {
            var tempo = obj as EsecuzioneEsercizioATempo;
            return base.Equals(tempo) &&
                   _tempo == tempo.Tempo;
        }

        public override string ToString()
        {
            return base.ToString() +
                " per " + _tempo + " min";
        }
    }
}
