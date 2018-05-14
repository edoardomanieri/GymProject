using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class ConfiguraPianoAllenamentoIpertrofia : IConfiguraPianoAllenamento
    {

        const int numeroRipetizioniIpertrofia = 10;
        const int numeroSerieIpertrofia = 4;
        const int tempoDiRecuperoInSecIpertrofia = 90;
        public override PianoAllenamento Configura(UtenteAutomatico utenteAutomatico, List<Esercizio> esercizi)
        {
            PianoAllenamento schedaGenerata = schedaGenerata = new PianoAllenamento();
            schedaGenerata.NumeroGiorniAllenamento = utenteAutomatico.NumeroGiorniAllenamento;
            Dictionary<int, List<FasciaMuscolare>> distribuzioneMuscoli = distribuisciFasceMuscolariPerGiorno(schedaGenerata.NumeroGiorniAllenamento); //distribuzione muscoli da allenare in tutta la settimana


            for (int giorno = 0; giorno < distribuzioneMuscoli.Count; giorno++)//per ogni giorno d'allenamento
            {
                int[] eserciziPerMuscolo = distribuisci(distribuzioneMuscoli.ElementAt(giorno).Value.Count, getNumeroEserciziPerNumeroGiorniAllenamento(schedaGenerata.NumeroGiorniAllenamento)); //distribuzione numero esercizi per ogni muscolo da allenare nel giorno corrente
                GiornoAllenamento nuovoGiornoAllenamento = new GiornoAllenamento(tempoDiRecuperoInSecIpertrofia);
                for (int indiceMuscolo = 0; indiceMuscolo < eserciziPerMuscolo.Length; indiceMuscolo++)//per ogni muscolo d'allenare del giorno d'allenamento corrente
                {
                    IList<Esercizio> listaPerMuscoloCorrente = getEserciziPerFascie(distribuzioneMuscoli[giorno].ElementAt(indiceMuscolo), utenteAutomatico.Risorse, esercizi);
                    for (int indiceEsercizio = 0; indiceEsercizio < eserciziPerMuscolo[indiceMuscolo]; indiceEsercizio++)//per ogni esercizio del muscolo corrente
                    {
                        Esercizio nuovoEsercizio = listaPerMuscoloCorrente[new Random().Next(listaPerMuscoloCorrente.Count - 1)];
                        if (verificaPresenzaEsercizio(nuovoEsercizio, nuovoGiornoAllenamento)) // è scelto random, percio se è già presente ripete l'iterazione all'indice corrente
                            nuovoGiornoAllenamento.addEsecuzioneEsercizio(new EsecuzioneEsercizioASerie(nuovoEsercizio, tempoDiRecuperoInSecIpertrofia, numeroRipetizioniIpertrofia, numeroSerieIpertrofia));
                        else
                            indiceEsercizio--;
                    }

                }
                schedaGenerata.addGiornoAllenamento(nuovoGiornoAllenamento);
            }


            return schedaGenerata;
        }
    }
}
