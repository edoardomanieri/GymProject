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
    class UtenteTest
    {
        [Test]
        public void CostruttoreTest()
        {
            string vuotaTest = "";
            Assert.DoesNotThrow(() => new Utente("MR","Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio));
            Assert.Throws<ArgumentException>(() => new Utente("MR", vuotaTest, "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio));
            Assert.Throws<ArgumentException>(() => new Utente("MR", "Mario", vuotaTest, new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio));
            Assert.Throws<ArgumentException>(() => new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), -1, 174, Sesso.Maschio));
            Assert.Throws<ArgumentException>(() => new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 0, Sesso.Maschio));
            Assert.Throws<ArgumentException>(() => new Utente("", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio));

        }

        [Test]
        public void ProprietaNomeTest()
        {
            Utente utente = new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio);
            Assert.AreEqual("Mario", utente.Nome);
            utente.Nome = "Giorgio";
            Assert.AreEqual("Giorgio", utente.Nome);
            Assert.Throws<ArgumentException>(() => utente.Nome = "");
            Assert.Throws<ArgumentException>(() => utente.Nome = null);
        }

        [Test]
        public void ProprietaCognomeTest()
        {
            Utente utente = new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio);
            Assert.AreEqual("Rossi", utente.Cognome);
            utente.Cognome = "Giorgi";
            Assert.AreEqual("Giorgi", utente.Cognome);
            Assert.Throws<ArgumentException>(() => utente.Cognome = "");
            Assert.Throws<ArgumentException>(() => utente.Cognome = null);
        }

        [Test]
        public void ProprietaDataDiNascitaTest()
        {
            DateTime nuova = new DateTime(2001, 1, 1);
            Utente utente = new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio);
            Assert.AreEqual(new DateTime(2000,1,1), utente.DataDiNascita);
            utente.DataDiNascita = nuova;
            Assert.AreEqual(nuova, utente.DataDiNascita);
        }

        [Test]
        public void ProprietaPesoInKgTest()
        {
            Utente utente = new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio);
            Assert.AreEqual(70, utente.PesoInKg);
            utente.PesoInKg = 60;
            Assert.AreEqual(60, utente.PesoInKg);
            Assert.Throws<ArgumentException>(() => utente.PesoInKg = -1);
        }

        [Test]
        public void ProprietaAltezzaInCmTest()
        {
            Utente utente = new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio);
            Assert.AreEqual(174, utente.AltezzaInCm);
            utente.AltezzaInCm = 160;
            Assert.AreEqual(160, utente.AltezzaInCm);
            Assert.Throws<ArgumentException>(() => utente.AltezzaInCm = -1);
        }

        [TestCase(Sesso.Maschio)]
        [TestCase(Sesso.Femmina)]
        public void ProprietaSessoTest(Sesso sesso)
        {
            Utente utente = new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio);
            if (sesso.Equals(Sesso.Maschio))
            {
                Assert.AreEqual(sesso, utente.Sesso);
                utente.Sesso = Sesso.Femmina;
                Assert.AreEqual(Sesso.Femmina, utente.Sesso);
            }
            else
                Assert.AreNotEqual(sesso, utente.Sesso);
        }
        
        [Test]
        public void EqualsTest()
        {
            Utente utente = new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio);
            Utente nuovoUtente = utente;
            Assert.AreEqual(true, utente.Equals(nuovoUtente));
            nuovoUtente = new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio);
            Assert.AreEqual(true, utente.Equals(nuovoUtente));
            nuovoUtente = new Utente("R", "Marco", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio);
            Assert.AreNotEqual(true, utente.Equals(nuovoUtente));
        }
        [Test]
        public void ProprietaFotoPathTest()
        {
            Utente utente = new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio);
            utente.FotoPath = "/path/path";
            Assert.AreEqual("/path/path", utente.FotoPath);
        }

        [Test]
        public void ProprietaUsernameTest()
        {
            Utente utente = new Utente("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio);
            utente.Username = "RM";
            Assert.AreEqual("RM", utente.Username);
            Assert.Throws<ArgumentException>(() => utente.Username = "");
            Assert.Throws<ArgumentException>(() => utente.Username = null);
        }
    }
}
