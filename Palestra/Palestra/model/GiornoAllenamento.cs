using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class GiornoAllenamento
    {
        private int _tempoDiRecuperoInSec;
        private List<InsiemeSerie> _listaInsiemeSerie;

        public GiornoAllenamento(int tempoDiRecuperoInSec)
        {
            _tempoDiRecuperoInSec = tempoDiRecuperoInSec;
            _listaInsiemeSerie = new List<InsiemeSerie>();
        }

        public void addInsiemeSerie(InsiemeSerie insiemeSerie)
        {
            ListaInsiemeSerie.Add(insiemeSerie);
        }

        public Boolean removeInsiemeSerie(InsiemeSerie insiemeSerie)
        {
            return ListaInsiemeSerie.Remove(insiemeSerie);
        }

        public int TempoDiRecuperoInSec { get => _tempoDiRecuperoInSec; set => _tempoDiRecuperoInSec = value; }
        public List<InsiemeSerie> ListaInsiemeSerie { get => _listaInsiemeSerie; }
    }
}
