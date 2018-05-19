using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.model
{
    public class GestorePianiAllenamento
    {
        private Dictionary<Utente, PianoAllenamento> _pianiAllenamento;
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

        public PianoAllenamento getPianoAllenamento(UtenteAutomatico utente, List<Esercizio> esercizi)
        {
            if (_pianiAllenamento == null)
                _pianiAllenamento = new Dictionary<Utente, PianoAllenamento>();
            if (_pianiAllenamento.ContainsKey(utente))
                return _pianiAllenamento[utente]; 
            IConfiguraPianoAllenamento configuraPianoAllenamento = ConfiguraPianoAllenamentoFactory.GetConfiguraPianoAllenamento(utente.Tipo);
            PianoAllenamento pianoAllenamento = configuraPianoAllenamento.Configura(utente, esercizi);
            _pianiAllenamento.Add(utente, pianoAllenamento);
            return pianoAllenamento;
        }



    }
}
