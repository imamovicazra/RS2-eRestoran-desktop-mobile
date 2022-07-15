using eRestoran.Model.Requests;
using eRestoran.WebAPI.Extensions;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervacijaController : BaseController<Model.Rezervacije, RezervacijaSearchRequest>
    {
        private readonly IRezervacijaService _service;
        public RezervacijaController(IRezervacijaService service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<Model.Rezervacije> Insert(RezervacijaUpsertRequest request)
        {
            var ID = HttpContext.GetUserID();

            if (ID == null)
            {
                throw new Exception("Bad request");
            }


            var response = await _service.Insert((int)ID, request);
            if (response == null)
            {
                throw new Exception("Bad request");
            }

            PathString path = HttpContext.Request.Path;
            //return Created(path, response);
            return response;
        }

        [HttpPatch("{id}/Status/{statusID}")]
        public async Task<Model.Rezervacije> UpdateStatus(int id, int statusID)
        {
            var korisnikID = HttpContext.GetUserID();
            if (korisnikID == null)
            {
                throw new Exception("Bad request");
            }

            var response = await _service.UpdateStatusDostave(id, (int)korisnikID, statusID);

            if (response == null)
            {
                throw new Exception("Not found");
            }

            return response;
        }

        
    }
}
