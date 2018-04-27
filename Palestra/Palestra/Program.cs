using Palestra.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra
{
    class Program
    {
        static void Main(string[] args)
        {
            Esercizio curl = new Esercizio("curl", FasciaMuscolareEnum.FasciaMuscolare.Bicipiti);
            Serie serie = new Serie(4, curl);
            InsiemeSerie insiemeSerie = new InsiemeSerie(60);
            insiemeSerie.addSerie(serie);
            GiornoAllenamento giorno = new GiornoAllenamento(120);
            giorno.addInsiemeSerie(insiemeSerie);
            PianoAllenamento piano = new PianoAllenamento(TipoAllenamentoEnum.TipoAllenamento.Ipertrofia);
            piano.inserisciGiornoAllenamento(giorno);

        }
    }
}
