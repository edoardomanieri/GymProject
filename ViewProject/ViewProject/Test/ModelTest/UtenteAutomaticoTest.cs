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
    class UtenteAutomaticoTest
    {
        [Test]
        public void CostruttoreTest()
        {
            Assert.DoesNotThrow(() => new UtenteAutomatico("mr","Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.CorpoLibero, 3, TipoAllenamento.Definizione));
            Assert.Throws<ArgumentException>(() => new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio,Risorsa.CorpoLibero, -1, TipoAllenamento.Definizione));
            Assert.Throws<ArgumentException>(() => new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.CorpoLibero, 8, TipoAllenamento.Definizione));
        }

        [TestCase(Risorsa.CorpoLibero)]
        [TestCase(Risorsa.SalaPesi)]
        public void ProprietaRisorsaTest(Risorsa risorsaDisponibile)
        {
            UtenteAutomatico utenteAuto = new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.SalaPesi, 3, TipoAllenamento.Definizione);
            if (risorsaDisponibile.Equals(Risorsa.SalaPesi))
                Assert.AreEqual(risorsaDisponibile, utenteAuto.Risorse);
            else
                Assert.AreNotEqual(risorsaDisponibile, utenteAuto.Risorse);
        }

        [TestCase(TipoAllenamento.Definizione)]
        [TestCase(TipoAllenamento.Ipertrofia)]
        [TestCase(TipoAllenamento.Tonificazione)]
        public void ProprietaTipoAllenamentoTest(TipoAllenamento tipo)
        {
            UtenteAutomatico utenteAuto = new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.CorpoLibero, 3, TipoAllenamento.Definizione);
            if (tipo.Equals(TipoAllenamento.Definizione))
                 Assert.AreEqual(tipo, utenteAuto.Tipo);
            else
                Assert.AreNotEqual(tipo, utenteAuto.Tipo);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        public void ProprietaNumeroGiorniAllenamentoTest(int numeroGiorniAllenamento)
        {
            UtenteAutomatico utenteAuto = new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.CorpoLibero, 7, TipoAllenamento.Definizione);
            if (numeroGiorniAllenamento==7)
                Assert.AreEqual(numeroGiorniAllenamento, utenteAuto.NumeroGiorniAllenamento);
            else
                Assert.AreNotEqual(numeroGiorniAllenamento, utenteAuto.NumeroGiorniAllenamento);
        }

        [Test]
        public void EqualsTest()
        {
            UtenteAutomatico utente = new UtenteAutomatico("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio,Risorsa.CorpoLibero,3,TipoAllenamento.Definizione);
            UtenteAutomatico nuovoUtente = utente;
            Assert.AreEqual(true, utente.Equals(nuovoUtente));
            nuovoUtente = new UtenteAutomatico("MR", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio,Risorsa.CorpoLibero, 3, TipoAllenamento.Definizione);
            Assert.AreEqual(true, utente.Equals(nuovoUtente));
            nuovoUtente = new UtenteAutomatico("R", "Marco", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.CorpoLibero, 3, TipoAllenamento.Definizione);
            Assert.AreNotEqual(true, utente.Equals(nuovoUtente));
        }
    }
}
