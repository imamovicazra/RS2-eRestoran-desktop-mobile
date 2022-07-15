using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Services;
using eRestoran.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using eRestoran.WebAPI.Extensions;

namespace eRestoran.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : CRUDController<Korisnici, KorisniciSearchRequest, KorisniciInsertRequest, KorisniciUpdateRequest>
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service) : base(service)
        {
            _service = service;
          
        }

        [AllowAnonymous]
        [HttpPost("Auth")]
        public async Task<Model.Korisnici> Authenticate(KorisnikAuthenticationRequest request)
        {
            return await _service.Authenticiraj(request);
        }

        [AllowAnonymous]
        [HttpPost("SignUp")]
        public async Task<Korisnici> SignUp(KorisniciInsertRequest request)
        {
            return await _service.Insert(request);
        }

        [HttpGet("Jela")]
        public async Task<List<Model.Jela>> Jela()
        {
            var ID = HttpContext.GetUserID();
            return await _service.GetLajkanaJela((int)ID);
        }
    }
}
