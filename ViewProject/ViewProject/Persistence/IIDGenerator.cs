using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.Persistence
{
    public interface IIDGenerator
    {
        int generaUtenteID();
        int generaAllenamentoID();
        int generaGiornoAllenamentoID();
        int generaEsecuzioneEsercizioID();
        void setIDs();
        void resetIDs();
    }
}
