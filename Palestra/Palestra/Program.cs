using Palestra.model;
using Palestra.Persistence;
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

            MainPersistanceManager main = new MainPersistanceManager();

            main.ThereIsASavedAccount();
            Utente utente = main.LoadUtente();
            Allenamento allenamento = new Allenamento(30, new DateTime(2018, 7, 12), 51);
            main.DeleteAllenamenti();
            main.CloseConnection();
            while (true) ;















           /* ConfiguraPianoAllenamentoAutomaticoIpertrofia configura = new ConfiguraPianoAllenamentoAutomaticoIpertrofia();
            Dictionary<int, List<FasciaMuscolare>> prova;

            prova = configura.distribuisciFasceMuscolariPerGiorno(1);
            printDictionary(prova);
            prova = configura.distribuisciFasceMuscolariPerGiorno(2);
            printDictionary(prova);

            prova = configura.distribuisciFasceMuscolariPerGiorno(3);
            printDictionary(prova);

            prova = configura.distribuisciFasceMuscolariPerGiorno(4);
            printDictionary(prova);

            prova = configura.distribuisciFasceMuscolariPerGiorno(5);
            printDictionary(prova);

            prova = configura.distribuisciFasceMuscolariPerGiorno(6);
            printDictionary(prova);

            prova = configura.distribuisciFasceMuscolariPerGiorno(7);
            printDictionary(prova);
            Console.ReadLine();*/
      }

        /*private static void printDictionary(Dictionary<int, List<FasciaMuscolare>> prova)
        {
            Console.WriteLine("Prova con numero giorni allenamento = " + prova.Count);
            foreach(int x in prova.Keys)
            {
                int giorno = x+1;
                Console.WriteLine(giorno);
                foreach (FasciaMuscolare fc in prova.ElementAt(x).Value)
                {
                    Console.WriteLine(fc.ToString());
                }
            }
        }*/
    }
}
