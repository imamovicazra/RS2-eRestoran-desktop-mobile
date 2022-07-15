using System;
using System.Collections.Generic;

#nullable disable

namespace eRestoran.WebAPI.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            KorisnikUlogas = new HashSet<KorisnikUloga>();
            Likes = new HashSet<Like>();
            NarudzbaKorisniks = new HashSet<Narudzba>();
            NarudzbaUposleniks = new HashSet<Narudzba>();
            RezervacijaKorisniks = new HashSet<Rezervacija>();
            RezervacijaUposleniks = new HashSet<Rezervacija>();
        }

        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public int? GradID { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Narudzba> NarudzbaKorisniks { get; set; }
        public virtual ICollection<Narudzba> NarudzbaUposleniks { get; set; }
        public virtual ICollection<Rezervacija> RezervacijaKorisniks { get; set; }
        public virtual ICollection<Rezervacija> RezervacijaUposleniks { get; set; }
    }
}
