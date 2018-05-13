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
        Utente Autentica(string username, string password);
        bool SaveUtente(Utente utente);
        Utente LoadUtente();
        bool DeleteUtente(Utente utente);
    }
}
