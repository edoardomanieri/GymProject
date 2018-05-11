﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class UtenteAutomatico : Utente
    {
        private readonly TipoAllenamento _tipo;
        private readonly Risorsa _risorse;
        private readonly int _numeroAllenamentiSettimanali;
        private PianoAllenamento _pianoAllenamento;

        public UtenteAutomatico(string nome, string cognome, DateTime dataDiNascita, int pesoInKg, int altezzaInCm,  Sesso sesso,  TipoAllenamento tipo, Risorsa risorse, int numeroAllenamentiSettimanali) : base(nome, cognome,  dataDiNascita,  pesoInKg,  altezzaInCm, sesso)
        {
            _tipo = tipo;
            _risorse = risorse;
            _numeroAllenamentiSettimanali = numeroAllenamentiSettimanali;

        }

        public override PianoAllenamento GetPianoAllenamento(List<Esercizio> esercizi)
        {
            IConfiguraPianoAllenamento configuraPianoAllenamento = ConfiguraPianoAllenamentoFactory.GetConfiguraPianoAllenamento(Tipo);
            return configuraPianoAllenamento.Configura(this, esercizi);
        }

        public int NumeroAllenamentiSettimanali => _numeroAllenamentiSettimanali;

        public Risorsa Risorse => _risorse;

        public TipoAllenamento Tipo => _tipo;
    }
}