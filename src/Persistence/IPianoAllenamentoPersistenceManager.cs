using ViewProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Persistence
{
    public interface IPianoAllenamentoPersistenceManager
    {
        PianoAllenamento LoadPianoAllenamento(Utente utente);
        void SavePianoAllenamento(Utente utente , PianoAllenamento pianoAllenamento);
        void DeletePianoAllenamento(Utente utente);

    }
}
