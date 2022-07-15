using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Requests
{
    public class JelaSearchRequest
    {
        public int KategorijaID { get; set; }
        public string Naziv { get; set; }
        public string Kategorija { get; set; }
    }
}
