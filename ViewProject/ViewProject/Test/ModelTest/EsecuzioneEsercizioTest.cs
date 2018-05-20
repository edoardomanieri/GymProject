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
    class EsecuzioneEsercizioTest
    {
        [Test]
        public void CostruttoreTest()
        {
           Assert.DoesNotThrow(() => new EsecuzioneEsercizio(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero)));
           Assert.Throws<ArgumentException>(() => new EsecuzioneEsercizio(null));
        }

        [Test]
        public void ProprietaEsercizioTest()
        {
            EsecuzioneEsercizio esecuzioneEsercizio = new EsecuzioneEsercizio(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            Esercizio esercizioTest = new Esercizio("EsercizioTest", FasciaMuscolare.Addominali, Risorsa.SalaPesi);
            esecuzioneEsercizio.Esercizio = esercizioTest;
            Assert.AreEqual(esercizioTest, esecuzioneEsercizio.Esercizio);
            Assert.Throws<ArgumentException>(() => esecuzioneEsercizio.Esercizio = null);
        }

        [Test]
        public void ProprietaIDTest()
        {
            EsecuzioneEsercizio esecuzioneEsercizio = new EsecuzioneEsercizio(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            esecuzioneEsercizio.ID = 1111;
            Assert.AreEqual(1111, esecuzioneEsercizio.ID);
        }
        [Test]
        public void EqualsTest()
        {
            EsecuzioneEsercizio esecuzioneEsercizio = new EsecuzioneEsercizio(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            EsecuzioneEsercizio nuovoEsecuzioneEsercizioTest = esecuzioneEsercizio;
            Assert.AreEqual(true, esecuzioneEsercizio.Equals(nuovoEsecuzioneEsercizioTest));
            nuovoEsecuzioneEsercizioTest = new EsecuzioneEsercizio(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            Assert.AreEqual(true, esecuzioneEsercizio.Equals(nuovoEsecuzioneEsercizioTest));
            nuovoEsecuzioneEsercizioTest = new EsecuzioneEsercizio(new Esercizio("Esercizio", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            Assert.AreNotEqual(true, esecuzioneEsercizio.Equals(nuovoEsecuzioneEsercizioTest));
        }
    }
}
