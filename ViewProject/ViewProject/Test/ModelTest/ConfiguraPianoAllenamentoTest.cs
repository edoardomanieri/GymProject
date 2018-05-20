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
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAuto.Risorse, ConfiguraPianoAllenamentoIpertrofia.numeroRipetizioniIpertrofia, ConfiguraPianoAllenamentoIpertrofia.numeroSerieIpertrofia, ConfiguraPianoAllenamentoIpertrofia.tempoDiRecuperoInSecIpertrofia, 0));
            Assert.AreEqual(true, verificaUnicitaEsercizi(schedaTest));
            schedaTest = configura.Configura(utenteAutoCorpoLibero, manager.LoadAllEsercizi().ToList());
            Assert.AreEqual(true, schedaTest.NumeroGiorniAllenamento == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, schedaTest.GiorniAllenamento.Count == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, verificaPresenzaFasceMuscolari(schedaTest));
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAutoCorpoLibero.Risorse, ConfiguraPianoAllenamentoIpertrofia.numeroRipetizioniIpertrofia, ConfiguraPianoAllenamentoIpertrofia.numeroSerieIpertrofia, ConfiguraPianoAllenamentoIpertrofia.tempoDiRecuperoInSecIpertrofia, 0));
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
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAuto.Risorse, ConfiguraPianoAllenamentoDefinizione.numeroRipetizioniDefinizione, ConfiguraPianoAllenamentoDefinizione.numeroSerieDefinizione, ConfiguraPianoAllenamentoDefinizione.tempoDiRecuperoInSecDefinizione, 0));
            Assert.AreEqual(true, verificaUnicitaEsercizi(schedaTest));
            schedaTest = configura.Configura(utenteAutoCorpoLibero, manager.LoadAllEsercizi().ToList());
            Assert.AreEqual(true, schedaTest.NumeroGiorniAllenamento == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, schedaTest.GiorniAllenamento.Count == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, verificaPresenzaFasceMuscolari(schedaTest));
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAutoCorpoLibero.Risorse, ConfiguraPianoAllenamentoDefinizione.numeroRipetizioniDefinizione, ConfiguraPianoAllenamentoDefinizione.numeroSerieDefinizione, ConfiguraPianoAllenamentoDefinizione.tempoDiRecuperoInSecDefinizione, 0));
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
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAuto.Risorse, ConfiguraPianoAllenamentoTonificazione.numeroRipetizioniTonificazione, ConfiguraPianoAllenamentoTonificazione.numeroSerieTonificazione, ConfiguraPianoAllenamentoTonificazione.tempoDiRecuperoInSecTonificazione, ConfiguraPianoAllenamentoTonificazione.tempoDEsecuzioneInMinTonificazione));
            Assert.AreEqual(true, verificaUnicitaEsercizi(schedaTest));
            Assert.AreEqual(true, isPresentCardio(schedaTest));
            schedaTest = configura.Configura(utenteAutoCorpoLibero, manager.LoadAllEsercizi().ToList());
            Assert.AreEqual(true, schedaTest.NumeroGiorniAllenamento == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, schedaTest.GiorniAllenamento.Count == utenteAutoCorpoLibero.NumeroGiorniAllenamento);
            Assert.AreEqual(true, verificaPresenzaFasceMuscolari(schedaTest));
            Assert.AreEqual(true, verificaEsecuzioniEsercizi(schedaTest, utenteAuto.Risorse, ConfiguraPianoAllenamentoTonificazione.numeroRipetizioniTonificazione, ConfiguraPianoAllenamentoTonificazione.numeroSerieTonificazione, ConfiguraPianoAllenamentoTonificazione.tempoDiRecuperoInSecTonificazione, ConfiguraPianoAllenamentoTonificazione.tempoDEsecuzioneInMinTonificazione));
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

        private bool verificaEsecuzioniEsercizi(PianoAllenamento scheda, Risorsa risorsa, int numeroRipetizioni, int numeroSerie, int tempoDiRecuperoInSec, int tempoDEsecuzioneInMinTonificazione)
        {
            bool result = true;
            foreach (GiornoAllenamento giornoCorrente in scheda.GiorniAllenamento)
            {
                if (giornoCorrente.TempoDiRecuperoInSec != tempoDiRecuperoInSec)
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
                        if (temp.NumeroRipetizioni != numeroRipetizioni)
                            result = false;
                        if (temp.NumeroSerie != numeroSerie)
                            result = false;
                        if (temp.TempoDiRecuperoInSec != tempoDiRecuperoInSec)
                            result = false;
                    }
                    if (esecuzioneCorrente is EsecuzioneEsercizioATempo)
                    {
                        EsecuzioneEsercizioATempo temp = esecuzioneCorrente as EsecuzioneEsercizioATempo;
                        if (temp.Tempo != tempoDEsecuzioneInMinTonificazione)
                            result = false;
                    }
                }
            }
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
