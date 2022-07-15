using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }

        [Required]
        public string Email { get; set; }
       

        public string Telefon { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        public int GradID { get; set; }


        [Required]
        public string Lozinka { get; set; }

        [Required]
        public string LozinkaPotvrda { get; set; }
        public List<int> Uloge { get; set; } = new List<int>();

    }
}
