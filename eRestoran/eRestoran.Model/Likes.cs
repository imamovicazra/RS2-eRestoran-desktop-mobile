using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Likes
    {
        public int LikeID { get; set; }
        public int? KorisnikID { get; set; }
        public int? JeloID { get; set; }
        public DateTime? Datum { get; set; }

        public string KorisnikIme { get; set; }
        public string JeloNaziv { get; set; }
    }
}
