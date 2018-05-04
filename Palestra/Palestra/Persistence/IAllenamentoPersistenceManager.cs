using Palestra.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.Persistence
{
    public interface IAllenamentoPersistenceManager
    {
        IEnumerable<Allenamento> GetAllAllenamenti();
        bool SaveAllenamento(Allenamento allenamento);
        bool DeleteAllenamento(Allenamento allenamento);
    }
}
