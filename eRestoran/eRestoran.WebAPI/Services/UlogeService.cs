using AutoMapper;
using eRestoran.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class UlogeService : BaseService<Model.Uloge, object, Database.Uloga>
    {
        public UlogeService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
