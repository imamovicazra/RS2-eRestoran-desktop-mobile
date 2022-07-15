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
    public class NarudzbaService : CRUDService<Model.Narudzbe, NarudzbaSearchRequest, eRestoran.WebAPI.Database.Narudzba, NarudzbaInsertRequest, NarudzbaUpdateRequest>, INarudzbaService
    {
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;
        public NarudzbaService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Narudzbe>> Get(NarudzbaSearchRequest request)
        {
            var query = _context.Set<Narudzba>()
                .Include(s => s.Status)
                .Include(k => k.Korisnik)
                .AsNoTracking()
                .OrderByDescending(i => i.DatumNarudzbe)
                .AsQueryable();

            if (request != null)
            {
                if (!string.IsNullOrEmpty(request.Prezime) || !string.IsNullOrEmpty(request.Ime))
                {
                    query = query.Where(i =>
                        (
                            !string.IsNullOrWhiteSpace(request.Ime) &&
                            i.Korisnik.Ime.StartsWith(request.Ime)
                        ) ||
                        (
                            !string.IsNullOrWhiteSpace(request.Prezime) &&
                            i.Korisnik.Prezime.StartsWith(request.Prezime)
                        )
                    );

                }
            }
            var list = await query.ToListAsync();
            var model=_mapper.Map<List<Model.Narudzbe>>(list);
            foreach (var x in model)
            {
                x.ImePrezime = x.Korisnik.Ime + " " + x.Korisnik.Prezime;
                
            }

            return model;
        }

        public override async Task<Model.Narudzbe> GetById(int id)
        {
            var entity = await _context.Set<Narudzba>()
                 .Include(s => s.Status)
                 .Include(k => k.Korisnik)
                 .Include(u => u.Uposlenik)
                 .AsNoTracking()
                 .SingleOrDefaultAsync(i => i.NarudzbaID == id);

            var model=_mapper.Map<Model.Narudzbe>(entity);
            model.ImePrezime = model.Korisnik.Ime + " " + model.Korisnik.Prezime;
            return model;
        }

        public async Task<Model.Narudzbe> Insert(int korisnikID, NarudzbaInsertRequest request)
        {
            var entity = _mapper.Map<Narudzba>(request);
            List<Database.NarudzbaDetalji> list = new List<Database.NarudzbaDetalji>();
            foreach (var item in request.NarudzbaDetalji)
            {
                Database.NarudzbaDetalji detalj = new Database.NarudzbaDetalji
                {
                    NarudzbaID = item.NarudzbaID,
                    Cijena = item.Cijena,
                    JeloID = item.JeloID,
                    Kolicina = item.Kolicina, 
                };

                list.Add(detalj);
            }
            entity.NarudzbaDetaljis = list;
            entity.KorisnikID = korisnikID;
            entity.StatusID = 3;
            await _context.Narudzbas.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach (var detalj in request.NarudzbaDetalji)
            {
                detalj.NarudzbaID = entity.NarudzbaID;
            }
            var detalji = _mapper.Map<List<NarudzbaDetalji>>(request.NarudzbaDetalji);
            _context.NarudzbaDetaljis.AddRange(detalji);
            await _context.SaveChangesAsync();
            return _mapper.Map<Model.Narudzbe>(entity);
        }
        public async Task<Model.Narudzbe> UpdateStatusDostave(int id, int korisnikID, int statusID)
        {
            var entity = await _context.Set<Narudzba>().FindAsync(id);

            _context.Set<Narudzba>().Attach(entity);
            _context.Set<Narudzba>().Update(entity);

            entity.StatusID = statusID;
            entity.UposlenikID = korisnikID;


            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Narudzbe>(entity);

        }

        public async Task<List<Model.NarudzbaDetalji>> GetDetalji(int id)
        {
            var list = await _context.NarudzbaDetaljis
                .Include(i => i.Jelo)
                .Where(i => i.NarudzbaID == id)
                .ToListAsync();

            return _mapper.Map<List<Model.NarudzbaDetalji>>(list);
        }

       



    }
}
