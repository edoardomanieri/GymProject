using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra.model
{
    public class Allenamento
    {
        private readonly int _durataInMinuti;
        private readonly DateTime _data;
        private readonly int _pesoInKg;

        public int DurataInMinuti => _durataInMinuti;

        public DateTime Data => _data;

        public int PesoInKg => _pesoInKg;

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
