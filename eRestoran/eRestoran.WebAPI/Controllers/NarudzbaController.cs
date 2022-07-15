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
    public class NarudzbaController : BaseController<Model.Narudzbe, NarudzbaSearchRequest>
    {
        private readonly INarudzbaService _service;
        public NarudzbaController(INarudzbaService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("{id}/Detalji")]
        public async Task<ActionResult<List<Model.NarudzbaDetalji>>> GetDetalji(int id)
        {
            var list = await _service.GetDetalji(id);

            return Ok(list);
        }

        [HttpPost]
        public async Task<Model.Narudzbe> Insert(NarudzbaInsertRequest request)
        {
            var ID = HttpContext.GetUserID();

            if (ID == null)
            {
                throw new Exception("Not found");
            }


            var response = await _service.Insert((int)ID, request);
            if (response == null)
            {
                throw new Exception("Not found");
            }

            return response;
        }
        [HttpPatch("{id}/Status/{statusID}")]
        public async Task<Model.Narudzbe> UpdateStatus(int id, int statusID)
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
