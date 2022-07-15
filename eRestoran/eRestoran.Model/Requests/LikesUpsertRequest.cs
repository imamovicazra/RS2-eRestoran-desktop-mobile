using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace eRestoran.Model.Requests
{
    public class LikesUpsertRequest
    {
        [Required]
        public int KorisnikID { get; set; }
        [Required]
        public int JeloID { get; set; }
        [Required]
        public DateTime? Datum { get; set; }
    }
}
