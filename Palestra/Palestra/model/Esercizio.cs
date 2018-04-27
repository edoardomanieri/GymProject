using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Palestra.model.FasciaMuscolareEnum;

namespace Palestra.model
{
    class Esercizio
    {

        private string _nome;
        private FasciaMuscolare _fasciaMuscolare;

        public Esercizio(string nome, FasciaMuscolare fasciaMuscolare)
        {
            Nome = nome;
            FasciaMuscolare = fasciaMuscolare;
        }

        public string Nome { get => _nome; set => _nome = value; }
        internal FasciaMuscolare FasciaMuscolare { get => _fasciaMuscolare; set => _fasciaMuscolare = value; }


    }
}
