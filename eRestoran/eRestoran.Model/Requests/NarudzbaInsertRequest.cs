using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace eRestoran.Model.Requests
{
    public class NarudzbaInsertRequest
    {
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public DateTime? DatumNarudzbe { get; set; }
        [Required]
        public int StatusID { get; set; }
        public List<NarudzbaDetaljiUpsertRequest> NarudzbaDetalji { get; set; }

    }
}
