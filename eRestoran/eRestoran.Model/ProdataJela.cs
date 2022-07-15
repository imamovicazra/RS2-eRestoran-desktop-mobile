using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class ProdataJela
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }
        public int Kolicina { get; set; }
        public decimal UkupnaCijena { get; set; }
    }
}
