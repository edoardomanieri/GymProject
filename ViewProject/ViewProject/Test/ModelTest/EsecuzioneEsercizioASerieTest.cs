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
    class EsecuzioneEsercizioASerieTest
    {
        [Test]
        public void CostruttoreTest()
        {
            Assert.DoesNotThrow(() => new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, 4));
            Assert.Throws<ArgumentException>(() => new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 0, 10, 4));
            Assert.Throws<ArgumentException>(() => new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, -1, 4));
            Assert.Throws<ArgumentException>(() => new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, -1));
            Assert.DoesNotThrow(() => new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, 4, 20));
            Assert.Throws<ArgumentException>(() => new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 0, 10, 4, 20));
            Assert.Throws<ArgumentException>(() => new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, -1, 4, 20));
            Assert.Throws<ArgumentException>(() => new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, -1, 20));
            Assert.Throws<ArgumentException>(() => new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, 4, -1));
        }

        [Test]
        public void ProprietaNumeroRipetizioniTest()
        {
            EsecuzioneEsercizioASerie esecuzioneEsercizioASerie = new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, 4);
            Assert.Throws<ArgumentException>(() => esecuzioneEsercizioASerie.NumeroRipetizioni=-1);
            Assert.AreEqual(10, esecuzioneEsercizioASerie.NumeroRipetizioni);
            esecuzioneEsercizioASerie.NumeroRipetizioni = 11;
            Assert.AreEqual(11, esecuzioneEsercizioASerie.NumeroRipetizioni);
        }

        [Test]
        public void ProprietaNumeroSerieTest()
        {
            EsecuzioneEsercizioASerie esecuzioneEsercizioASerie = new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, 4);
            Assert.AreEqual(4, esecuzioneEsercizioASerie.NumeroSerie);
            Assert.Throws<ArgumentException>(() => esecuzioneEsercizioASerie.NumeroSerie = -1);
            esecuzioneEsercizioASerie.NumeroSerie = 5;
            Assert.AreEqual(5, esecuzioneEsercizioASerie.NumeroSerie);
        }

        [Test]
        public void ProprietaCaricoTest()
        {
            EsecuzioneEsercizioASerie esecuzioneEsercizioASerieConCarico = new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, 4, 20);
            Assert.AreEqual(20, esecuzioneEsercizioASerieConCarico.Carico);
            Assert.Throws<ArgumentException>(() => esecuzioneEsercizioASerieConCarico.Carico = -1);
            esecuzioneEsercizioASerieConCarico.Carico = 30;
            Assert.AreEqual(30, esecuzioneEsercizioASerieConCarico.Carico);
        }

        [Test]
        public void ProprietaTempoDiRecuperoInSecTest()
        {
            EsecuzioneEsercizioASerie esecuzioneEsercizioASerie = new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, 4);
            Assert.AreEqual(90, esecuzioneEsercizioASerie.TempoDiRecuperoInSec);
            Assert.Throws<ArgumentException>(() => esecuzioneEsercizioASerie.TempoDiRecuperoInSec = -1);
            esecuzioneEsercizioASerie.TempoDiRecuperoInSec = 60;
            Assert.AreEqual(60, esecuzioneEsercizioASerie.TempoDiRecuperoInSec);
        }

        [Test]
        public void EqualsTest()
        {
            EsecuzioneEsercizioASerie esecuzioneEsercizioASerie = new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, 4);
            EsecuzioneEsercizioASerie nuovoEsecuzioneEsercizioASerie = esecuzioneEsercizioASerie;
            Assert.AreEqual(true, esecuzioneEsercizioASerie.Equals(nuovoEsecuzioneEsercizioASerie));
            nuovoEsecuzioneEsercizioASerie = new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, 4, 20);
            Assert.AreNotEqual(true, esecuzioneEsercizioASerie.Equals(nuovoEsecuzioneEsercizioASerie));
            nuovoEsecuzioneEsercizioASerie = new EsecuzioneEsercizioASerie(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 90, 10, 4);
            Assert.AreEqual(true, esecuzioneEsercizioASerie.Equals(nuovoEsecuzioneEsercizioASerie));
            nuovoEsecuzioneEsercizioASerie.NumeroRipetizioni = 2;
            Assert.AreNotEqual(true, esecuzioneEsercizioASerie.Equals(nuovoEsecuzioneEsercizioASerie));
            Assert.AreNotEqual(true, esecuzioneEsercizioASerie.Equals(null));
        }
    }
}
