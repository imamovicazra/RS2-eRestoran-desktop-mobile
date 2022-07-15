using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class KorisniciUloge
    {
        public int KorisnikUlogaID { get; set; }
        public int KorisnikID { get; set; }
        public int UlogaID { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public  Uloge Uloga { get; set; }
    }
}
