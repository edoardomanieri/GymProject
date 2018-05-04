using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class ConfiguraPianoAllenamentoFactory
    {
            private static readonly Dictionary<TipoAllenamento, IConfiguraPianoAllenamentoAutomatico> _dictionary;

            static ConfiguraPianoAllenamentoFactory()
            {
                _dictionary = new Dictionary<TipoAllenamento, IConfiguraPianoAllenamentoAutomatico>();
                _dictionary.Add(TipoAllenamento.Ipertrofia, new ConfiguraPianoAllenamentoAutomaticoIpertrofia());
                _dictionary.Add(TipoAllenamento.Tonificazione, new ConfiguraPianoAllenamentoAutomaticoTonificazione());
                _dictionary.Add(TipoAllenamento.Forza, new ConfiguraPianoAllenamentoAutomaticoForza());
                _dictionary.Add(TipoAllenamento.Definizione, new ConfiguraPianoAllenamentoAutomaticoDefinizione());
            }

            public static IConfiguraPianoAllenamentoAutomatico GetConfiguraPianoAllenamentoAutomatico(TipoAllenamento tipo)
            {
                if (!_dictionary.ContainsKey(tipo))
                    throw new ArgumentException();
                return _dictionary[tipo];
            }
        }
}
