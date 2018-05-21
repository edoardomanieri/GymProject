using NUnit.Framework;
using ViewProject.model;
using ViewProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Test.ModelTest
{
    [TestFixture]
    class ConfiguraPianoAllenamentoTest
    {
        private readonly int[] _tempiDiRecuperoInSec;
        private readonly int[] _tempiDiEsecuzioneInMinTonificazione;
        private readonly int[] _numeriSerieIpertrofia;
        private readonly int[] _numeriSerieDefinizione;
        private readonly int[] _numeriSerieTonificazione;
        private readonly int[] _numeriRipetizioniIpertrofia;
        private readonly int[] _numeriRipetizioniDefinizione;
        private readonly int[] _numeriRipetizioniTonificazione;

        public ConfiguraPianoAllenamentoTest()
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

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        public void ConfiguraPianoAllenamentoIpertrofiaTest(int numeroGiorniAllenamento)
        {
            IConfiguraPianoAllenamento configura = ConfiguraPianoAllenamentoFactory.GetConfiguraPianoAllenamento(TipoAllenamento.Ipertrofia);
            UtenteAutomatico utenteAuto = new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.SalaPesi, numeroGiorniAllenamento, TipoAllenamento.Ipertrofia);
            UtenteAutomatico utenteAutoCorpoLibero = new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.CorpoLibero, numeroGiorniAllenamento, TipoAllenamento.Ipertrofia);
            MainPersistanceManager manager = MainPersistanceManager.Instance;
            Assert.Throws<ArgumentException>(() => configura.Configura(null, manager.LoadAllEsercizi().ToList()));
            Assert.Throws<ArgumentException>(() => configura.Configura(utenteAuto, null));
            Assert.Throws<ArgumentException>(() => configura.Configura(utenteAuto, new List<Esercizio>()));
            PianoAllenamento schedaTest = configura.Configura(utenteAuto, manager.LoadAllEsercizi().ToList());
            Assert.AreEqual(true, schedaTest.NumeroGiorniAllenamento == utenteAuto.NumeroGiorniAllenamento);
            Assert.AreEqual(true, schedaTest.GiorniAllenamento.Count == utenteAuto.NumeroGiorniAllenamento);
            Assert.AreEqual(true, verificaPresenzaFasceMuscolari(schedaTest));
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAuto.Risorse, _numeriRipetizioniIpertrofia, _numeriSerieIpertrofia, _tempiDiRecuperoInSec, null));
            Assert.AreEqual(true, verificaUnicitaEsercizi(schedaTest));
            schedaTest = configura.Configura(utenteAutoCorpoLibero, manager.LoadAllEsercizi().ToList());
            Assert.AreEqual(true, schedaTest.NumeroGiorniAllenamento == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, schedaTest.GiorniAllenamento.Count == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, verificaPresenzaFasceMuscolari(schedaTest));
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAutoCorpoLibero.Risorse, _numeriRipetizioniIpertrofia, _numeriSerieIpertrofia, _tempiDiRecuperoInSec, null));
            Assert.AreEqual(true, verificaUnicitaEsercizi(schedaTest));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        public void ConfiguraPianoAllenamentoDefinizioneTest(int numeroGiorniAllenamento)
        {
            IConfiguraPianoAllenamento configura = ConfiguraPianoAllenamentoFactory.GetConfiguraPianoAllenamento(TipoAllenamento.Definizione);
            UtenteAutomatico utenteAuto = new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.SalaPesi, numeroGiorniAllenamento, TipoAllenamento.Definizione);
            UtenteAutomatico utenteAutoCorpoLibero = new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.CorpoLibero, numeroGiorniAllenamento, TipoAllenamento.Definizione);
            MainPersistanceManager manager = MainPersistanceManager.Instance;
            Assert.Throws<ArgumentException>(() => configura.Configura(null, manager.LoadAllEsercizi().ToList()));
            Assert.Throws<ArgumentException>(() => configura.Configura(utenteAuto, null));
            Assert.Throws<ArgumentException>(() => configura.Configura(utenteAuto, new List<Esercizio>()));
            PianoAllenamento schedaTest = configura.Configura(utenteAuto, manager.LoadAllEsercizi().ToList());
            Assert.AreEqual(true, schedaTest.NumeroGiorniAllenamento == utenteAuto.NumeroGiorniAllenamento);
            Assert.AreEqual(true, schedaTest.GiorniAllenamento.Count == utenteAuto.NumeroGiorniAllenamento);
            Assert.AreEqual(true, verificaPresenzaFasceMuscolari(schedaTest));
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAuto.Risorse, _numeriRipetizioniDefinizione, _numeriSerieDefinizione, _tempiDiRecuperoInSec, null));
            Assert.AreEqual(true, verificaUnicitaEsercizi(schedaTest));
            schedaTest = configura.Configura(utenteAutoCorpoLibero, manager.LoadAllEsercizi().ToList());
            Assert.AreEqual(true, schedaTest.NumeroGiorniAllenamento == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, schedaTest.GiorniAllenamento.Count == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, verificaPresenzaFasceMuscolari(schedaTest));
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAutoCorpoLibero.Risorse, _numeriRipetizioniDefinizione, _numeriSerieDefinizione, _tempiDiRecuperoInSec, null));
            Assert.AreEqual(true, verificaUnicitaEsercizi(schedaTest));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        public void ConfiguraPianoAllenamentoTonificazioneTest(int numeroGiorniAllenamento)
        {
            IConfiguraPianoAllenamento configura = ConfiguraPianoAllenamentoFactory.GetConfiguraPianoAllenamento(TipoAllenamento.Tonificazione);
            UtenteAutomatico utenteAuto = new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.SalaPesi, numeroGiorniAllenamento, TipoAllenamento.Tonificazione);
            UtenteAutomatico utenteAutoCorpoLibero = new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.CorpoLibero, numeroGiorniAllenamento, TipoAllenamento.Tonificazione);
            MainPersistanceManager manager = MainPersistanceManager.Instance;
            Assert.Throws<ArgumentException>(() => configura.Configura(null, manager.LoadAllEsercizi().ToList()));
            Assert.Throws<ArgumentException>(() => configura.Configura(utenteAuto, null));
            Assert.Throws<ArgumentException>(() => configura.Configura(utenteAuto, new List<Esercizio>()));
            PianoAllenamento schedaTest = configura.Configura(utenteAuto, manager.LoadAllEsercizi().ToList());
            Assert.AreEqual(true, schedaTest.NumeroGiorniAllenamento == utenteAuto.NumeroGiorniAllenamento);
            Assert.AreEqual(true, schedaTest.GiorniAllenamento.Count == utenteAuto.NumeroGiorniAllenamento);
            Assert.AreEqual(true, verificaPresenzaFasceMuscolari(schedaTest));
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAuto.Risorse, _numeriRipetizioniTonificazione, _numeriSerieTonificazione, _tempiDiRecuperoInSec, _tempiDiEsecuzioneInMinTonificazione));
            Assert.AreEqual(true, verificaUnicitaEsercizi(schedaTest));
            Assert.AreEqual(true, isPresentCardio(schedaTest));
            schedaTest = configura.Configura(utenteAutoCorpoLibero, manager.LoadAllEsercizi().ToList());
            Assert.AreEqual(true, schedaTest.NumeroGiorniAllenamento == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, schedaTest.GiorniAllenamento.Count == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, verificaPresenzaFasceMuscolari(schedaTest));
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAuto.Risorse, _numeriRipetizioniTonificazione, _numeriSerieTonificazione, _tempiDiRecuperoInSec, _tempiDiEsecuzioneInMinTonificazione));
            Assert.AreEqual(true, verificaUnicitaEsercizi(schedaTest));
            Assert.AreEqual(true, isPresentCardio(schedaTest));
        }

        private bool isPresentCardio(PianoAllenamento scheda)
        {
            bool result = false;
            foreach (GiornoAllenamento giornoCorrente in scheda.GiorniAllenamento)
                foreach (EsecuzioneEsercizio esecuzioneCorrente in giornoCorrente.ListaEsecuzioniEsercizi)
                    if (esecuzioneCorrente.Esercizio.FasciaMuscolare.Equals(FasciaMuscolare.Cardio))
                        result = true;
            return result;
        }
        private bool verificaUnicitaEsercizi(PianoAllenamento scheda)
        {
            bool result = true;
            foreach(GiornoAllenamento giornoCorrente in scheda.GiorniAllenamento)
                for(int indiceEsercizioDaValutare=0; indiceEsercizioDaValutare< giornoCorrente.ListaEsecuzioniEsercizi.Count; indiceEsercizioDaValutare++)
                    for (int indiceEsercizioValutato = indiceEsercizioDaValutare + 1; indiceEsercizioValutato < giornoCorrente.ListaEsecuzioniEsercizi.Count; indiceEsercizioValutato++)
                        if (giornoCorrente.ListaEsecuzioniEsercizi[indiceEsercizioDaValutare].Equals(giornoCorrente.ListaEsecuzioniEsercizi[indiceEsercizioValutato]))
                            result = false;
            return result;    
        }

        private bool verificaEsecuzioniEsercizi(PianoAllenamento scheda, Risorsa risorsa, int[] numeroRipetizioni, int[] numeroSerie, int[] tempoDiRecuperoInSec, int[] tempoDEsecuzioneInMinTonificazione)
        {
            bool result = true;
            foreach (GiornoAllenamento giornoCorrente in scheda.GiorniAllenamento)
            {
                if (!valueIsPresent(tempoDiRecuperoInSec,giornoCorrente.TempoDiRecuperoInSec))
                    result = false;
                foreach (EsecuzioneEsercizio esecuzioneCorrente in giornoCorrente.ListaEsecuzioniEsercizi)
                {
                    if (esecuzioneCorrente.Esercizio == null)
                        result = false;
                    if (risorsa == Risorsa.CorpoLibero)
                        if (esecuzioneCorrente.Esercizio.RisorseRichieste != Risorsa.CorpoLibero)
                            result = false;
                    if (esecuzioneCorrente is EsecuzioneEsercizioASerie)
                    {
                        EsecuzioneEsercizioASerie temp = esecuzioneCorrente as EsecuzioneEsercizioASerie;
                        if (!valueIsPresent(numeroRipetizioni,temp.NumeroRipetizioni))
                            result = false;
                        if (!valueIsPresent(numeroSerie, temp.NumeroSerie))
                            result = false;
                        if (!valueIsPresent(tempoDiRecuperoInSec, temp.TempoDiRecuperoInSec))
                            result = false;
                    }
                    if (esecuzioneCorrente is EsecuzioneEsercizioATempo)
                    {
                        EsecuzioneEsercizioATempo temp = esecuzioneCorrente as EsecuzioneEsercizioATempo;
                        if (tempoDEsecuzioneInMinTonificazione != null & !valueIsPresent(tempoDEsecuzioneInMinTonificazione, temp.Tempo))
                            result = false;
                    }
                }
            }
            return result;
        }

        private bool valueIsPresent(int[] array, int valoreDaValutare)
        {
            bool result = false;
            foreach (int valoreCorrente in array)
                if (valoreCorrente == valoreDaValutare)
                    result = true;
            return result;
        }

        private bool verificaPresenzaFasceMuscolari(PianoAllenamento scheda)
        {
            bool result = true;
            Dictionary<FasciaMuscolare, bool> fasceMuscolari = new Dictionary<FasciaMuscolare, bool>();
            fasceMuscolari.Add(FasciaMuscolare.Addominali, false);
            fasceMuscolari.Add(FasciaMuscolare.Adduttori, false);
            fasceMuscolari.Add(FasciaMuscolare.Bicipiti, false);
            fasceMuscolari.Add(FasciaMuscolare.Deltoidi, false);
            fasceMuscolari.Add(FasciaMuscolare.Dorsali, false);
            fasceMuscolari.Add(FasciaMuscolare.Pettorali, false);
            fasceMuscolari.Add(FasciaMuscolare.Polpacci, false);
            fasceMuscolari.Add(FasciaMuscolare.Quadricipiti, false);
            fasceMuscolari.Add(FasciaMuscolare.Tricipiti, false);
            for (int indiceFasce = 0; indiceFasce < fasceMuscolari.Keys.Count; indiceFasce++)
                foreach (GiornoAllenamento giornoCorrente in scheda.GiorniAllenamento)
                    foreach (EsecuzioneEsercizio esecuzioneCorrente in giornoCorrente.ListaEsecuzioniEsercizi)
                        if (esecuzioneCorrente.Esercizio.FasciaMuscolare == fasceMuscolari.Keys.ElementAt(indiceFasce))
                            fasceMuscolari[fasceMuscolari.Keys.ElementAt(indiceFasce)] = true;

            foreach (FasciaMuscolare fasciaCorrente in fasceMuscolari.Keys)
                if (fasceMuscolari[fasciaCorrente] == false)
                    result = false;

            return result;
        }
    }
}
