using System;
using System.Collections.Generic;

#nullable disable

namespace eRestoran.WebAPI.Database
{
    public partial class Like
    {
        public int LikeID { get; set; }
        public int? KorisnikID { get; set; }
        public int? JeloID { get; set; }
        public DateTime? Datum { get; set; }

        public virtual Jelo Jelo { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
