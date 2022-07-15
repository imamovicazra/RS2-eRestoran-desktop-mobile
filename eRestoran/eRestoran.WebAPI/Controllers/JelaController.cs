using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eRestoran.Services;
using eRestoran.WebAPI.Controllers;
using eRestoran.Model.Requests;
using eRestoran.Model;
using eRestoran.WebAPI.Extensions;
using Microsoft.AspNetCore.Http;

namespace eRestoran.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JeloController : CRUDController<Model.Jela, JelaSearchRequest, JelaUpsertRequest, JelaUpsertRequest>
    {
        private readonly IJeloService _jeloService;
        public JeloController(IJeloService jeloService) : base(jeloService)
        {
            _jeloService = jeloService;
        }

        [HttpPost("{id}/Like")]
        public async Task<Model.Jela> Like(int id)
        {
            var KorisnikID = HttpContext.GetUserID();

            if (KorisnikID == null)
            {
                throw new Exception("Bad request");
            }

            return await _jeloService.Like(id, (int)KorisnikID);
        }

        [HttpDelete("{id}/Like")]
        public async Task<bool> Dislike(int id)
        {
            var KorisnikID = HttpContext.GetUserID();

            if (KorisnikID == null)
            {
                throw new Exception("Bad request");
            }

            var response = await _jeloService.Dislike(id, (int)KorisnikID);

            if (!response)
            {
                throw new Exception("Bad request");
            }

            return response;
        }



    }
}
