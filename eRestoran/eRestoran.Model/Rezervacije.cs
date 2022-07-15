using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eRestoran.Model
{
    public class Rezervacije
    {
        public int RezervacijaID { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int? BrojMjesta { get; set; }
        public string Telefon { get; set; }
        public int? KorisnikID { get; set; }
        public int? UposlenikID { get; set; }
        public int? StatusID { get; set; }

        [ForeignKey(nameof(KorisnikID))]
        public  Korisnici Korisnik { get; set; }
        [ForeignKey(nameof(StatusID))]
        public  Statusi Status { get; set; }
        [ForeignKey(nameof(UposlenikID))]
        public  Korisnici Uposlenik { get; set; }
        public string ImePrezime { get; set; }
        public string StatusNaziv { get; set; }
    }
}
