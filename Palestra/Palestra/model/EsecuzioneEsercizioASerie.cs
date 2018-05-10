using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class EsecuzioneEsercizioASerie : EsecuzioneEsercizio
    {
        private int _tempoDiRecuperoInSec;
        private int _numeroRipetizioni;
        private int _numeroSerie;
        private int _peso;

        public EsecuzioneEsercizioASerie(Esercizio esercizio, int tempoDiRecuperoInSec, int numeroRipetizioni, int numeroSerie, int peso) : base(esercizio)
        {
            TempoDiRecuperoInSec = tempoDiRecuperoInSec;
            NumeroRipetizioni = numeroRipetizioni;
            NumeroSerie = numeroSerie;
            Peso = peso;
        }

        public EsecuzioneEsercizioASerie(Esercizio esercizio, int tempoDiRecuperoInSec, int numeroRipetizioni, int numeroSerie) : base(esercizio)
        {
            TempoDiRecuperoInSec = tempoDiRecuperoInSec;
            NumeroRipetizioni = numeroRipetizioni;
            NumeroSerie = numeroSerie;
        }

        public int NumeroRipetizioni { get => _numeroRipetizioni; set => _numeroRipetizioni = value; }
        public int NumeroSerie { get => _numeroSerie; set => _numeroSerie = value; }
        public int Peso { get => _peso; set => _peso = value; }
        public int TempoDiRecuperoInSec { get => _tempoDiRecuperoInSec; set => _tempoDiRecuperoInSec = value; }
    }
}
