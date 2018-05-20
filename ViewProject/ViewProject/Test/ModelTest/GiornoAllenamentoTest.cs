using NUnit.Framework;
using ViewProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Test.ModelTest
{
    [TestFixture]
    class GiornoAllenamentoTest
    {
        [Test]
        public void CostruttoreTest()
        {
            int tempoRecuperoTest = 90, tempoRecuperoErrorTest = 0;
            GiornoAllenamento giornoTest = new GiornoAllenamento(tempoRecuperoTest);
            Assert.AreNotEqual(null, giornoTest.ListaEsecuzioniEsercizi);
            Assert.AreEqual(tempoRecuperoTest, giornoTest.TempoDiRecuperoInSec);
             giornoTest = new GiornoAllenamento();
            Assert.AreNotEqual(null, giornoTest.ListaEsecuzioniEsercizi);
            Assert.Throws<ArgumentException>(() => new GiornoAllenamento(tempoRecuperoErrorTest));
        }

        [Test]
        public void ProprietaTempoDiRecuperoInSec()
        {
            int tempoRecuperoTest = 90, tempoRecuperoErrorTest = 0;
            GiornoAllenamento giornoTest = new GiornoAllenamento(tempoRecuperoTest);
            giornoTest.TempoDiRecuperoInSec = tempoRecuperoTest;
            Assert.AreEqual(tempoRecuperoTest, giornoTest.TempoDiRecuperoInSec);
            Assert.Throws<ArgumentException>(() => giornoTest.TempoDiRecuperoInSec=tempoRecuperoErrorTest);
        }

        [Test]
        public void ProprietaListaEsecuzioniEserciziTest()
        {
            GiornoAllenamento giornoTest = new GiornoAllenamento(90);
            Assert.AreNotEqual(null, giornoTest.ListaEsecuzioniEsercizi);
            EsecuzioneEsercizio temp = new EsecuzioneEsercizio(new Esercizio("Temp", FasciaMuscolare.Addominali, Risorsa.SalaPesi));
            giornoTest.addEsecuzioneEsercizio(temp);
            Assert.AreEqual(true, giornoTest.ListaEsecuzioniEsercizi.Contains(temp));
        }

        [Test]
        public void addEsecuzioneEsercizioTest()
        {
            GiornoAllenamento giornoTest = new GiornoAllenamento(90);
            EsecuzioneEsercizio temp = new EsecuzioneEsercizio(new Esercizio("Temp", FasciaMuscolare.Addominali, Risorsa.SalaPesi));
            giornoTest.addEsecuzioneEsercizio(temp);
            Assert.AreEqual(true, giornoTest.ListaEsecuzioniEsercizi.Contains(temp));
            Assert.AreEqual(1, giornoTest.ListaEsecuzioniEsercizi.Count);
            Assert.Throws<ArgumentException>(() => giornoTest.addEsecuzioneEsercizio(null));

        }

        [Test]
        public void removeEsecuzioneEsercizioTest()
        {
            GiornoAllenamento giornoTest = new GiornoAllenamento(90);
            EsecuzioneEsercizio temp = new EsecuzioneEsercizio(new Esercizio("Temp", FasciaMuscolare.Addominali, Risorsa.SalaPesi));
            giornoTest.addEsecuzioneEsercizio(temp);
            giornoTest.removeEsecuzioneEsercizio(temp);
            Assert.AreEqual(false, giornoTest.ListaEsecuzioniEsercizi.Contains(temp));
            Assert.AreEqual(0, giornoTest.ListaEsecuzioniEsercizi.Count);
            Assert.Throws<ArgumentException>(() => giornoTest.removeEsecuzioneEsercizio(null));

        }

        [Test]
        public void ProprietaIDTest()
        {
            GiornoAllenamento giornoTest = new GiornoAllenamento(90);
            giornoTest.ID = 1111;
            Assert.AreEqual(1111, giornoTest.ID);
        }

        [Test]
        public void EqualsTest()
        {
            GiornoAllenamento giorno = new GiornoAllenamento();
            GiornoAllenamento nuovoGiorno = giorno;
            Assert.AreEqual(true, giorno.Equals(nuovoGiorno));
            nuovoGiorno = new GiornoAllenamento();
            Assert.AreEqual(true, giorno.Equals(nuovoGiorno));
            nuovoGiorno = new GiornoAllenamento(90);
            Assert.AreNotEqual(true, giorno.Equals(nuovoGiorno));
            giorno = new GiornoAllenamento(90);
            Assert.AreEqual(true, giorno.Equals(nuovoGiorno));
            nuovoGiorno.addEsecuzioneEsercizio(new EsecuzioneEsercizio(new Esercizio("prova", FasciaMuscolare.Addominali, Risorsa.CorpoLibero)));
            Assert.AreNotEqual(true, giorno.Equals(nuovoGiorno));
        }
    }
}
