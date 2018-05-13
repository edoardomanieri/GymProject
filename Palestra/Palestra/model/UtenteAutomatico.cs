using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class UtenteAutomatico : Utente
    {

        private readonly Risorsa _risorse;
        private readonly int _numeroGiorniAllenamento;
        private readonly TipoAllenamento _tipo;

        public UtenteAutomatico(string nome, string cognome, DateTime dataDiNascita, int pesoInKg, int altezzaInCm,  Sesso sesso, Risorsa risorse, int numeroGiorniAllenamento, TipoAllenamento tipo) : base(nome, cognome,  dataDiNascita,  pesoInKg,  altezzaInCm, sesso)
        {
            _risorse = risorse;
            _numeroGiorniAllenamento = numeroGiorniAllenamento;
            _tipo = tipo;

        }

        public Risorsa Risorse => _risorse;

        public int NumeroGiorniAllenamento => _numeroGiorniAllenamento;

        public TipoAllenamento Tipo => _tipo;
    }
}