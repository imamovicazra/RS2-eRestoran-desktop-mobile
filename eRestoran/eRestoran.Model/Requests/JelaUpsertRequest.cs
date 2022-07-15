using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace eRestoran.Model.Requests
{
    public class JelaUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public double Cijena { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        [Required]
        public int? KategorijaID { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        public bool? Favorit { get; set; }
    }
}
