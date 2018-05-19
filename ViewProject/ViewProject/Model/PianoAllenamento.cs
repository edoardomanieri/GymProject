using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class PianoAllenamento
    {
        public event EventHandler Changed;
        private List<GiornoAllenamento> _giorniAllenamento;
        private int _numeroGiorniAllenamento;


        public PianoAllenamento()
        {
            _giorniAllenamento = new List<GiornoAllenamento>();
            _numeroGiorniAllenamento = 0;
 
        }

        public int NumeroGiorniAllenamento { get => _numeroGiorniAllenamento; }
        public List<GiornoAllenamento> GiorniAllenamento { get => _giorniAllenamento; }

        public bool addGiornoAllenamento(GiornoAllenamento giornoAllenamento)
        {
            if (NumeroGiorniAllenamento >= 7)
                return false;
            _giorniAllenamento.Add(giornoAllenamento);
            _numeroGiorniAllenamento++;
            OnChanged();
            return true;
        }

        public bool addOrUpdateGiornoAllenamento(GiornoAllenamento giornoAllenamento, int index)
        {
            bool result = false;
            if (index < 0)
                throw new ArgumentException();
            if (index == _giorniAllenamento.Count)
                result = addGiornoAllenamento(giornoAllenamento);
            if (index >= 0 && index < _giorniAllenamento.Count)
            {
                _giorniAllenamento[index] = giornoAllenamento;
                result = true;
            }
            return result;
        }

        public bool removeGiornoAllenamento(GiornoAllenamento giornoAllenamento)
        {
            if (_giorniAllenamento.Remove(giornoAllenamento))
            {
                _numeroGiorniAllenamento--;
                OnChanged();
                return true;
            }
            return false;

        }

        private void OnChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }

        public override bool Equals(object obj)
        {
            var piano = obj as PianoAllenamento;
            bool controlloGiorni = true;
            if (piano != null)
            {
                if (_giorniAllenamento.Count == piano.GiorniAllenamento.Count)
                {
                    for(int i=0; i<_giorniAllenamento.Count; i++)
                    {
                        if(!_giorniAllenamento[i].Equals(piano.GiorniAllenamento[i]))
                            controlloGiorni = false;
                    }
                }
                else
                    controlloGiorni = false;
            }
            else
                controlloGiorni = false;
            return controlloGiorni &&
                   _numeroGiorniAllenamento == piano.NumeroGiorniAllenamento;
        }

        public override string ToString()
        {
            string result = "";
            for(int i=0; i<_numeroGiorniAllenamento; i++)
            {
                int indiceGiorno = i + 1;
                result = result + "Giorno "+ indiceGiorno + "\n" +_giorniAllenamento[i].ToString() + "\n";
            }
            return result;
        }
    }
}
