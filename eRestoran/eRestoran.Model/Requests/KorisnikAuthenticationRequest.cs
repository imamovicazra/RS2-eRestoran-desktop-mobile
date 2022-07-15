using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class KorisnikAuthenticationRequest
    {
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        public string Lozinka { get; set; }
    }
}
