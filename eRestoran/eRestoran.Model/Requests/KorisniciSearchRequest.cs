using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class KorisniciSearchRequest
    {
        public string KorisnickoIme  { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int UlogaId { get; set; }
    }
}
