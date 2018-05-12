using Palestra.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.Persistence
{
    public interface IPianoAllenamentoPersistenceManager
    {
        PianoAllenamento GetPianoAllenamento(Utente utente);
        bool SavePianoAllenamento(Utente utente , PianoAllenamento pianoAllenamento);
        bool DeletePianoAllenamento(Utente utente);

    }
}
