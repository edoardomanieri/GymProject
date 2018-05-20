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
    class EsecuzioneEsercizioATempoTest
    {
        [Test]
        public void CostruttoreTest()
        {
            Assert.DoesNotThrow(() => new EsecuzioneEsercizioATempo(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 30));
            Assert.Throws<ArgumentException>(() => new EsecuzioneEsercizioATempo(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 0));
        }

        [Test]
        public void ProprietaTempoTest()
        {
            EsecuzioneEsercizioATempo esecuzioneEsercizioATempo = new EsecuzioneEsercizioATempo(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 30);
            Assert.AreEqual(30, esecuzioneEsercizioATempo.Tempo);
            esecuzioneEsercizioATempo.Tempo = 25;
            Assert.AreEqual(25, esecuzioneEsercizioATempo.Tempo);
            Assert.Throws<ArgumentException>(() => esecuzioneEsercizioATempo.Tempo = -1);
        }

        public void EqualsTest()
        {
            EsecuzioneEsercizioATempo esecuzioneEsercizioATempo = new EsecuzioneEsercizioATempo(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 30);
            EsecuzioneEsercizioATempo nuovoEsecuzioneEsercizioATempo = esecuzioneEsercizioATempo;
            Assert.AreEqual(true, esecuzioneEsercizioATempo.Equals(nuovoEsecuzioneEsercizioATempo));
            nuovoEsecuzioneEsercizioATempo = new EsecuzioneEsercizioATempo(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 30);
            Assert.AreEqual(true, esecuzioneEsercizioATempo.Equals(nuovoEsecuzioneEsercizioATempo));
            nuovoEsecuzioneEsercizioATempo = new EsecuzioneEsercizioATempo(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 10);
            Assert.AreNotEqual(true, esecuzioneEsercizioATempo.Equals(nuovoEsecuzioneEsercizioATempo));
            nuovoEsecuzioneEsercizioATempo = new EsecuzioneEsercizioATempo(new Esercizio("EsercizioProva", FasciaMuscolare.Addominali, Risorsa.CorpoLibero), 30);
            nuovoEsecuzioneEsercizioATempo.Tempo = 40;
            Assert.AreNotEqual(true, esecuzioneEsercizioATempo.Equals(nuovoEsecuzioneEsercizioATempo));
        }
    }
}
