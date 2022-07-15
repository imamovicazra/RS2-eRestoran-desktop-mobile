using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class GradService : CRUDService<Model.Gradovi, GradSearchRequest, Database.Grad, GradUpsertRequest, GradUpsertRequest>
    {
        protected eRestoranContext _context { get; set; }

        protected readonly IMapper _mapper;
        public GradService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Gradovi>> Get(GradSearchRequest request)
        {
            var query = _context.Grads.AsQueryable();
            if (!string.IsNullOrEmpty(request.Naziv))
            {
                query = query.Where(x => x.Naziv == request.Naziv);

            }

            var list = await query.ToListAsync();
            return _mapper.Map<List<Model.Gradovi>>(list);
        }


    }
}
