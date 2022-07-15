using eRestoran.Model.Requests;
using eRestoran.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Controllers
{
    public class LikesController : CRUDController<Model.Likes, LikesSearchRequest, LikesUpsertRequest, LikesUpsertRequest>
    {
        public LikesController(ICRUDService<Model.Likes, LikesSearchRequest, LikesUpsertRequest, LikesUpsertRequest> service) : base(service)
        {
        }

    }
}
