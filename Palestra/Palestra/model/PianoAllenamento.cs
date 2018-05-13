using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class PianoAllenamento
    {
        private List<GiornoAllenamento> _giorniAllenamento;
        private int _numeroGiorniAllenamento;


        public PianoAllenamento()
        {
            GiorniAllenamento = new List<GiornoAllenamento>();
            NumeroGiorniAllenamento = 0;
 
        }

        public int NumeroGiorniAllenamento { get => _numeroGiorniAllenamento; set => _numeroGiorniAllenamento = value; }
        public List<GiornoAllenamento> GiorniAllenamento { get => _giorniAllenamento; set => _giorniAllenamento = value; }

        public bool inserisciGiornoAllenamento(GiornoAllenamento giornoAllenamento)
        {
            if (NumeroGiorniAllenamento >= 7)
                return false;
            GiorniAllenamento.Add(giornoAllenamento);
            NumeroGiorniAllenamento++;
            return true;
        }

        public bool rimuoviGiornoAllenamento(GiornoAllenamento giornoAllenamento)
        {
            if (GiorniAllenamento.Remove(giornoAllenamento))
            {
                NumeroGiorniAllenamento--;
                return true;
            }
            return false;

        }
    }
}
