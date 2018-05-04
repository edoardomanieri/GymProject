using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    class UtenteManuale : Utente
    {
        public UtenteManuale(string nome, string cognome, DateTime dataDiNascita, int pesoInKg, int altezzaInCm) : base(nome, cognome, dataDiNascita, pesoInKg, altezzaInCm)
        {}
    }
}
