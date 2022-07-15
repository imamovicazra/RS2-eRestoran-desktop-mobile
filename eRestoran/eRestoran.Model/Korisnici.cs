using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public  class Korisnici
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
       
        public int GradID { get; set; }

        public  Gradovi Grad { get; set; }
        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }



    }
}
