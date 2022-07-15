using AutoMapper;
using eRestoran.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class PreporukeService : IPreporukaService
    {
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;
        private int PreporucenBroj = 2;

        public PreporukeService(eRestoranContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Jela> GetPreporuka(int id)
        {
            List<Model.Jela> listaPreporucenihJelaa = new List<Model.Jela>();
            List<Model.Jela> rezultat = new List<Model.Jela>();
            Database.Korisnik korisnik = _context.Korisniks.Find(id);
            if (korisnik != null)
            {
                var korisnikNarudzbe = _context.Narudzbas.Where(l => l.KorisnikID == korisnik.KorisnikID).ToList();

                Dictionary<int, int> Angazman = new Dictionary<int, int>();
                var svaJela = _context.Jelos.ToList();
                Dictionary<int, int> narudzbaBrojac = new Dictionary<int, int>();
                foreach (var i in svaJela)
                {
                    var brojac1 = 0;
                    foreach (var item in korisnikNarudzbe)
                    {
                        var narudzbaDetalji = _context.NarudzbaDetaljis.Include(x => x.Narudzba).Where(l => l.NarudzbaID == item.NarudzbaID).FirstOrDefault();

                        //var narudzbaModel = _mapper.Map<Model.NarudzbaDetalji>(narudzbaDetalji);

                        var jelo= _context.Jelos.Where(x => x.JeloID == narudzbaDetalji.JeloID).FirstOrDefault();
                        if (i.JeloID == jelo.JeloID)
                            brojac1++;
                    }
                  
                    if (!narudzbaBrojac.ContainsKey(i.JeloID))
                    {
                        narudzbaBrojac.Add(i.JeloID, brojac1);

                    }
                }
                foreach (var k in narudzbaBrojac.ToList())
                {
                    
                    if (k.Value >= PreporucenBroj)
                    {

                        var jelo = _context.Jelos.Where(x => x.JeloID == k.Key).FirstOrDefault();
                        var d = _mapper.Map<Model.Jela>(jelo);
                        rezultat.Add(d);
                    }
                }

                return rezultat;

            }
            return rezultat;
        }
    }
}
