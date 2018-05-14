using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    class ConfiguraPianoAllenamentoTonificazione : IConfiguraPianoAllenamento
    {
        const int numeroRipetizioniTonificazione = 20;
        const int numeroSerieTonificazione = 3;
        const int tempoDEsecuzioneInMinTonificazione = 30;
        const int tempoDiRecuperoInSecTonificazione = 60;
        public override PianoAllenamento Configura(UtenteAutomatico utenteAutomatico, List<Esercizio> esercizi)
        {
            PianoAllenamento schedaGenerata = schedaGenerata = new PianoAllenamento();
            Dictionary<int, List<FasciaMuscolare>> distribuzioneMuscoli = distribuisciFasceMuscolariPerGiorno(utenteAutomatico.NumeroGiorniAllenamento); //distribuzione muscoli da allenare in tutta la settimana
            

            for (int giorno = 0; giorno < distribuzioneMuscoli.Count; giorno++)//per ogni giorno d'allenamento
            {
                int[] eserciziPerMuscolo = distribuisci(distribuzioneMuscoli.ElementAt(giorno).Value.Count, getNumeroEserciziPerNumeroGiorniAllenamento(utenteAutomatico.NumeroGiorniAllenamento) - 2); //distribuzione numero esercizi per ogni muscolo da allenare nel giorno corrente
                GiornoAllenamento nuovoGiornoAllenamento = new GiornoAllenamento(tempoDiRecuperoInSecTonificazione);
                IList<Esercizio> listaEserciziCardio = getEserciziPerFascie(FasciaMuscolare.Cardio, utenteAutomatico.Risorse, esercizi);
                nuovoGiornoAllenamento.addEsecuzioneEsercizio(new EsecuzioneEsercizioATempo(listaEserciziCardio[listaEserciziCardio.Count-1], tempoDEsecuzioneInMinTonificazione)); //aggiungo staticamente due esercizi cardio, da notare il -2 quando chiamo "getNumeroEserciziPerNumeroGiorniAllenamento"
                for (int indiceMuscolo = 0; indiceMuscolo < eserciziPerMuscolo.Length; indiceMuscolo++)//per ogni muscolo d'allenare del giorno d'allenamento corrente
                {
                    IList<Esercizio> listaPerMuscoloCorrente = getEserciziPerFascie(distribuzioneMuscoli[giorno].ElementAt(indiceMuscolo), utenteAutomatico.Risorse, esercizi);
                    for (int indiceEsercizio = 0; indiceEsercizio < eserciziPerMuscolo[indiceMuscolo]; indiceEsercizio++)//per ogni esercizio del muscolo corrente
                    {
                        Esercizio nuovoEsercizio = listaPerMuscoloCorrente[new Random().Next(listaPerMuscoloCorrente.Count - 1)];
                        if (verificaPresenzaEsercizio(nuovoEsercizio, nuovoGiornoAllenamento)) // è scelto random, percio se è già presente ripete l'iterazione all'indice corrente
                            nuovoGiornoAllenamento.addEsecuzioneEsercizio(new EsecuzioneEsercizioASerie(nuovoEsercizio, tempoDiRecuperoInSecTonificazione, numeroRipetizioniTonificazione, numeroSerieTonificazione));
                        else
                            indiceEsercizio--;
                    }

                }
                nuovoGiornoAllenamento.addEsecuzioneEsercizio(new EsecuzioneEsercizioATempo(listaEserciziCardio[listaEserciziCardio.Count - 1], tempoDEsecuzioneInMinTonificazione));
                schedaGenerata.addGiornoAllenamento(nuovoGiornoAllenamento);
            }


            return schedaGenerata;
        }
    }
}
