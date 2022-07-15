using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class KorisniciUpdateRequest
    {
        [Required(ErrorMessage = "Obavezan unos")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Obavezan unos")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Obavezan unos")]
        //[EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obavezan unos")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Obavezan unos")]
        public string KorisnickoIme { get; set; }
        public int GradID { get; set; }

        
        public string Lozinka { get; set; }
        
        public string LozinkaPotvrda { get; set; }
        public List<int> Uloge { get; set; } = new List<int>();
        public List<int> UlogeZaObrisati { get; set; } = new List<int>();

    }
}
