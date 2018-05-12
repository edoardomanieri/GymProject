using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class Allenamento : IPersistable
    {
        private readonly int _durataInMinuti;
        private readonly DateTime _data;
        private readonly int _pesoInKg;
        private int _ID;

        public int DurataInMinuti => _durataInMinuti;

        public DateTime Data => _data;

        public int PesoInKg => _pesoInKg;

        public int ID { get => _ID; set => _ID = value; }

        public Allenamento(int durataInMinuti, DateTime data, int pesoInKg)
        {
            _durataInMinuti = durataInMinuti;
            _data = data;
            _pesoInKg = pesoInKg;
        }

        public Allenamento(int durataInMinuti, DateTime data)
        {
            _durataInMinuti = durataInMinuti;
            _data = data;
        }


    }
}
