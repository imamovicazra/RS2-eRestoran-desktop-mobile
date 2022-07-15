using System;
using System.Collections.Generic;

#nullable disable

namespace eRestoran.WebAPI.Database
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            NarudzbaDetaljis = new HashSet<NarudzbaDetalji>();
        }

        public int NarudzbaID { get; set; }
        public DateTime? DatumNarudzbe { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public int? KorisnikID { get; set; }
        public int? UposlenikID { get; set; }
        public int? StatusID { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Status Status { get; set; }
        public virtual Korisnik Uposlenik { get; set; }
        public virtual ICollection<NarudzbaDetalji> NarudzbaDetaljis { get; set; }
    }
}
