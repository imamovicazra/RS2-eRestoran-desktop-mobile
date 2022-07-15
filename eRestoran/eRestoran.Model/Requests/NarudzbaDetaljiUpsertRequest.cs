using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace eRestoran.Model.Requests
{
    public class NarudzbaDetaljiUpsertRequest
    {
        public int? NarudzbaID { get; set; }
        [Required]
        public int? JeloID { get; set; }
        [Required]
        public int? Kolicina { get; set; }
        [Required]
        public decimal? Cijena { get; set; }
    }
}
