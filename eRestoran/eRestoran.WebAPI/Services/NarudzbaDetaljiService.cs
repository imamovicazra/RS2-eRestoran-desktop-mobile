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
    public class NarudzbaDetaljiService :
           CRUDService<Model.NarudzbaDetalji, NarudzbaDetaljiSearchRequest,eRestoran.WebAPI.Database.NarudzbaDetalji, NarudzbaDetaljiUpsertRequest, NarudzbaDetaljiUpsertRequest>
    {
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;
        public NarudzbaDetaljiService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async override Task<List<Model.NarudzbaDetalji>> Get(NarudzbaDetaljiSearchRequest search)
        {
            var query = _context.Set<NarudzbaDetalji>()
                .Include(j => j.Jelo)
                .Include(n => n.Narudzba)
                .AsNoTracking()
                .AsQueryable();
            if (search != null)
            {
                if (search.JeloID != 0)
                {
                    query = query.Where(i => i.JeloID == search.JeloID);
                }
                if (search.NarudzbaID != 0)
                {
                    query = query.Where(i => i.NarudzbaID == search.NarudzbaID);
                }
            }
            try
            {
                var list = await query.ToListAsync();
                var model= _mapper.Map<List<Model.NarudzbaDetalji>>(list);
                foreach (var x in model)
                {
                    x.NazivJela = x.Jelo.Naziv;
                    x.Cijena = x.Jelo.Cijena * x.Kolicina;
                }
                return model;
            }
            catch (Exception ex)
            {

                throw new Exception("Greska", ex.InnerException);
            }
            
            
        }
    }
}
