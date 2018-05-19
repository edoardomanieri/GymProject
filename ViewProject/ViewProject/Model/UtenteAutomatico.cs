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

        public UtenteAutomatico(string username, string nome, string cognome, DateTime dataDiNascita, int pesoInKg, int altezzaInCm,  Sesso sesso, Risorsa risorse, int numeroGiorniAllenamento, TipoAllenamento tipo) : base(username, nome, cognome,  dataDiNascita,  pesoInKg,  altezzaInCm, sesso)
        {
            if (numeroGiorniAllenamento < 0 || numeroGiorniAllenamento > 7)
                throw new ArgumentException();
            _risorse = risorse;
            _numeroGiorniAllenamento = numeroGiorniAllenamento;
            _tipo = tipo;

        }

        public Risorsa Risorse => _risorse;

        public int NumeroGiorniAllenamento => _numeroGiorniAllenamento;

        public TipoAllenamento Tipo => _tipo;

        public override bool Equals(object obj)
        {
            var automatico = obj as UtenteAutomatico;
            return automatico != null &&
                   base.Equals(automatico) &&
                   _risorse == automatico.Risorse &&
                   _numeroGiorniAllenamento == automatico.NumeroGiorniAllenamento &&
                   _tipo == automatico.Tipo;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nRisorse disponibili: " + _risorse.ToString() +
                "\nTipo d'allenamento: " + _tipo.ToString() +
                "\nNumero giorni d'allenamento: " + _numeroGiorniAllenamento.ToString();
        }
    }
}