using Palestra.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.Persistence
{
    public interface IUtentePersistenceManager
    {
        bool SaveUtente(Utente utente, string password);
        Utente Autentica(string username, string password);
        bool DeleteUtente(Utente utente);
    }
}
