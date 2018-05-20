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

    class PianoAllenamentoTest
    {
        [Test]
        public void CostruttoreTest()
        {
            PianoAllenamento pianoTest = new PianoAllenamento();
            Assert.AreNotEqual(null, pianoTest.GiorniAllenamento);
            Assert.AreEqual(0, pianoTest.NumeroGiorniAllenamento);
        }
        [Test]
        public void ProprietaNumeroGiorniAllenamentoTest()
        {
            PianoAllenamento pianoTest = new PianoAllenamento();
            Assert.AreEqual(0, pianoTest.NumeroGiorniAllenamento);
        }

        [Test]
        public void ProprietaGiorniAllenamentoTest()
        {
            PianoAllenamento pianoTest = new PianoAllenamento();
            GiornoAllenamento giornoTest = new GiornoAllenamento(90);
            List<GiornoAllenamento> giorniAllenamentoTest = new List<GiornoAllenamento>();
            giorniAllenamentoTest.Add(giornoTest);
            pianoTest.addGiornoAllenamento(giornoTest);
            Assert.AreEqual(giorniAllenamentoTest, pianoTest.GiorniAllenamento);
        }

        [Test]
        public void addGiornoAllenamentoTest()
        {
            PianoAllenamento pianoTest = new PianoAllenamento();
            for (int i=1; i<=8; i++)
            {
                GiornoAllenamento giornoTest = new GiornoAllenamento(i);
                pianoTest.addGiornoAllenamento(giornoTest);
                if (i == 8)
                {
                    Assert.AreNotEqual(i, pianoTest.GiorniAllenamento.Count);
                    Assert.AreNotEqual(true, pianoTest.GiorniAllenamento.Contains(giornoTest));
                }
                else
                {
                    Assert.AreEqual(i, pianoTest.GiorniAllenamento.Count);
                    Assert.AreEqual(true, pianoTest.GiorniAllenamento.Contains(giornoTest));
                }
            }
        }
        [Test]
        public void removeGiornoAllenamentoTest()
        {
            PianoAllenamento pianoTest = new PianoAllenamento();
            GiornoAllenamento giornoTest = new GiornoAllenamento(90);
            Assert.AreNotEqual(true, pianoTest.removeGiornoAllenamento(giornoTest));
            Assert.AreEqual(pianoTest.NumeroGiorniAllenamento, pianoTest.GiorniAllenamento.Count);
            pianoTest.addGiornoAllenamento(giornoTest);
            Assert.AreEqual(true, pianoTest.removeGiornoAllenamento(giornoTest));
            Assert.AreEqual(pianoTest.NumeroGiorniAllenamento, pianoTest.GiorniAllenamento.Count);
        }
        [Test]
        public void EqualsTest()
        {
            PianoAllenamento piano = new PianoAllenamento();
            PianoAllenamento nuovoPiano = piano;
            Assert.AreEqual(true, piano.Equals(nuovoPiano));
            nuovoPiano = new PianoAllenamento();
            Assert.AreEqual(true, piano.Equals(nuovoPiano));
            nuovoPiano.addGiornoAllenamento(new GiornoAllenamento());
            Assert.AreNotEqual(true, piano.Equals(nuovoPiano));
        }
    }
}
