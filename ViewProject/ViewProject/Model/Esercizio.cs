using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Palestra.model
{ 
    public class Esercizio
    {
        private readonly string _nome;
        private readonly FasciaMuscolare _fasciaMuscolare;
        private string _descrizione;
        private readonly Risorsa _risorseRichieste;

        public Esercizio(string nome, FasciaMuscolare fasciaMuscolare, Risorsa risorseRichieste)
        {
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentException();
            _nome = nome;
            _fasciaMuscolare = fasciaMuscolare;
            _risorseRichieste = risorseRichieste;
            _descrizione = "";
        }


        public void GetDescrizione()
        {
            string line = "";
            StringBuilder descrizione = new StringBuilder();
            System.IO.StreamReader file = new System.IO.StreamReader(Directory.GetCurrentDirectory() + @"\Palestra\descrizioneEsercizi.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.ElementAt(0).Equals('#'))
                {
                    line = line.Remove(0, 1);
                    if (line.Equals(Nome))
                    {
                        while (!(line = file.ReadLine()).Equals("FINE"))
                        {
                            descrizione.Append(line);
                        }
                        file.Close();
                        Descrizione = descrizione.ToString();
                        break;
                    }
                }
            }
            file.Close();
            if (descrizione.ToString().Equals(""))
                Descrizione = "Descrizione non disponibile";
            else
                Descrizione = descrizione.ToString();
        }

        public string Nome { get => _nome; }
        public FasciaMuscolare FasciaMuscolare { get => _fasciaMuscolare;  }
        public string Descrizione { get => _descrizione; set => _descrizione = value; }
        public Risorsa RisorseRichieste { get => _risorseRichieste;  }


        public override bool Equals(object obj)
        {
            var esercizio = obj as Esercizio;
            return esercizio != null &&
                   _nome == esercizio.Nome &&
                   _fasciaMuscolare == esercizio.FasciaMuscolare &&
                   _descrizione == esercizio.Descrizione &&
                   _risorseRichieste == esercizio.RisorseRichieste;
        }

        public override string ToString()
        {
            return _nome;
        }
    }
}
