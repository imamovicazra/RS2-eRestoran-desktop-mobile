using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace eRestoran.Model.Requests
{
    public class GradUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
    }
}
