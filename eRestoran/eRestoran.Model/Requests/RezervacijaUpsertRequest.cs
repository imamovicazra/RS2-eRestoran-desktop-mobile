using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace eRestoran.Model.Requests
{
    public class RezervacijaUpsertRequest
    {
        [Required]
        public int BrojMjesta { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public DateTime? DatumRezervacije { get; set; }

    }
}
