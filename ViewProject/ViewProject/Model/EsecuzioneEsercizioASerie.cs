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
            if (esercizio == null || tempoDiRecuperoInSec <= 0 || numeroRipetizioni <= 0 || numeroSerie <= 0 || carico <= 0)
                throw new ArgumentException();
            _tempoDiRecuperoInSec = tempoDiRecuperoInSec;
            _numeroRipetizioni = numeroRipetizioni;
            _numeroSerie = numeroSerie;
            _carico = carico;
        }

        public EsecuzioneEsercizioASerie(Esercizio esercizio, int tempoDiRecuperoInSec, int numeroRipetizioni, int numeroSerie) : base(esercizio)
        {
            if (esercizio == null || tempoDiRecuperoInSec <= 0 || numeroRipetizioni <= 0 || numeroSerie <= 0)
                throw new ArgumentException();
            TempoDiRecuperoInSec = tempoDiRecuperoInSec;
            NumeroRipetizioni = numeroRipetizioni;
            NumeroSerie = numeroSerie;
            _carico = 0;
        }

        public int NumeroRipetizioni
        {
            get => _numeroRipetizioni;
            set
            {
                if(value <= 0)
                    throw new ArgumentException();
                _numeroRipetizioni = value;
            }
        }
        public int NumeroSerie
        {
            get => _numeroSerie;
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _numeroSerie = value;
            }
        }
        public int Carico
        {
            get => _carico;
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _carico = value;
            }
        }
        public int TempoDiRecuperoInSec
        {
            get => _tempoDiRecuperoInSec;
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _tempoDiRecuperoInSec = value;
            }
        }

        public override bool Equals(object obj)
        {
            var serie = obj as EsecuzioneEsercizioASerie;
            if (serie == null) return false;
            else if (_carico > 0 && serie.Carico > 0)
                return base.Equals(serie) &&
                   _tempoDiRecuperoInSec == serie.TempoDiRecuperoInSec &&
                   _numeroRipetizioni == serie.NumeroRipetizioni &&
                   _numeroSerie == serie.NumeroSerie &&
                   _carico == serie.Carico;
            else if (_carico > 0 && serie.Carico == 0) return false;
            else if (_carico == 0 && serie.Carico > 0) return false;
            else
                return base.Equals(serie) &&
                   _tempoDiRecuperoInSec == serie.TempoDiRecuperoInSec &&
                   _numeroRipetizioni == serie.NumeroRipetizioni &&
                   _numeroSerie == serie.NumeroSerie;
        }

        public override string ToString()
        {
            if (_carico > 0)
                return base.ToString() + " " +
                   _numeroSerie + "x" + _numeroRipetizioni +
                   " " + _tempoDiRecuperoInSec + " minuti di recupero " + "con " + _carico + " Kg di carico";
            else
                return base.ToString() + " " +
                  _numeroSerie + "x" + _numeroRipetizioni +
                  " " + _tempoDiRecuperoInSec + " secondi di recupero";
        }
    }
}
