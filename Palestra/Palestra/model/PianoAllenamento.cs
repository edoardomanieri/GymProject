using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Palestra.model.TipoAllenamentoEnum;

namespace Palestra.model
{
    class PianoAllenamento
    {
        private List<GiornoAllenamento> _giorniAllenamento;
        private uint _numeroGiorniAllenamento;
        private TipoAllenamento _tipoAllenamento;

        public PianoAllenamento(TipoAllenamento tipoAllenamento)
        {
            GiorniAllenamento = new List<GiornoAllenamento>();
            NumeroGiorniAllenamento = 0;
            TipoAllenamento = tipoAllenamento;
        }

        public uint NumeroGiorniAllenamento { get => _numeroGiorniAllenamento; set => _numeroGiorniAllenamento = value; }
        internal List<GiornoAllenamento> GiorniAllenamento { get => _giorniAllenamento; set => _giorniAllenamento = value; }
        internal TipoAllenamento TipoAllenamento { get => _tipoAllenamento; set => _tipoAllenamento = value; }

        public Boolean inserisciGiornoAllenamento(GiornoAllenamento giornoAllenamento)
        {
            if (NumeroGiorniAllenamento >= 7)
                return false;
            GiorniAllenamento.Add(giornoAllenamento);
            NumeroGiorniAllenamento++;
            return true;
        }

        public Boolean rimuoviGiornoAllenamento(GiornoAllenamento giornoAllenamento)
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
