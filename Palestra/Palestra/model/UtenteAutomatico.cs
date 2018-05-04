using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public enum risorseDisponibili { salaPesi, corpoLibero }
    public class UtenteAutomatico : Utente
    {
        private readonly TipoAllenamento _tipo;
        private readonly risorseDisponibili _risorse;
        private readonly int _numeroAllenamentiSettimanali;
       

        public UtenteAutomatico(string nome, string cognome, DateTime dataDiNascita, int pesoInKg, int altezzaInCm, TipoAllenamento tipo, risorseDisponibili risorse, int numeroAllenamentiSettimanali) : base(nome, cognome,  dataDiNascita,  pesoInKg,  altezzaInCm)
        {
            _tipo = tipo;
            _risorse = risorse;
            _numeroAllenamentiSettimanali = numeroAllenamentiSettimanali;
        }

        public int NumeroAllenamentiSettimanali => _numeroAllenamentiSettimanali;

        public risorseDisponibili Risorse => _risorse;

        public TipoAllenamento Tipo => _tipo;
    }
}