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
        private int _carico;

        public EsecuzioneEsercizioASerie(Esercizio esercizio, int tempoDiRecuperoInSec, int numeroRipetizioni, int numeroSerie, int carico) : base(esercizio)
        {
            TempoDiRecuperoInSec = tempoDiRecuperoInSec;
            NumeroRipetizioni = numeroRipetizioni;
            NumeroSerie = numeroSerie;
            Carico = carico;
        }

        public EsecuzioneEsercizioASerie(Esercizio esercizio, int tempoDiRecuperoInSec, int numeroRipetizioni, int numeroSerie) : base(esercizio)
        {
            TempoDiRecuperoInSec = tempoDiRecuperoInSec;
            NumeroRipetizioni = numeroRipetizioni;
            NumeroSerie = numeroSerie;
        }

        public int NumeroRipetizioni { get => _numeroRipetizioni; set => _numeroRipetizioni = value; }
        public int NumeroSerie { get => _numeroSerie; set => _numeroSerie = value; }
        public int Carico { get => _carico; set => _carico = value; }
        public int TempoDiRecuperoInSec { get => _tempoDiRecuperoInSec; set => _tempoDiRecuperoInSec = value; }
    }
}
