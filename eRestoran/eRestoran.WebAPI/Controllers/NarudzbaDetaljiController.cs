using eRestoran.Model.Requests;
using eRestoran.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Controllers
{
    public class NarudzbaDetaljiController : CRUDController<Model.NarudzbaDetalji, NarudzbaDetaljiSearchRequest, NarudzbaDetaljiUpsertRequest, NarudzbaDetaljiUpsertRequest>
    {
        public NarudzbaDetaljiController(ICRUDService<Model.NarudzbaDetalji, NarudzbaDetaljiSearchRequest, NarudzbaDetaljiUpsertRequest, NarudzbaDetaljiUpsertRequest> service) : base(service)
        {
        }
    }
}
