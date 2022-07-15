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
    public class RezervacijaService : CRUDService<Model.Rezervacije, RezervacijaSearchRequest, eRestoran.WebAPI.Database.Rezervacija,RezervacijaUpsertRequest, RezervacijaUpsertRequest>, IRezervacijaService
    {
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;
        public RezervacijaService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Rezervacije>> Get(RezervacijaSearchRequest request)
        {
            var query = _context.Set<Rezervacija>()
                .Include(s => s.Status)
                .Include(k => k.Korisnik)
                .AsNoTracking()
                .OrderByDescending(i => i.DatumRezervacije)
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
            var model = _mapper.Map<List<Model.Rezervacije>>(list);
            foreach (var x in model)
            {
                x.ImePrezime = x.Korisnik.Ime + " " + x.Korisnik.Prezime;
            }

            return model;
        }

        public override async Task<Model.Rezervacije> GetById(int id)
        {
            var entity = await _context.Set<Rezervacija>()
                 .Include(s => s.Status)
                 .Include(k => k.Korisnik)
                 .Include(u => u.Uposlenik)
                 .AsNoTracking()
                 .SingleOrDefaultAsync(i => i.RezervacijaID == id);

            var model = _mapper.Map<Model.Rezervacije>(entity);
            model.ImePrezime = model.Korisnik.Ime + " " + model.Korisnik.Prezime;
            return model;
        }

        public async Task<Model.Rezervacije> Insert(int korisnikID, RezervacijaUpsertRequest request)
        {
            var entity = _mapper.Map<Rezervacija>(request);
            entity.KorisnikID = korisnikID;
            entity.StatusID = 3;
            await _context.Rezervacijas.AddAsync(entity);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Greska:", ex.InnerException);
            }
            

          
            return _mapper.Map<Model.Rezervacije>(entity);
        }

        public async Task<Model.Rezervacije> UpdateStatusDostave(int id, int korisnikID, int statusID)
        {
            var entity = await _context.Set<Rezervacija>().FindAsync(id);

            _context.Set<Rezervacija>().Attach(entity);
            _context.Set<Rezervacija>().Update(entity);

            entity.StatusID = statusID;
            entity.UposlenikID = korisnikID;


            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Rezervacije>(entity);

        }

        
    }
}
