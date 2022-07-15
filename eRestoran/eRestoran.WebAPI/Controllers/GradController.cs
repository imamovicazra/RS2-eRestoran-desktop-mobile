using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eRestoran.Model.Requests;
using eRestoran.Model;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace eRestoran.WebAPI.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class GradController : CRUDController<Model.Gradovi, GradSearchRequest, GradUpsertRequest, GradUpsertRequest>
    {
        public GradController(ICRUDService<Model.Gradovi, GradSearchRequest, GradUpsertRequest, GradUpsertRequest> service) : base(service)
        {
        }
    }
}
