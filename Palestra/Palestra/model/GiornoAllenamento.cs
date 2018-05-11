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
        private List<EsecuzioneEsercizio> _listaEsecuzioneEsercizi;

        public GiornoAllenamento(int tempoDiRecuperoInSec)
        {
            _tempoDiRecuperoInSec = tempoDiRecuperoInSec;
            _listaEsecuzioneEsercizi = new List<EsecuzioneEsercizio>();
        }

        public void addEsecuzioneEsercizio(EsecuzioneEsercizio esecuzioneEsercizio)
        {
            ListaInsiemeSerie.Add(esecuzioneEsercizio);
        }

        public Boolean removeEsecuzioneEsercizio(EsecuzioneEsercizio insiemeSerie)
        {
            return ListaInsiemeSerie.Remove(insiemeSerie);
        }

        public int TempoDiRecuperoInSec { get => _tempoDiRecuperoInSec; set => _tempoDiRecuperoInSec = value; }
        public List<EsecuzioneEsercizio> ListaInsiemeSerie { get => _listaEsecuzioneEsercizi; }
    }
}
