using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public abstract class IConfiguraPianoAllenamento
    {
        const int FasceMuscolariTot = 9;
        public abstract PianoAllenamento  Configura(UtenteAutomatico utenteAutomatico, List<Esercizio> esercizi);

        public Dictionary<int, List<FasciaMuscolare>> distribuisciFasceMuscolariPerGiorno(int numeroGiorniAllenamento)
        {
            Dictionary<int, List<FasciaMuscolare>> result = new Dictionary<int, List<FasciaMuscolare>>();
            int[] distribuzione = distribuisci(numeroGiorniAllenamento, FasceMuscolariTot);
            for (int i = 0; i < numeroGiorniAllenamento; i++)
            {
                List<FasciaMuscolare> temp = new List<FasciaMuscolare>();
                int count = 0;
                while (count < distribuzione[i])
                {
                    bool trovato = false;
                    FasciaMuscolare corrente = GetFasciaMuscolareCasuale();
                    if (!temp.Contains(corrente))
                    {
                        foreach (List<FasciaMuscolare> valueCorrente in result.Values)
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

        protected FasciaMuscolare GetFasciaMuscolareCasuale()
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
            list.Add(FasciaMuscolare.Adduttori);

            return list.ElementAt(random.Next(list.Count));
        }

        protected int[] distribuisci(int dimensioneDistribuzione, int elementiTotDaDistribuire) //Restituisce un array dove: l'indice corrisponde al giorno d'allenamento, il valore contenuto in quell'indice corrisponde al numero di muscoli da allenare.
        {
            int[] result = new int[dimensioneDistribuzione];// 

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
        protected int getNumeroEserciziPerNumeroGiorniAllenamento(int numeroGiorniAllenamento)
        {
            switch (numeroGiorniAllenamento)
            {
                case (1):
                    {
                        return 9;
                    }
                case (2):
                    {
                        return 8;
                    }
                case (3):
                    {
                        return 8;
                    }
                case (4):
                    {
                        return 7;
                    }
                case (5):
                    {
                        return 6;
                    }
                case (6):
                    {
                        return 5;
                    }
                case (7):
                    {
                        return 4;
                    }
                default:
                    throw new Exception();
            }
        }

        protected bool verificaPresenzaEsercizio(Esercizio esercizio, GiornoAllenamento giorno)
        {
            bool verifica = false;
            foreach (EsecuzioneEsercizio corrente in giorno.ListaEsecuzioniEsercizi)
                if (corrente.Esercizio.Equals(esercizio))
                    verifica = true;
            return verifica;
        }

        protected IList<Esercizio> getEserciziPerFascie(FasciaMuscolare fasciaMuscolare, Risorsa risorseDisponibili, List<Esercizio> listaEsercizi)
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
                        if (corrente.RisorseRichieste.Equals(risorseDisponibili))
                            result.Add(corrente);
                    }

                }

            }
            return result;
        }
        
    }
}
