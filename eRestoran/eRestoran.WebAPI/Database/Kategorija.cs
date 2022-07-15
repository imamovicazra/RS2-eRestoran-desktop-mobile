using System;
using System.Collections.Generic;

#nullable disable

namespace eRestoran.WebAPI.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Jelos = new HashSet<Jelo>();
        }

        public int KategorijaID { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Jelo> Jelos { get; set; }
    }
}
