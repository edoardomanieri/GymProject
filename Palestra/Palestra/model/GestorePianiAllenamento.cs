using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class GestorePianiAllenamento
    {
        private readonly Utente _utente;
        private PianoAllenamento _pianoAllenamento;
        private IConfiguraPianoAllenamentoAutomatico _configuraPianoAllenamentoAutomatico;

        public PianoAllenamento PianoAllenamento { get => _pianoAllenamento; set => _pianoAllenamento = value; }

        public Utente Utente => _utente;

        public GestorePianiAllenamento(Utente utente)
        {
            _utente = utente;
            if (utente is UtenteAutomatico)
            {
                UtenteAutomatico utenteAutomatico = (UtenteAutomatico)utente;
                _configuraPianoAllenamentoAutomatico = ConfiguraPianoAllenamentoFactory.GetConfiguraPianoAllenamentoAutomatico(utenteAutomatico.Tipo);
                PianoAllenamento =  _configuraPianoAllenamentoAutomatico.ConfiguraPianoAllenamentoAutomatico(utenteAutomatico);
            }
        }


        public void ConfiguraPianoAllenamentoManuale(PianoAllenamento pianoAllenamento)
        {
            PianoAllenamento = pianoAllenamento;
        }
    }
}
