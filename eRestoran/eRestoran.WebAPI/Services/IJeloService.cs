using eRestoran.Model.Requests;
using eRestoran.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Services
{
    public interface IJeloService : ICRUDService<Model.Jela, JelaSearchRequest, JelaUpsertRequest, JelaUpsertRequest>
    {
        public Task<Model.Jela> Like(int JeloID, int KorisnikID);
        public Task<bool> Dislike(int JeloID, int KorisnikID);
    }
}
