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
        PianoAllenamento GetPianoAllenamento();
        bool SavePianoAllenamento(PianoAllenamento pianoAllenamento);
        bool DeletePianoAllenamento(PianoAllenamento pianoAllenamento);

    }
}
