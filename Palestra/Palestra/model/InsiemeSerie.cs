using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class InsiemeSerie
    {
        private int _tempoDiRecuperoInSec;
        private List<Serie> _listaSerie;

        public InsiemeSerie(int tempoDiRecuperoInSec)
        {
            _tempoDiRecuperoInSec = tempoDiRecuperoInSec;
            _listaSerie = new List<Serie>();
        }

        public void addSerie(Serie serie)
        {
           ListaSerie.Add(serie);
        }
        
        public Boolean removeSerie(Serie serie)
        {
            return ListaSerie.Remove(serie);
        }

        public int TempoDiRecuperoInSec { get => _tempoDiRecuperoInSec; set => _tempoDiRecuperoInSec = value; }
        public List<Serie> ListaSerie { get => _listaSerie; }
    }
}
