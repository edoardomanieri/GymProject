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
    class GestorePianoAllenamentoTest
    {
        [Test]
        public void ProprietaGestorePianoAllenamentoTest()
        {
            Assert.AreNotEqual(null, GestorePianiAllenamento.Instance);
        }

        [Test]
        public void getPianoAllenamentoTest()
        {
            UtenteAutomatico utenteAuto = new UtenteAutomatico("mr", "Mario", "Rossi", new DateTime(2000, 1, 1), 70, 174, Sesso.Maschio, Risorsa.SalaPesi, 3, TipoAllenamento.Definizione);
            MainPersistanceManager manager = MainPersistanceManager.Instance;
            GestorePianiAllenamento gestore = GestorePianiAllenamento.Instance;
            PianoAllenamento scheda = null;
            scheda = gestore.getPianoAllenamento(utenteAuto, manager.LoadAllEsercizi().ToList());
            Assert.AreNotEqual(null, scheda);
        }
    }
}
