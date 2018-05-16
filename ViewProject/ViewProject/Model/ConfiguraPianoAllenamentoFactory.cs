using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class ConfiguraPianoAllenamentoFactory
    {
            private static readonly Dictionary<TipoAllenamento, IConfiguraPianoAllenamento> _dictionary;

            static ConfiguraPianoAllenamentoFactory()
            {
                _dictionary = new Dictionary<TipoAllenamento, IConfiguraPianoAllenamento>();
                _dictionary.Add(TipoAllenamento.Ipertrofia, new ConfiguraPianoAllenamentoIpertrofia());
                _dictionary.Add(TipoAllenamento.Tonificazione, new ConfiguraPianoAllenamentoTonificazione());
                _dictionary.Add(TipoAllenamento.Definizione, new ConfiguraPianoAllenamentoDefinizione());
            }

            public static IConfiguraPianoAllenamento GetConfiguraPianoAllenamento(TipoAllenamento tipo)
            {
                if (!_dictionary.ContainsKey(tipo))
                    throw new ArgumentException();
                return _dictionary[tipo];
            }
        }
}
