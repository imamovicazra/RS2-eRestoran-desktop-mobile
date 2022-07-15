using System;
using System.Collections.Generic;

#nullable disable

namespace eRestoran.WebAPI.Database
{
    public partial class NarudzbaDetalji
    {
        public int NarudzbaDetaljiID { get; set; }
        public int? NarudzbaID { get; set; }
        public int? JeloID { get; set; }
        public int? Kolicina { get; set; }
        public decimal? Cijena { get; set; }

        public virtual Jelo Jelo { get; set; }
        public virtual Narudzba Narudzba { get; set; }
    }
}
