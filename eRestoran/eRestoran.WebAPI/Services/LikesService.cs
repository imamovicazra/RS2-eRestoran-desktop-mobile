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
    public class LikesService : CRUDService<Model.Likes, LikesSearchRequest, Database.Like, LikesUpsertRequest,LikesUpsertRequest>
    {
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;
        public LikesService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Likes>> Get(LikesSearchRequest search)
        {
            var query = _context.Likes.Include(x => x.Jelo).Include(y => y.Korisnik).AsQueryable();
            if (search.JeloID != 0)
            {
                query = query.Where(x => x.JeloID == search.JeloID);

            }
            if (search.KorisnikID != 0)
            {
                query = query.Where(x => x.KorisnikID == search.KorisnikID);
            }
            query = query.OrderByDescending(x => x.Datum);
            var list = await query.ToListAsync();
            return _mapper.Map<List<Model.Likes>>(list);
        }

    }
}
