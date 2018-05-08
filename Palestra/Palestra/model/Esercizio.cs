using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Palestra.model
{
    public enum FasciaMuscolare { Bicipiti, Petto, Tricipiti, Addome, Quadricipiti, Deltoidi, Polpacci, Dorso }
    public class Esercizio
    {

        private string _nome;
        private FasciaMuscolare _fasciaMuscolare;

        public Esercizio(string nome, FasciaMuscolare fasciaMuscolare)
        {
            Nome = nome;
            FasciaMuscolare = fasciaMuscolare;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public FasciaMuscolare FasciaMuscolare { get => _fasciaMuscolare; set => _fasciaMuscolare = value; }

    }
}
