using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Narudzbe
    {
        public int NarudzbaID { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public int? KorisnikID { get; set; }
        public int? UposlenikID { get; set; }
        public int? StatusID { get; set; }

        public  Korisnici Korisnik { get; set; }
        public  Statusi Status { get; set; }
        public  Korisnici Uposlenik { get; set; }
        public List<Model.NarudzbaDetalji> NarudzbaDetaljis { get; set; }

        public string ImePrezime { get; set; }
        public string StatusNaziv { get; set; }
    }
}
