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
    class ConfiguraPianoAllenamentoFactoryTest
    {
        [TestCase(TipoAllenamento.Definizione)]
        [TestCase(TipoAllenamento.Ipertrofia)]
        [TestCase(TipoAllenamento.Tonificazione)]
        public void ConfiguraPianoAllenamentoFactoryTester(TipoAllenamento tipo)
        {
            IConfiguraPianoAllenamento configuraPianoAllenamento = null;
            configuraPianoAllenamento = ConfiguraPianoAllenamentoFactory.GetConfiguraPianoAllenamento(tipo);
            Assert.AreNotEqual(null, configuraPianoAllenamento);
        }
    }
}
