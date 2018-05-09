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
        private readonly Sesso _sesso;

        protected Utente(string nome, string cognome, DateTime dataDiNascita, int pesoInKg, int altezzaInCm, Sesso sesso)
        {
            _nome = nome;
            _cognome = cognome;
            _dataDiNascita = dataDiNascita;
            _pesoInKg = pesoInKg;
            _altezzaInCm = altezzaInCm;
            _sesso = sesso;
        }

        public string Nome => _nome;

        public string Cognome => _cognome;

        public DateTime DataDiNascita => _dataDiNascita;

        public int PesoInKg => _pesoInKg;

        public int AltezzaInCm => _altezzaInCm;

        public Sesso Sesso => _sesso;
    }
}
