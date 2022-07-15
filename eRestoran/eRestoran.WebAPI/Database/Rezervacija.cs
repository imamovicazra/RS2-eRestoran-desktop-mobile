using System;
using System.Collections.Generic;

#nullable disable

namespace eRestoran.WebAPI.Database
{
    public partial class Rezervacija
    {
        public int RezervacijaID { get; set; }
        public DateTime? DatumRezervacije { get; set; }
        public int? BrojMjesta { get; set; }
        public string Telefon { get; set; }
        public int? KorisnikID { get; set; }
        public int? UposlenikID { get; set; }
        public int? StatusID { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Status Status { get; set; }
        public virtual Korisnik Uposlenik { get; set; }
    }
}
