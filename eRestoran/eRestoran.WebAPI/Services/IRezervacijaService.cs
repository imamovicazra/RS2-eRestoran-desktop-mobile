using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public interface IRezervacijaService : ICRUDService<Model.Rezervacije, RezervacijaSearchRequest, RezervacijaUpsertRequest, RezervacijaUpsertRequest>
    {
        public Task<Model.Rezervacije> Insert(int korisnikID, RezervacijaUpsertRequest request);
        public Task<Model.Rezervacije> UpdateStatusDostave(int id, int korisnikID, int statusID);


    }
}
