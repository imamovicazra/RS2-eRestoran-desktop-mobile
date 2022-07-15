using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public interface IKorisniciService: ICRUDService<Model.Korisnici, KorisniciSearchRequest, KorisniciInsertRequest, KorisniciUpdateRequest>
    {
        public Task<Model.Korisnici> Authenticiraj(KorisnikAuthenticationRequest request);
        public Task<List<Model.Jela>> GetLajkanaJela(int id);



    }
}
