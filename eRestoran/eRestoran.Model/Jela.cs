using System;

namespace eRestoran.Model
{
    public class Jela
    {

        public int JeloID { get; set; }
        public string Naziv { get; set; }
        public decimal? Cijena { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int? KategorijaID { get; set; }
        public bool? Favorit { get; set; }
        public string Opis { get; set; }

        public Kategorije Kategorija { get; set; }
    }
}
