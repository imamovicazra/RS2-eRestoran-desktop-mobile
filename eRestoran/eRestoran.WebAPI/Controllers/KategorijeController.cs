using eRestoran.Model.Requests;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorijaController : CRUDController<Model.Kategorije, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
        public KategorijaController(ICRUDService<Model.Kategorije, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest> service) : base(service)
        {
        }

       
    }
}
