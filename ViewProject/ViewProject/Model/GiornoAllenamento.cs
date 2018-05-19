using ViewProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.model
{
    public class GiornoAllenamento : IPersistable
    {
        public event EventHandler Changed;
        private int _tempoDiRecuperoInSec;
        private List<EsecuzioneEsercizio> _listaEsecuzioneEsercizi;
        private int _ID;

        public GiornoAllenamento()
        {
            _listaEsecuzioneEsercizi = new List<EsecuzioneEsercizio>();
        }
        public GiornoAllenamento(int tempoDiRecuperoInSec)
        {
            if (tempoDiRecuperoInSec <= 0)
                throw new ArgumentException();
            _tempoDiRecuperoInSec = tempoDiRecuperoInSec;
            _listaEsecuzioneEsercizi = new List<EsecuzioneEsercizio>();
        }

        public void addEsecuzioneEsercizio(EsecuzioneEsercizio esecuzioneEsercizio)
        {
            if (esecuzioneEsercizio == null)
                throw new ArgumentException();
            _listaEsecuzioneEsercizi.Add(esecuzioneEsercizio);
            OnChanged();
        }

        public bool removeEsecuzioneEsercizio(EsecuzioneEsercizio esecuzioneEsercizio)
        {
            if (esecuzioneEsercizio == null)
                throw new ArgumentException();
            OnChanged();
            return _listaEsecuzioneEsercizi.Remove(esecuzioneEsercizio);
        }

        private void OnChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty);
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
        public List<EsecuzioneEsercizio> ListaEsecuzioniEsercizi { get => _listaEsecuzioneEsercizi; }
        public int ID { get => _ID; set => _ID = value; }
        public override bool Equals(object obj)
        {
            var giornoAllenamento = obj as GiornoAllenamento;
            bool controlloEsecuzioni = true;
            if (giornoAllenamento != null)
            {
                if (giornoAllenamento.ListaEsecuzioniEsercizi.Count == _listaEsecuzioneEsercizi.Count)
                {
                    for (int i = 0; i < _listaEsecuzioneEsercizi.Count; i++)
                    {
                        if (!_listaEsecuzioneEsercizi[i].Equals(giornoAllenamento.ListaEsecuzioniEsercizi[i]))
                            controlloEsecuzioni = false;
                    }
                }
                else
                    controlloEsecuzioni = false;
            }
            else
                controlloEsecuzioni = false;
            return _tempoDiRecuperoInSec == giornoAllenamento.TempoDiRecuperoInSec && controlloEsecuzioni;
        }

        public override string ToString()
        {
            string result = "";
            foreach (EsecuzioneEsercizio esecuzioneCorrente in _listaEsecuzioneEsercizi)
                result = result + esecuzioneCorrente.ToString() + "\n";
            return result;
        }
    }
}
