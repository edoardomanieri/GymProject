using ViewProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.model
{
    public class EsecuzioneEsercizio : IPersistable
    {
        private Esercizio _esercizio;
        private int _ID;

        public EsecuzioneEsercizio(Esercizio esercizio)
        {
            if (esercizio == null)
                throw new ArgumentException();
            Esercizio = esercizio;
        }

        public Esercizio Esercizio { get => _esercizio; set => _esercizio = value ?? throw new ArgumentException();}
        public int ID { get => _ID; set => _ID = value; }

        public override bool Equals(object obj)
        {
            var esecuzioneEsercizio = obj as EsecuzioneEsercizio;
            return esecuzioneEsercizio != null &&
                   _esercizio.Equals(esecuzioneEsercizio.Esercizio);
        }

        public override string ToString()
        {
            return _esercizio.ToString();
        }
    }
}
