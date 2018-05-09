using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class InsiemeSerie
    {
        private int _tempoDiRecuperoInSec;
        private int _numeroRipetizioni;
        private int _numeroSerie;
        private Esercizio _esercizio;
        private int _peso;

        public InsiemeSerie(int tempoDiRecuperoInSec, int numeroRipetizioni, int numeroSerie, Esercizio esercizio)
        {
            TempoDiRecuperoInSec = tempoDiRecuperoInSec;
            NumeroRipetizioni = numeroRipetizioni;
            NumeroSerie = numeroSerie;
            Esercizio = esercizio;
        }

        public int TempoDiRecuperoInSec { get => _tempoDiRecuperoInSec; set => _tempoDiRecuperoInSec = value; }
        public int NumeroRipetizioni { get => _numeroRipetizioni; set => _numeroRipetizioni = value; }
        public int NumeroSerie { get => _numeroSerie; set => _numeroSerie = value; }
        public Esercizio Esercizio { get => _esercizio; set => _esercizio = value; }
        public int Peso { get => _peso; set => _peso = value; }
    }
}
