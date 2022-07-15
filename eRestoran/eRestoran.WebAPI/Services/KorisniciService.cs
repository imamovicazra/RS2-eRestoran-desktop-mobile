using AutoMapper;
using eRestoran.Model;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using eRestoran.WebAPI.Exceptions;
using eRestoran.WebAPI.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class KorisniciService : CRUDService<Model.Korisnici, KorisniciSearchRequest, Database.Korisnik, KorisniciInsertRequest, KorisniciUpdateRequest>, IKorisniciService
    {
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;
        public KorisniciService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

       
        public override async Task<List<Model.Korisnici>> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisniks.Include(i => i.KorisnikUlogas)
                .Include(i=>i.Grad).AsQueryable();
            var uloga = _context.Ulogas.Where(s => s.UlogaID == request.UlogaId).FirstOrDefault();


            
            if (!string.IsNullOrEmpty(request.Prezime) || !string.IsNullOrEmpty(request.Ime))
            {
                query = query.Where(i =>
                    (
                        !string.IsNullOrWhiteSpace(request.Ime) &&
                        i.Ime.StartsWith(request.Ime)
                    ) ||
                    (
                        !string.IsNullOrWhiteSpace(request.Prezime) &&
                        i.Prezime.StartsWith(request.Prezime)
                    )
                    );

            }
            if (!string.IsNullOrEmpty(request.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme.Contains(request.KorisnickoIme));

            }
            if (request.UlogaId != 0)
            {
                query = query.Where(i=>i.KorisnikUlogas.Select(s => s.Uloga.Naziv).FirstOrDefault() == uloga.Naziv);
            }

           
           
            var list = await query.ToListAsync();
            return _mapper.Map<List<Model.Korisnici>>(list);
        }


        public override async Task<Model.Korisnici> GetById(int id)
        {
            var entity = await _context.Set<Database.Korisnik>()
                .Include(i => i.KorisnikUlogas)
                .Where(i => i.KorisnikID == id)
                .Include(i=>i.Grad)
                .SingleOrDefaultAsync();

            return _mapper.Map<Model.Korisnici>(entity);
        }
        public async Task<Model.Korisnici> Authenticiraj(KorisnikAuthenticationRequest request)
        {
            var user = await _context.Korisniks
                 .Include(i => i.KorisnikUlogas)
                 .ThenInclude(j => j.Uloga)
                 .FirstOrDefaultAsync(i => i.KorisnickoIme == request.KorisnickoIme);


            if (user != null)
            {
                var hash = HashHelper.GenerateHash(user.LozinkaSalt, request.Lozinka);
                if (hash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }

            return null;
        }
        public override async Task<Model.Korisnici> Insert(KorisniciInsertRequest request)
        {
            if (request.Lozinka != request.LozinkaPotvrda)
            {
                throw new Exception("Lozinke se ne podudaraju");
            }

            var entity = _mapper.Map<Database.Korisnik>(request);
            entity.LozinkaSalt = HashHelper.GenerateSalt();
            entity.LozinkaHash = HashHelper.GenerateHash(entity.LozinkaSalt, request.Lozinka);

            await _context.Korisniks.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach (var roleID in request.Uloge)
            {
                var role = new Database.KorisnikUloga()
                {
                    KorisnikID = entity.KorisnikID,
                    UlogaID = roleID
                };

                await _context.KorisnikUlogas.AddAsync(role);
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Korisnici>(entity);
        }
       

        public override async Task<Model.Korisnici> Update(int id, KorisniciUpdateRequest request)
        {
            var entity = _context.Korisniks.Find(id);


            //if (entity.Email != request.Email && await IsEmailUnique(request.Email) == false)
            //{
            //    throw new UserException("Email adresa je zauzeta!");
            //}

            //if (entity.KorisnickoIme != request.KorisnickoIme && await IsUsernameUnique(request.KorisnickoIme) == false)
            //{
            //    throw new UserException("Korisničko ime je zauzeto");
            //}

            _context.Korisniks.Attach(entity);
            _context.Korisniks.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Lozinka))
            {
                if (request.Lozinka != request.LozinkaPotvrda)
                {
                    throw new UserException("Lozinke se ne slažu");
                }

                entity.LozinkaSalt = HashHelper.GenerateSalt();
                entity.LozinkaHash = HashHelper.GenerateHash(entity.LozinkaSalt, request.Lozinka);
            }


            foreach (var ulogaId in request.Uloge)
            {
                var korisnikUloga = await _context.KorisnikUlogas
                    .Where(i => i.UlogaID == ulogaId && i.KorisnikID == id)
                    .SingleOrDefaultAsync();

                if (korisnikUloga == null)
                {
                    var newRole = new Database.KorisnikUloga()
                    {
                        KorisnikID = id,
                        UlogaID = ulogaId
                    };
                    await _context.Set<Database.KorisnikUloga>().AddAsync(newRole);
                }
            }
            foreach (var UlogaId in request.UlogeZaObrisati)
            {
                var userRole = await _context.KorisnikUlogas
                    .Where(i => i.UlogaID == UlogaId && i.KorisnikID == id)
                    .SingleOrDefaultAsync();

                if (userRole != null)
                {
                    _context.Set<Database.KorisnikUloga>().Remove(userRole);
                }
            }
            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public async Task<bool> IsEmailUnique(string Email)
        {
            return !await _context.Korisniks.AnyAsync(i => i.Email == Email);
        }

        public async Task<bool> IsUsernameUnique(string Username)
        {
            return !await _context.Korisniks.AnyAsync(i => i.KorisnickoIme == Username);
        }

        public async Task<List<Model.Jela>> GetLajkanaJela(int id)
        {
            var x = await _context.Likes.Include(i => i.Jelo).Include(j => j.Jelo.Kategorija).Where(i => i.KorisnikID == id).Select(i => i.Jelo).ToListAsync();
            return _mapper.Map<List<Model.Jela>>(x);
        }
    }
}
