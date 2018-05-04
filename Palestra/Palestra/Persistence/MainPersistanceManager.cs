using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Palestra.model;

namespace Palestra.Persistence
{
    class MainPersistanceManager : IAllenamentoPersistenceManager, IEsercizioPersistanceManager, IPianoAllenamentoPersistenceManager, IUtentePersistenceManager
    {
        private List<Esercizio> _esercizi;

        public MainPersistanceManager()
        {
            _esercizi = new List<Esercizio>();
            _esercizi.Add(new Esercizio("Panca piana", FasciaMuscolare.Petto));
            _esercizi.Add(new Esercizio("Distensioni", FasciaMuscolare.Petto));
            //mettere tutti gli esercizi nella lista
        }

        public Utente Autentica(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllenamento(Allenamento allenamento)
        {
            throw new NotImplementedException();
        }

        public bool DeletePianoAllenamento(PianoAllenamento pianoAllenamento)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUtente(Utente utente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Allenamento> GetAllAllenamenti()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Esercizio> GetAllEsercizi()
        {
            return _esercizi;
        }

        public PianoAllenamento GetPianoAllenamento()
        {
            throw new NotImplementedException();
        }

        public Utente GetUtente()
        {
            throw new NotImplementedException();
        }

        public bool SaveAllenamento(Allenamento allenamento)
        {
            throw new NotImplementedException();
        }

        public bool SavePianoAllenamento(PianoAllenamento pianoAllenamento)
        {
            throw new NotImplementedException();
        }

        public bool SaveUtente(Utente utente)
        {
            throw new NotImplementedException();
        }
    }
}
