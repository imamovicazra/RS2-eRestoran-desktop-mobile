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
    public class KategorijaService : CRUDService<Model.Kategorije, KategorijaSearchRequest, Kategorija, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;
        public KategorijaService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Kategorije>> Get(KategorijaSearchRequest request)
        {
            var query = _context.Kategorijas.AsQueryable();
            if (!string.IsNullOrEmpty(request.Naziv))
            {
                query = query.Where(x => x.Naziv == request.Naziv);

            }

            var list = await query.ToListAsync();
            return _mapper.Map<List<Model.Kategorije>>(list);
        }


    }
}
