using ViewProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Persistence
{
    public interface IAllenamentoPersistenceManager
    {
        IEnumerable<Allenamento> LoadAllAllenamenti(Utente utente);
        void SaveAllenamento(Utente utente, Allenamento allenamento);
        void DeleteAllenamenti(Utente utente);
    }
}
