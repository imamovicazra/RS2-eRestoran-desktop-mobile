using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public interface INarudzbaService : ICRUDService<Model.Narudzbe, NarudzbaSearchRequest, NarudzbaInsertRequest, NarudzbaUpdateRequest>
    {
        public Task<Model.Narudzbe> Insert(int korisnikID, NarudzbaInsertRequest request);
        public Task<Model.Narudzbe> UpdateStatusDostave(int id, int korisnikID, int statusID);
        public Task<List<Model.NarudzbaDetalji>> GetDetalji(int id);


    }
}
