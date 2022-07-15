using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.WebAPI.Database;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogeController : BaseController<Model.Uloge, object>
    {
        public UlogeController(IBaseService<Model.Uloge, object> service) : base(service)
        {
        }
    }
}
