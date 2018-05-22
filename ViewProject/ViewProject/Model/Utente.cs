using ViewProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.model
{
    public class Utente 
    {
        private string _username;
        private string _nome;
        private string _cognome;
        private DateTime _dataDiNascita;
        private int _pesoInKg;
        private int _altezzaInCm;
        private Sesso _sesso;
        private string _fotoPath;

        public Utente(string username, string nome, string cognome, DateTime dataDiNascita, int pesoInKg, int altezzaInCm, Sesso sesso)
        {
            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(cognome) || dataDiNascita == null || pesoInKg <= 0 || altezzaInCm <= 0|| String.IsNullOrEmpty(username))
                throw new ArgumentException();
            _username = username;
            _nome = nome;
            _cognome = cognome;
            _dataDiNascita = dataDiNascita;
            _pesoInKg = pesoInKg;
            _altezzaInCm = altezzaInCm;
            _sesso = sesso;
        }

        public string Nome
        {
            get => _nome;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException();
                _nome = value;
            }
        }
        public string Cognome
        {
            get => _cognome;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException();
                _cognome = value;
            }
        }
        public DateTime DataDiNascita { get => _dataDiNascita; set => _dataDiNascita = value; }
        public int PesoInKg
        {
            get => _pesoInKg;
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _pesoInKg = value;
            }
        }
        public int AltezzaInCm
        {
            get => _altezzaInCm;
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _altezzaInCm = value;
            }
        }
        public Sesso Sesso { get => _sesso; set => _sesso = value; }
        public string Username
        {
            get => _username;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException();
                _username = value;
            }
        }

        public string FotoPath { get => _fotoPath; set => _fotoPath = value; }

        public override bool Equals(object obj)
        {
            var utente = obj as Utente;
            return utente != null &&
                   _username == utente.Username;
        }

        public override string ToString()
        {
            return _nome + _cognome +
                "Sesso: " + _sesso.ToString() +
                "\nData di nascita: " + _dataDiNascita.ToString() + "\n" +
                "Peso: " + _pesoInKg + " Kg" +
                "\nAltezza: " + _altezzaInCm + " cm";
        }
    }
}
