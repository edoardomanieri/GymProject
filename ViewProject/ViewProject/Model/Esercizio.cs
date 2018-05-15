using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Palestra.model
{ 
    public class Esercizio
    {
        public event EventHandler Changed;
        private string _nome;
        private FasciaMuscolare _fasciaMuscolare;
        private string _descrizione;
        private Risorsa _risorseRichieste;

        public Esercizio(string nome, FasciaMuscolare fasciaMuscolare, Risorsa risorseRichieste)
        {
            Nome = nome;
            FasciaMuscolare = fasciaMuscolare;
            RisorseRichieste = risorseRichieste;
        }


        public void GetDescrizione()
        {
            string line = "";
            StringBuilder descrizione = new StringBuilder();

            System.IO.StreamReader file = new System.IO.StreamReader("descrizioneEsercizi.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.ElementAt(0).Equals('#'))
                {
                    line.Remove(0, 1);
                    if (line.Equals(Nome))
                    {
                        while (!(line = file.ReadLine()).Equals("FINE"))
                        {
                            descrizione.Append(line);
                        }
                        file.Close();
                        Descrizione = descrizione.ToString();
                    }
                }
            }
            file.Close();
            if (descrizione.Equals(""))
                Descrizione = "Descrizione non disponibile";
            else
                Descrizione = descrizione.ToString();
            OnChanged();
        }

        public string Nome { get => _nome; set => _nome = value; }
        public FasciaMuscolare FasciaMuscolare { get => _fasciaMuscolare; set => _fasciaMuscolare = value; }
        public string Descrizione { get => _descrizione; set => _descrizione = value; }
        public Risorsa RisorseRichieste { get => _risorseRichieste; set => _risorseRichieste = value; }

        private void OnChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }
    }
}
