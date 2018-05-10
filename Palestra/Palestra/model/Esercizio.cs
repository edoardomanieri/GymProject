using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Palestra.model
{ 
    public class Esercizio
    {
        private string _nome;
        private FasciaMuscolare _fasciaMuscolare;
        private string _descrizione;
        private Risorsa _risorseRichieste;

        public Esercizio(string nome, FasciaMuscolare fasciaMuscolare, string descrizione, Risorsa risorseRichieste)
        {
            Nome = nome;
            FasciaMuscolare = fasciaMuscolare;
            Descrizione = descrizione;
            RisorseRichieste = risorseRichieste;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public FasciaMuscolare FasciaMuscolare { get => _fasciaMuscolare; set => _fasciaMuscolare = value; }
        public string Descrizione { get => _descrizione; set => _descrizione = value; }
        public Risorsa RisorseRichieste { get => _risorseRichieste; set => _risorseRichieste = value; }
    }
}
