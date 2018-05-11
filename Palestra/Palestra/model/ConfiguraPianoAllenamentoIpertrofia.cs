using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class ConfiguraPianoAllenamentoIpertrofia : IConfiguraPianoAllenamento
    {
        //prova
        public override PianoAllenamento Configura(UtenteAutomatico utenteAutomatico, List<Esercizio> listaEsercizi)
        {
            PianoAllenamento schedaGenerata = schedaGenerata = new PianoAllenamento(utenteAutomatico.Tipo);
            schedaGenerata.NumeroGiorniAllenamento = utenteAutomatico.NumeroAllenamentiSettimanali;
            Dictionary<int, List<FasciaMuscolare>> distribuzioneMuscoli = distribuisciFasceMuscolariPerGiorno(schedaGenerata.NumeroGiorniAllenamento);
           
            for(int indice=0; indice < distribuzioneMuscoli.Count; indice++)
            {
                int[] eserciziPerMuscolo = distribuisci(distribuzioneMuscoli.ElementAt(indice).Value.Count, 8);
                GiornoAllenamento nuovoGiornoAllenamento = new GiornoAllenamento(90);
                for (int indiceMuscolo = 0; indiceMuscolo < eserciziPerMuscolo.Length; indiceMuscolo++)
                {
                    for(int indiceEsercizio=0; indiceEsercizio< eserciziPerMuscolo[indiceMuscolo]; indiceEsercizio++)
                    {
                        nuovoGiornoAllenamento.addInsiemeSerie(generaInsiemeSerie(distribuzioneMuscoli.ElementAt(indice).Value.ElementAt(indiceEsercizio), utenteAutomatico.Risorse, 10, 4, 90, listaEsercizi));
                    }
                        
                }
                schedaGenerata.inserisciGiornoAllenamento(nuovoGiornoAllenamento);
            }


            return schedaGenerata;
        }   
    }
}
