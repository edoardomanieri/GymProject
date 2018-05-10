using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class GiornoAllenamento
    {
        private int _tempoDiRecuperoInSec;
        private List<EsecuzioneEsercizio> _listaInsiemeSerie;

        public GiornoAllenamento(int tempoDiRecuperoInSec)
        {
            _tempoDiRecuperoInSec = tempoDiRecuperoInSec;
            _listaInsiemeSerie = new List<EsecuzioneEsercizio>();
        }

        public void addInsiemeSerie(EsecuzioneEsercizio insiemeSerie)
        {
            ListaInsiemeSerie.Add(insiemeSerie);
        }

        public Boolean removeInsiemeSerie(EsecuzioneEsercizio insiemeSerie)
        {
            return ListaInsiemeSerie.Remove(insiemeSerie);
        }

        public int TempoDiRecuperoInSec { get => _tempoDiRecuperoInSec; set => _tempoDiRecuperoInSec = value; }
        public List<EsecuzioneEsercizio> ListaInsiemeSerie { get => _listaInsiemeSerie; }
    }
}
