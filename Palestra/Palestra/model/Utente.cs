using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class Utente
    {
        private readonly string _nome;
        private readonly string _cognome;
        private readonly DateTime _dataDiNascita;
        private readonly int _pesoInKg;
        private readonly int _altezzaInCm;

        protected Utente(string nome, string cognome, DateTime dataDiNascita, int pesoInKg, int altezzaInCm)
        {
            _nome = nome;
            _cognome = cognome;
            _dataDiNascita = dataDiNascita;
            _pesoInKg = pesoInKg;
            _altezzaInCm = altezzaInCm;
        }

        public string Nome => _nome;

        public string Cognome => _cognome;

        public DateTime DataDiNascita => _dataDiNascita;

        public int PesoInKg => _pesoInKg;

        public int AltezzaInCm => _altezzaInCm;
    }
}
