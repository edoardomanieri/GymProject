using ViewProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Persistence
{
    public interface IEsercizioPersistanceManager
    {
        IEnumerable<Esercizio> LoadAllEsercizi();
    }
}
