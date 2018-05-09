using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    class ConfiguraPianoAllenamentoAutomaticoIpertrofia : IConfiguraPianoAllenamentoAutomatico
    {

        public PianoAllenamento ConfiguraPianoAllenamentoAutomatico(UtenteAutomatico utenteAutomatico, List<Esercizio> listaEsercizi)
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



        private Dictionary<int, List<FasciaMuscolare>> distribuisciFasceMuscolariPerGiorno(int numeroGiorniAllenamento)
        {
            Dictionary<int, List<FasciaMuscolare>> result = new Dictionary<int, List<FasciaMuscolare>>();
            int[] distribuzione = distribuisci(numeroGiorniAllenamento, 8);
            for (int i = 0; i < numeroGiorniAllenamento; i++)
            {
                List<FasciaMuscolare> temp = new List<FasciaMuscolare>();
                int count = 0;
                while (count < distribuzione[i])
                {
                    bool trovato = false;
                    FasciaMuscolare corrente = GetFasciaMuscolareCasuale();
                    if(!temp.Contains(corrente))
                    {
                        foreach(List<FasciaMuscolare> valueCorrente in result.Values)
                        {
                            if (valueCorrente.Contains(corrente))
                                trovato = true;
                        }
                        if (!trovato)
                        {
                            temp.Add(corrente);
                            count++;
                        }
                    }
                }
                result.Add(i, temp);
            }
            return result;
        }

         private FasciaMuscolare GetFasciaMuscolareCasuale()
         {
             IList<FasciaMuscolare> list = new List<FasciaMuscolare>();
             Random random = new Random();
             list.Add(FasciaMuscolare.Addominali);
             list.Add(FasciaMuscolare.Bicipiti);
             list.Add(FasciaMuscolare.Deltoidi);
             list.Add(FasciaMuscolare.Dorsali);
             list.Add(FasciaMuscolare.Pettorali);
             list.Add(FasciaMuscolare.Polpacci);
             list.Add(FasciaMuscolare.Quadricipiti);
             list.Add(FasciaMuscolare.Tricipiti);

             return list.ElementAt(random.Next(list.Count));
         }

        private int[] distribuisci(int dimensioneDistribuzione, int elementiTotDaDistribuire) //Restituisce un array dove: l'indice corrisponde al giorno d'allenamento, il valore contenuto in quell'indice corrisponde al numero di muscoli da allenare.
        {
            int[] result = new int[dimensioneDistribuzione];
           // const int FasceMuscolariTot = 8;

            int indice;
            int valorePerElemento = elementiTotDaDistribuire / dimensioneDistribuzione;
            int valoriRestanti = elementiTotDaDistribuire % dimensioneDistribuzione;

            for (indice = 0; indice < dimensioneDistribuzione; indice++)
                result[indice] = valorePerElemento;
            indice = 0;
            while (valoriRestanti > 0)
            {
                result[indice]++;
                valoriRestanti--;
                indice++;
            }

            return result;
        }

        private InsiemeSerie generaInsiemeSerie(FasciaMuscolare fasciaMuscolare, Risorsa risorseDisponibili, int numeroRipetizioni, int numeroSerie, int tempoRecupero, List<Esercizio> listaEsercizi)
        {
            Random random = new Random();
            Serie nuovaSerie = new Serie(numeroRipetizioni, getEserciziPerFascie(fasciaMuscolare, risorseDisponibili, listaEsercizi)[random.Next(getEserciziPerFascie(fasciaMuscolare, risorseDisponibili, listaEsercizi).Count - 1)]);
            InsiemeSerie nuovoInsiemeSerie = new InsiemeSerie(tempoRecupero);
            for (int i = 0; i < numeroRipetizioni; i++) nuovoInsiemeSerie.addSerie(nuovaSerie);
            return nuovoInsiemeSerie;
        }

        private IList<Esercizio> getEserciziPerFascie(FasciaMuscolare fasciaMuscolare, Risorsa risorseDisponibili,List<Esercizio> listaEsercizi)
        {
            IList<Esercizio> result = new List<Esercizio>();
            foreach (Esercizio corrente in listaEsercizi)
            {
                if (corrente.FasciaMuscolare.Equals(fasciaMuscolare))
                {
                    if (risorseDisponibili.Equals(Risorsa.SalaPesi))
                        result.Add(corrente);
                    else
                    {
                        if (corrente.RisorsaRichiesta.Equals(risorseDisponibili))
                            result.Add(corrente);
                    }

                }

            }
            return result;
        }
    }
}
