using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.model
{
    public abstract class IConfiguraPianoAllenamento
    {
        protected const int FasceMuscolariUtili = 9; //Utili perchè le fascie totali sono 10 con cardio, ma cardio lo utilizzo a parte solo per dimagrimento
        protected const int NumeroMassimoTentativi = 100000;
        private readonly int[] _tempiDiRecuperoInSec;
        private readonly int[] _tempiDiEsecuzioneInMinTonificazione;
        private readonly int[] _numeriSerieIpertrofia;
        private readonly int[] _numeriSerieDefinizione;
        private readonly int[] _numeriSerieTonificazione;
        private readonly int[] _numeriRipetizioniIpertrofia;
        private readonly int[] _numeriRipetizioniDefinizione;
        private readonly int[] _numeriRipetizioniTonificazione;

        protected int[] TempiDiRecuperoInSec => _tempiDiRecuperoInSec;

        protected int[] TempiDiEsecuzioneInMinTonificazione => _tempiDiEsecuzioneInMinTonificazione;

        protected int[] NumeriSerieIpertrofia => _numeriSerieIpertrofia;

        protected int[] NumeriSerieDefinizione => _numeriSerieDefinizione;

        protected int[] NumeriSerieTonificazione => _numeriSerieTonificazione;

        protected int[] NumeriRipetizioniIpertrofia => _numeriRipetizioniIpertrofia;
        
        protected int[] NumeriRipetizioniDefinizione => _numeriRipetizioniDefinizione;

        protected int[] NumeriRipetizioniTonificazione => _numeriRipetizioniTonificazione;

        protected IConfiguraPianoAllenamento()
        {
            _tempiDiRecuperoInSec = new int[3];
            _tempiDiEsecuzioneInMinTonificazione = new int[3];
            _numeriSerieIpertrofia = new int[3];
            _numeriSerieDefinizione = new int[3];
            _numeriSerieTonificazione = new int[3];
            _numeriRipetizioniIpertrofia = new int[3];
            _numeriRipetizioniDefinizione = new int[3];
            _numeriRipetizioniTonificazione = new int[3];

            _tempiDiRecuperoInSec[0] = 60; _tempiDiRecuperoInSec[1] = 90; _tempiDiRecuperoInSec[2] = 120;
            _tempiDiEsecuzioneInMinTonificazione[0] = 30; _tempiDiEsecuzioneInMinTonificazione[1] = 45; _tempiDiEsecuzioneInMinTonificazione[2] = 20;
            _numeriSerieIpertrofia[0] = 2; _numeriSerieIpertrofia[1] = 3; _numeriSerieIpertrofia[2] = 4;
            _numeriSerieDefinizione[0] = 5; _numeriSerieDefinizione[1] = 3; _numeriSerieDefinizione[2] = 4;
            _numeriSerieTonificazione[0] = 4; _numeriSerieTonificazione[1] = 5; _numeriSerieTonificazione[2] = 6;
            _numeriRipetizioniIpertrofia[0] = 6; _numeriRipetizioniIpertrofia[1] = 8; _numeriRipetizioniIpertrofia[2] = 10;
            _numeriRipetizioniDefinizione[0] = 12; _numeriRipetizioniDefinizione[1] = 15; _numeriRipetizioniDefinizione[2] = 20;
            _numeriRipetizioniTonificazione[0] = 10; _numeriRipetizioniTonificazione[1] = 12; _numeriRipetizioniTonificazione[2] = 15;
        }

        public abstract PianoAllenamento Configura(UtenteAutomatico utenteAutomatico, List<Esercizio> esercizi);

        protected Dictionary<int, List<FasciaMuscolare>> distribuisciFasceMuscolariPerGiorno(int numeroGiorniAllenamento)
        {
            Dictionary<int, List<FasciaMuscolare>> result = new Dictionary<int, List<FasciaMuscolare>>();
            int[] distribuzione = distribuisci(numeroGiorniAllenamento, FasceMuscolariUtili);
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
