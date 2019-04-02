using ViewProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.model
{
    public class Allenamento : IPersistable
    {
        private readonly int _durataInMinuti;
        private readonly DateTime _data;
        private readonly int _pesoInKg;
        private int _ID;

        public Allenamento(int durataInMinuti, DateTime data, int pesoInKg)
        {
            if (durataInMinuti <= 0 || data == null || pesoInKg <= 0)
                throw new ArgumentException();
            _durataInMinuti = durataInMinuti;
            _data = data;
            _pesoInKg = pesoInKg;
        }

        public Allenamento(int durataInMinuti, DateTime data)
        {
            if (durataInMinuti <= 0 || data == null)
                throw new ArgumentException();
            _durataInMinuti = durataInMinuti;
            _data = data;
            _pesoInKg = 0;
        }

        public int DurataInMinuti => _durataInMinuti;

        public DateTime Data => _data;

        public int PesoInKg => _pesoInKg;

        public int ID { get => _ID; set => _ID = value; }


        public override bool Equals(object obj)
        {
            var allenamento = obj as Allenamento;
            if (allenamento == null) return false;
            if (allenamento.PesoInKg > 0 && _pesoInKg > 0)
                return allenamento != null &&
                       _durataInMinuti == allenamento.DurataInMinuti &&
                       _data == allenamento.Data &&
                       _pesoInKg == allenamento.PesoInKg;
            else if (allenamento.PesoInKg == 0 && _pesoInKg > 0)
                return false;
            else if (allenamento.PesoInKg > 0 && _pesoInKg == 0)
                return false;
            else
                return allenamento != null &&
                      _durataInMinuti == allenamento.DurataInMinuti &&
                      _data == allenamento.Data;
        }  

        public override string ToString()
        {
            if (_pesoInKg > 0)
                return "Durata: " + _durataInMinuti + " minuti\n" +
                    "Data: " + _data.ToString() + "\n" +
                    "Peso attuale: " + _pesoInKg + " Kg";
            else
                return "Durata: " + _durataInMinuti + " minuti\n" +
                    "Data: " + _data.ToString() + "\n";
        }
    }
}
