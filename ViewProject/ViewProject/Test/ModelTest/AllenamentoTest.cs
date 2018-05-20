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
    class AllenamentoTest
    {
        [Test]
        public void CostruttoreTest()
        {
            Assert.DoesNotThrow(() => new Allenamento(60, new DateTime(2018, 5, 15)));
            Assert.Throws<ArgumentException>(() => new Allenamento(0, new DateTime(2018, 5, 15)));
            Assert.DoesNotThrow(() => new Allenamento(60, new DateTime(2018, 5, 15), 70));
            Assert.Throws<ArgumentException>(() => new Allenamento(60, new DateTime(2018, 5, 15), -1));
        }

        [Test]
        public void ProprietaDurataInMinutiTest()
        {
            Allenamento allenamento = new Allenamento(60, new DateTime(2018, 5, 15));
            Assert.AreEqual(60, allenamento.DurataInMinuti);
        }
        [Test]
        public void ProprietaDataTest()
        {
            Allenamento allenamento = new Allenamento(60, new DateTime(2018, 5, 15));
            Assert.AreEqual(new DateTime(2018, 5, 15), allenamento.Data);
        }

        [Test]
        public void ProprietaPesoInKgTest()
        {
            Allenamento allenamento = new Allenamento(60, new DateTime(2018, 5, 15), 70);
            Assert.AreEqual(70, allenamento.PesoInKg);
        }

        [Test]
        public void ProprietaIDTest()
        {
            Allenamento allenamento = new Allenamento(60, new DateTime(2018, 5, 15));
            allenamento.ID = 1111;
            Assert.AreEqual(1111, allenamento.ID);
        }

        [Test]
        public void EqualsTest()
        {
            Allenamento allenamento = new Allenamento(60, new DateTime(2018, 5, 15));
            Allenamento allenamentoTest = allenamento;
            Assert.AreEqual(true, allenamento.Equals(allenamentoTest));
            allenamentoTest = new Allenamento(60, new DateTime(2018, 5, 15), 10);
            Assert.AreNotEqual(true, allenamento.Equals(allenamentoTest));
            allenamento = new Allenamento(10, new DateTime(2018, 5, 15));
            Assert.AreNotEqual(true, allenamento.Equals(allenamentoTest));
            Assert.AreNotEqual(true, allenamento.Equals(null));
        }
    }
}
