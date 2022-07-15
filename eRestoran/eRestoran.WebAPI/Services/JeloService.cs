using AutoMapper;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model;
using Microsoft.EntityFrameworkCore;
using eRestoran.WebAPI.Database;

namespace eRestoran.Services
{
    public class JeloService : CRUDService<Model.Jela, JelaSearchRequest,eRestoran.WebAPI.Database.Jelo, JelaUpsertRequest, JelaUpsertRequest>, IJeloService
    {
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;
        public JeloService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Jela>> Get(JelaSearchRequest request)
        {
            var query = _context.Jelos.Include(s=>s.Kategorija).AsQueryable();

            if (!string.IsNullOrEmpty(request.Naziv))
            {
                query = query.Where(x => x.Naziv.Contains(request.Naziv));

            }
            if (!string.IsNullOrEmpty(request.Kategorija))
            {
                query = query.Where(x => x.Kategorija.Naziv.StartsWith(request.Kategorija));

            }
            if (request.KategorijaID != 0)
            {
                query = query.Where(x => x.KategorijaID == request.KategorijaID);
            }


            var list = await query.ToListAsync();
            return _mapper.Map<List<Model.Jela>>(list);
        }

        public async Task<Model.Jela> Like(int JeloID, int KorisnikID)
        {
            var entity = new Like
            {
                JeloID = JeloID,
                KorisnikID = KorisnikID,
                Datum = DateTime.Now
            };

            await _context.Likes.AddAsync(entity);
            await _context.SaveChangesAsync();
            var jelo = _context.Jelos.FindAsync(entity.JeloID).Result;

            return _mapper.Map<Model.Jela>(jelo);
        }
        public async Task<bool> Dislike(int JeloID, int KorisnikID)
        {
            //var entity = await _context.Likes.FindAsync(JeloID,KorisnikID);
            var entity = await _context.Likes.Where(s => s.KorisnikID == KorisnikID && s.JeloID == JeloID).FirstOrDefaultAsync();
            if (entity != null)
            {
                _context.Remove(entity);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

       


    }
}
