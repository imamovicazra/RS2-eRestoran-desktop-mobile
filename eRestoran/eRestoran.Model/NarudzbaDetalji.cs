using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class NarudzbaDetalji
    {
        public int NarudzbaDetaljiID { get; set; }
        public int? NarudzbaID { get; set; }
        public int? JeloID { get; set; }
        public int? Kolicina { get; set; }
        public decimal? Cijena { get; set; }

        public  Jela Jelo { get; set; }
        public string NazivJela { get; set; }
    }
}
