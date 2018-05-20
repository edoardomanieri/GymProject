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
    class EsercizioTest
    { 
        [Test]
        public void CostruttoreTest()
        {
            Assert.DoesNotThrow(() => new Esercizio("plank to down dog", FasciaMuscolare.Addominali, Risorsa.SalaPesi));
            Assert.Throws<ArgumentException>(() => new Esercizio("", FasciaMuscolare.Addominali, Risorsa.SalaPesi));
            Assert.Throws<ArgumentException>(() => new Esercizio(null, FasciaMuscolare.Addominali, Risorsa.SalaPesi));
        }

        [Test]
        public void ProprietaNomeTest()
        {
            Esercizio esercizio = new Esercizio("plank to down dog", FasciaMuscolare.Addominali, Risorsa.SalaPesi);
            Assert.AreEqual("plank to down dog", esercizio.Nome);
        }

        [TestCase(Risorsa.CorpoLibero)]
        [TestCase(Risorsa.SalaPesi)]
        public void ProprietaRisorseRichiesteTest(Risorsa risorsa)
        {
            Esercizio esercizio = new Esercizio("plank to down dog", FasciaMuscolare.Addominali, Risorsa.SalaPesi);
            if (risorsa.Equals(Risorsa.SalaPesi))
                Assert.AreEqual(risorsa, esercizio.RisorseRichieste);
            else
                Assert.AreNotEqual(risorsa, esercizio.RisorseRichieste);
        }

        [TestCase(FasciaMuscolare.Addominali)]
        [TestCase(FasciaMuscolare.Adduttori)]
        [TestCase(FasciaMuscolare.Bicipiti)]
        [TestCase(FasciaMuscolare.Cardio)]
        [TestCase(FasciaMuscolare.Deltoidi)]
        [TestCase(FasciaMuscolare.Dorsali)]
        [TestCase(FasciaMuscolare.Pettorali)]
        [TestCase(FasciaMuscolare.Polpacci)]
        [TestCase(FasciaMuscolare.Quadricipiti)]
        [TestCase(FasciaMuscolare.Tricipiti)]
        public void ProprietaFasciaMuscolareTest(FasciaMuscolare fascia)
        {
            Esercizio esercizio = new Esercizio("plank to down dog", FasciaMuscolare.Addominali, Risorsa.SalaPesi);
            if (fascia.Equals(FasciaMuscolare.Addominali))
                Assert.AreEqual(fascia, esercizio.FasciaMuscolare);
            else
                Assert.AreNotEqual(fascia, esercizio.FasciaMuscolare);

        }

        [Test]
        public void ProprietaDescrizioneTest()
        {
            Esercizio esercizio = new Esercizio("plank to down dog", FasciaMuscolare.Addominali, Risorsa.SalaPesi);
            esercizio.Descrizione = "Prova Descrizione";
            Assert.AreEqual("Prova Descrizione", esercizio.Descrizione);
            Assert.Throws<ArgumentException>(() => esercizio.Descrizione="");
            Assert.Throws<ArgumentException>(() => esercizio.Descrizione =null);
        }

        [Test]
        public void GetDescrizioneTest()
        {
            Esercizio esercizio = new Esercizio("plank to down dog", FasciaMuscolare.Addominali, Risorsa.SalaPesi);
            esercizio.GetDescrizione();
            string descrizione = "È uno dei migliori esercizi per migliorare la flessibilità delle spalle, specialmente della cuffia dei rotatori. Non devi svolgere questo esercizio velocemente; si tratta più un esercizio di riscaldamento da fare prima di iniziare l’allenamento.";
            Assert.AreEqual(descrizione, esercizio.Descrizione);
            List<Esercizio> listaEsercizi = MainPersistanceManager.Instance.LoadAllEsercizi().ToList();
            foreach (Esercizio esercizioCorrente in listaEsercizi)
            {
                Assert.DoesNotThrow(() => esercizioCorrente.GetDescrizione());
                Assert.AreNotEqual(true, esercizioCorrente.Descrizione == "");
            }
        }

        [Test]
        public void EqualsTest()
        {
            Esercizio esercizioTest =  new Esercizio("plank to down dog", FasciaMuscolare.Addominali, Risorsa.SalaPesi);
            Esercizio nuovoEsercizioTest = esercizioTest;
            Assert.AreEqual(true, esercizioTest.Equals(nuovoEsercizioTest));
            nuovoEsercizioTest = new Esercizio("plank to down dog", FasciaMuscolare.Addominali, Risorsa.CorpoLibero);
            Assert.AreNotEqual(true, esercizioTest.Equals(nuovoEsercizioTest));
            nuovoEsercizioTest.GetDescrizione();
            Assert.AreNotEqual(true, esercizioTest.Equals(nuovoEsercizioTest));
        }
    }
}
