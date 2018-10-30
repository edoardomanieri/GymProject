using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.model
{
    public class GestorePianiAllenamento
    {
        private static GestorePianiAllenamento _instance;

        private GestorePianiAllenamento() { }

        public static GestorePianiAllenamento Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new GestorePianiAllenamento();
                }
                return _instance;
            }
        }

        public PianoAllenamento getOrUpdatePianoAllenamento(UtenteAutomatico utente, List<Esercizio> esercizi)
        {
            IConfiguraPianoAllenamento configuraPianoAllenamento = ConfiguraPianoAllenamentoFactory.GetConfiguraPianoAllenamento(utente.Tipo);
            PianoAllenamento pianoAllenamento = configuraPianoAllenamento.Configura(utente, esercizi);
            return pianoAllenamento;
        }





    }
}
