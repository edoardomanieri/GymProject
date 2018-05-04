using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public interface IConfiguraPianoAllenamentoAutomatico
    {
        PianoAllenamento ConfiguraPianoAllenamentoAutomatico(UtenteAutomatico utenteAutomatico);
    }
}
