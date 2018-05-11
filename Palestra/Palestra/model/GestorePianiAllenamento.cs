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
        private IConfiguraPianoAllenamento _configuraPianoAllenamento;
        private List<Esercizio> _esercizi;

        public PianoAllenamento PianoAllenamento { get => _pianoAllenamento; set => _pianoAllenamento = value; }
        public Utente Utente => _utente;

        public GestorePianiAllenamento(UtenteAutomatico utente, List<Esercizio> esercizi)
        {
            _utente = utente;
            _esercizi = esercizi;
            _configuraPianoAllenamento = ConfiguraPianoAllenamentoFactory.GetConfiguraPianoAllenamento(utente.Tipo);
            PianoAllenamento =  _configuraPianoAllenamento.Configura(utente, _esercizi);
        }

    }
}
