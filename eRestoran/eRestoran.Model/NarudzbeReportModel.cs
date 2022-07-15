using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class NarudzbeReportModel
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public DateTime Datum { get; set; }
        public decimal NarudzbaUkupno { get; set; }
    }
}
