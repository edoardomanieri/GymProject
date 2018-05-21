using NUnit.Framework;
using ViewProject.Persistence;
using ViewProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ViewProject.Test.PersistenceTest
{
    [TestFixture]
    class MainPersistenceManagerTest
    {
        [Test]
        public void IstanceTest()
        {
            MainPersistanceManager mpm = null;
            Assert.DoesNotThrow(() => mpm = MainPersistanceManager.Instance);
            Assert.AreNotEqual(null, mpm);
        }

        [Test]
        public void ProprietaSqlConnectionTest()
        {
            MainPersistanceManager mpm = MainPersistanceManager.Instance;
            Assert.AreNotEqual(null, mpm.Conn);
            Assert.DoesNotThrow(() => mpm.Conn = new SqlConnection());
            Assert.Throws<ArgumentException>(() => mpm.Conn = null);
        }

        [Test]
        public void PersistenceTest()
        {
            //SaveDeleteUtente 
            Utente utente1 = new Utente("utenteProva", "uaaatente", "Paaaarova", new DateTime(2000, 1, 1), 45, 170, Sesso.Maschio);
            UtenteAutomatico utenteAuto = new UtenteAutomatico("aaautenteProva", "utente", "Prova", new DateTime(2000, 1, 1), 45, 170, Sesso.Maschio, Risorsa.CorpoLibero, 5, TipoAllenamento.Ipertrofia);
            MainPersistanceManager mpm = MainPersistanceManager.Instance;
            Allenamento allenamento1 = new Allenamento(50, new DateTime(2000, 1, 1), 10);
            Allenamento allenamento2 = new Allenamento(50, new DateTime(2000, 1, 1));
            PianoAllenamento piano = new PianoAllenamento();
            Assert.AreEqual(true, mpm.SaveUtente(utente1, "utenteProva"));
            //Assert.AreEqual(true, mpm.SaveUtenteAutomatico(utenteAuto, utenteAuto.Risorse,utenteAuto.NumeroGiorniAllenamento, utenteAuto.Tipo));

            //SaveDeleteAllenamenti
            Assert.Throws<ArgumentException>(() => mpm.DeleteAllenamenti(null));
            Assert.Throws<ArgumentException>(() => mpm.SaveAllenamento(null, allenamento1));
            Assert.Throws<ArgumentException>(() => mpm.SaveAllenamento(utente1, null));
            Assert.AreEqual(true, mpm.SaveAllenamento(utente1, allenamento1));
            //           Assert.AreEqual(true, mpm.SaveAllenamento(utente1, allenamento2));

            //LoadAllAllenamenti
            Assert.DoesNotThrow(() => mpm.LoadAllAllenamenti(utente1));
            Assert.AreNotEqual(true, mpm.LoadAllAllenamenti(utente1).ToList().Count == 0);
            Assert.Throws<ArgumentException>(() => mpm.LoadAllAllenamenti(null));
            //LoadAllAllenamenti
            //LoadAllEsercizi
            Assert.AreNotEqual(true, mpm.LoadAllEsercizi().ToList().Count == 0);
            //LoadAllEsercizi

            Assert.AreEqual(true, mpm.DeleteAllenamenti(utente1));
            Assert.DoesNotThrow(() => mpm.SaveAllenamento(utente1, allenamento1));
            Assert.DoesNotThrow(() => mpm.DeleteAllenamenti(utente1));
            //SaveDeleteAllenamenti

            //SaveDeletePianoAllenamento
            Assert.Throws<ArgumentException>(() => mpm.DeletePianoAllenamento(null));
            Assert.Throws<ArgumentException>(() => mpm.SavePianoAllenamento(null, piano));
            Assert.Throws<ArgumentException>(() => mpm.SavePianoAllenamento(null, piano));


            //LoadPianoAllenamento
            Assert.Throws<ArgumentException>(() => mpm.LoadPianoAllenamento(null));
            PianoAllenamento piano2 = null;
            Assert.DoesNotThrow(() => piano2 = mpm.LoadPianoAllenamento(utente1));
            Assert.AreNotEqual(null, piano2);
            //LoadPianoAllenamento

            Assert.AreEqual(true, mpm.SavePianoAllenamento(utente1, piano));
            Assert.AreEqual(true, mpm.DeletePianoAllenamento(utente1));
            Assert.DoesNotThrow(() => mpm.SavePianoAllenamento(utente1, piano));

            Assert.AreEqual(true, mpm.ThereIsAPianoAllenamento(utente1));
            Assert.DoesNotThrow(() => mpm.DeletePianoAllenamento(utente1));
            //SaveDeletePianoAllenamento

            Assert.AreNotEqual(true, mpm.ThereIsAPianoAllenamento(utente1));

            //CheckUsername
            Utente utente2 = new Utente("tenteProva", "utente", "Prova", new DateTime(2000, 1, 1), 45, 170, Sesso.Maschio);
            Assert.AreEqual(true, mpm.SaveUtente(utente2, "utenteProva"));
            Assert.AreEqual(true, mpm.CheckUsername(utente2.Username));
            Assert.AreEqual(true, mpm.SaveUtente(utente2, "utenteProva"));
            Assert.DoesNotThrow(() => mpm.CheckUsername(utente2.Username));
            Assert.Throws<ArgumentException>(() => mpm.CheckUsername(null));
            Assert.Throws<ArgumentException>(() => mpm.CheckUsername(""));
            //CheckUsername

            //Autentica
            Utente nuovo = null;
            Assert.DoesNotThrow(() => nuovo = mpm.Autentica(utente1.Username, "utenteProva"));
            Assert.AreNotEqual(null, nuovo);
            Assert.Throws<ArgumentException>(() => mpm.Autentica(null, "utenteProva"));
            Assert.Throws<ArgumentException>(() => mpm.Autentica(nuovo.Username, ""));
            //Autentica

            //UpdateUtente
 /*           Assert.Throws<ArgumentException>(() => mpm.updateUtente(null));
            nuovo.AltezzaInCm=179;
            Assert.DoesNotThrow(() => mpm.updateUtente(nuovo));
            nuovo.AltezzaInCm = 379;
            Assert.AreEqual(true, mpm.updateUtente(nuovo));*/
            //UpdateUtente

            Assert.AreEqual(true, mpm.ThereIsASavedAccount());
            Assert.DoesNotThrow(() => mpm.ThereIsASavedAccount());


            //         Assert.AreEqual(true, mpm.DeleteUtente(utenteAuto));
            Assert.AreEqual(true, mpm.DeleteUtente(utente1));
            Assert.Throws<ArgumentException>(() => mpm.DeleteUtente(null));
            Assert.Throws<ArgumentException>(() => mpm.SaveUtente(null, "ciao"));
            Assert.Throws<ArgumentException>(() => mpm.SaveUtenteAutomatico(null, Risorsa.CorpoLibero, 6, TipoAllenamento.Definizione));
            Assert.Throws<ArgumentException>(() => mpm.SaveUtenteAutomatico(utenteAuto, Risorsa.CorpoLibero, 0, TipoAllenamento.Definizione));
            Assert.Throws<ArgumentException>(() => mpm.SaveUtenteAutomatico(utenteAuto, Risorsa.CorpoLibero, 8, TipoAllenamento.Definizione));
            Assert.Throws<ArgumentException>(() => mpm.SaveUtente(new Utente("utenteProva", "utente", "Prova", new DateTime(2000, 1, 1), 45, 170, Sesso.Maschio), ""));
            //           Assert.DoesNotThrow(() => mpm.SaveUtenteAutomatico(utenteAuto, utenteAuto.Risorse, utenteAuto.NumeroGiorniAllenamento, utenteAuto.Tipo));
            Assert.DoesNotThrow(() => mpm.SaveUtente(utente1, "utenteProva"));
            Assert.DoesNotThrow(() => mpm.DeleteUtente(utente1));
            //           Assert.DoesNotThrow(() => mpm.DeleteUtente(utenteAuto));
            // SaveDeleteUtente
        }

        [TestCase("ipertrofia")]
        [TestCase("definizione")]
        [TestCase("tonificazione")]
        public void getTipoAllenamentoTest(string tipo)
        {
            Assert.Throws<ArgumentException>(() => MainPersistanceManager.getTipoAllenamento(""));
            Assert.Throws<ArgumentException>(() => MainPersistanceManager.getTipoAllenamento(null));
            Assert.DoesNotThrow(() => MainPersistanceManager.getTipoAllenamento(tipo));
            Assert.AreNotEqual(null, MainPersistanceManager.getTipoAllenamento(tipo));
            Assert.AreEqual(null, MainPersistanceManager.getTipoAllenamento("Prova"));
        }

        [TestCase("femmina")]
        [TestCase("maschio")]
        public void getSessoTest(string sesso)
        {
            Assert.Throws<ArgumentException>(() => MainPersistanceManager.getSesso(""));
            Assert.Throws<ArgumentException>(() => MainPersistanceManager.getSesso(null));
            Assert.DoesNotThrow(() => MainPersistanceManager.getSesso(sesso));
            Assert.AreNotEqual(null, MainPersistanceManager.getSesso(sesso));
            Assert.AreEqual(null, MainPersistanceManager.getSesso("Prova"));
        }

        [TestCase("corpo libero")]
        [TestCase("corpolibero")]
        [TestCase("sala pesi")]
        [TestCase("salapesi")]
        public void getRisorsaTest(string risorsa)
        {
            Assert.Throws<ArgumentException>(() => MainPersistanceManager.getRisorsa(""));
            Assert.Throws<ArgumentException>(() => MainPersistanceManager.getRisorsa(null));
            Assert.DoesNotThrow(() => MainPersistanceManager.getRisorsa(risorsa));
            Assert.AreNotEqual(null, MainPersistanceManager.getRisorsa(risorsa));
            Assert.AreEqual(null, MainPersistanceManager.getRisorsa("Prova"));
        }


        public void GetEsercizioByNameTest()
        {
            MainPersistanceManager mpm = MainPersistanceManager.Instance;
            Assert.DoesNotThrow(() => mpm.GetEsercizioByName("trazioni a presa larga"));
            Assert.Throws<ArgumentException>(() => mpm.GetEsercizioByName(""));
            Assert.Throws<ArgumentException>(() => mpm.GetEsercizioByName(null));
            Assert.AreNotEqual(null, mpm.GetEsercizioByName("trazioni a presa larga"));
            Assert.AreEqual(null, mpm.GetEsercizioByName("aaa"));
        }

        [TestCase("bicipiti")]
        [TestCase("adduttori")]
        [TestCase("addominali")]
        [TestCase("cardio")]
        [TestCase("deltoidi")]
        [TestCase("dorsali")]
        [TestCase("pettorali")]
        [TestCase("polpacci")]
        [TestCase("quadricipiti")]
        [TestCase("tricipiti")]
        public void getFasciaMuscolareTest(string fascia)
        {
            Assert.Throws<ArgumentException>(() => MainPersistanceManager.getFasciaMuscolare(""));
            Assert.Throws<ArgumentException>(() => MainPersistanceManager.getFasciaMuscolare(null));
            Assert.DoesNotThrow(() => MainPersistanceManager.getFasciaMuscolare(fascia));
            Assert.AreNotEqual(null, MainPersistanceManager.getFasciaMuscolare(fascia));
            Assert.AreEqual(null, MainPersistanceManager.getRisorsa("Prova"));
        }
    }
}
