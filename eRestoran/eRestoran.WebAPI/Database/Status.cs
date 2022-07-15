using System;
using System.Collections.Generic;

#nullable disable

namespace eRestoran.WebAPI.Database
{
    public partial class Status
    {
        public Status()
        {
            Narudzbas = new HashSet<Narudzba>();
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public int StatusID { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Narudzba> Narudzbas { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
