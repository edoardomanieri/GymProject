using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class GiornoAllenamento : IPersistable
    {
        public event EventHandler Changed;
        private int _tempoDiRecuperoInSec;
        private List<EsecuzioneEsercizio> _listaEsecuzioneEsercizi;
        private int _ID;

        public GiornoAllenamento(int tempoDiRecuperoInSec)
        {
            _tempoDiRecuperoInSec = tempoDiRecuperoInSec;
            _listaEsecuzioneEsercizi = new List<EsecuzioneEsercizio>();
        }

        public void addEsecuzioneEsercizio(EsecuzioneEsercizio esecuzioneEsercizio)
        {
            OnChanged();
            ListaEsecuzioniEsercizi.Add(esecuzioneEsercizio);
        }

        public Boolean removeEsecuzioneEsercizio(EsecuzioneEsercizio esecuzioneEsercizio)
        {
            OnChanged();
            return ListaEsecuzioniEsercizi.Remove(esecuzioneEsercizio);
        }

        private void OnChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }

        public int TempoDiRecuperoInSec { get => _tempoDiRecuperoInSec; set => _tempoDiRecuperoInSec = value; }
        public List<EsecuzioneEsercizio> ListaEsecuzioniEsercizi { get => _listaEsecuzioneEsercizi; }
        public int ID { get => _ID; set => _ID = value; }
    }
}
