using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.model
{
    class ConfiguraPianoAllenamentoDefinizione : IConfiguraPianoAllenamento
    {
        public const int numeroRipetizioniDefinizione = 15;
        public const int numeroSerieDefinizione = 5;
        public const int tempoDiRecuperoInSecDefinizione = 60;
        public override PianoAllenamento Configura(UtenteAutomatico utenteAutomatico, List<Esercizio> esercizi)
        {
            if (utenteAutomatico == null || esercizi == null || esercizi.Count == 0)
                throw new ArgumentException();
            PianoAllenamento schedaGenerata = schedaGenerata = new PianoAllenamento();
            Dictionary<int, List<FasciaMuscolare>> distribuzioneMuscoli = distribuisciFasceMuscolariPerGiorno(utenteAutomatico.NumeroGiorniAllenamento); //distribuzione muscoli da allenare in tutta la settimana


            for (int giorno = 0; giorno < distribuzioneMuscoli.Count; giorno++)//per ogni giorno d'allenamento
            {
                int[] eserciziPerMuscolo = distribuisci(distribuzioneMuscoli.ElementAt(giorno).Value.Count, getNumeroEserciziPerNumeroGiorniAllenamento(utenteAutomatico.NumeroGiorniAllenamento)); //distribuzione numero esercizi per ogni muscolo da allenare nel giorno corrente
                GiornoAllenamento nuovoGiornoAllenamento = new GiornoAllenamento(tempoDiRecuperoInSecDefinizione);
                for (int indiceMuscolo = 0; indiceMuscolo < eserciziPerMuscolo.Length; indiceMuscolo++)//per ogni muscolo d'allenare del giorno d'allenamento corrente
                {
                    IList<Esercizio> listaPerMuscoloCorrente = getEserciziPerFascie(distribuzioneMuscoli[giorno].ElementAt(indiceMuscolo), utenteAutomatico.Risorse, esercizi);
                    int tentativiFalliti = 0;
                    for (int indiceEsercizio = 0; indiceEsercizio < eserciziPerMuscolo[indiceMuscolo]; indiceEsercizio++)//per ogni esercizio del muscolo corrente
                    {
                        Esercizio nuovoEsercizio = listaPerMuscoloCorrente[new Random().Next(listaPerMuscoloCorrente.Count - 1)];
                        if (tentativiFalliti <= NumeroMassimoTentativi)
                        {
                            if (!verificaPresenzaEsercizio(nuovoEsercizio, nuovoGiornoAllenamento)) // è scelto random, percio se è già presente ripete l'iterazione all'indice corrente
                            {
                                nuovoGiornoAllenamento.addEsecuzioneEsercizio(new EsecuzioneEsercizioASerie(nuovoEsercizio, tempoDiRecuperoInSecDefinizione, numeroRipetizioniDefinizione, numeroSerieDefinizione));
                                tentativiFalliti = 0;
                            }
                            else
                            {
                                indiceEsercizio--;
                                tentativiFalliti++;
                            }
                        }
                        else
                            break;
                    }

                }
                schedaGenerata.addGiornoAllenamento(nuovoGiornoAllenamento);
            }


            return schedaGenerata;
        }
    }
}
