using System;
using System.Collections.Generic;

#nullable disable

namespace eRestoran.WebAPI.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            KorisnikUlogas = new HashSet<KorisnikUloga>();
        }

        public int UlogaID { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
    }
}
