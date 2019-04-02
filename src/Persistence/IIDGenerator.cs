using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Persistence
{
    public interface IIDGenerator
    {
        int generaAllenamentoID();
        int generaGiornoAllenamentoID();
        int generaEsecuzioneEsercizioID();
        void resetIDs();
    }
}
