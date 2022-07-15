using System;
using System.Collections.Generic;

#nullable disable

namespace eRestoran.WebAPI.Database
{
    public partial class Jelo
    {
        public Jelo()
        {
            Likes = new HashSet<Like>();
            NarudzbaDetaljis = new HashSet<NarudzbaDetalji>();
        }

        public int JeloID { get; set; }
        public string Naziv { get; set; }
        public decimal? Cijena { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int? KategorijaID { get; set; }
        public string Opis { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<NarudzbaDetalji> NarudzbaDetaljis { get; set; }
    }
}
