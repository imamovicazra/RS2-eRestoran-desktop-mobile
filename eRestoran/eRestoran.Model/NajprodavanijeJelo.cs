using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class NajprodavanijeJelo
    {
        public int JeloID { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int BrojNarudzbi { get; set; }
        public int KolicinaProdatih { get; set; }
    }
}
