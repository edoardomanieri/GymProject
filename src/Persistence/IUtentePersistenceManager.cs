using ViewProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Persistence
{
    public interface IUtentePersistenceManager
    {
        void SaveUtente(Utente utente, string password);
        Utente Autentica(string username, string password);
        void DeleteUtente(Utente utente);
    }
}
