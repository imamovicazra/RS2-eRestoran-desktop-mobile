using System;
using System.Collections.Generic;

#nullable disable

namespace eRestoran.WebAPI.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Korisniks = new HashSet<Korisnik>();
        }

        public int GradID { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Korisnik> Korisniks { get; set; }
    }
}
