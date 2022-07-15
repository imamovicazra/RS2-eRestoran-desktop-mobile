using AutoMapper;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Mapping
{
    public class eRestoranProfile : Profile
    {
        public eRestoranProfile()
        {
            CreateMap<Database.Jelo, Model.Jela>().ReverseMap();
            CreateMap<Database.Jelo, Model.Requests.JelaUpsertRequest>().ReverseMap();

            CreateMap<Database.Like, Model.Likes>().ReverseMap();
            CreateMap<Database.Like, Model.Requests.LikesUpsertRequest>().ReverseMap();

            CreateMap<Database.Kategorija, Model.Kategorije>();
            CreateMap<Database.Kategorija, Model.Requests.KategorijaUpsertRequest>().ReverseMap();


            CreateMap<Database.Grad, Model.Gradovi>();
            CreateMap<Database.Grad, Model.Requests.GradUpsertRequest>().ReverseMap();


            CreateMap<Database.Korisnik, Model.Korisnici>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Requests.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Requests.KorisniciUpdateRequest>().ReverseMap();

            CreateMap<Database.KorisnikUloga, Model.KorisniciUloge>();
            CreateMap<Database.Uloga, Model.Uloge>();
            CreateMap<Database.Status, Model.Statusi>();

            CreateMap<Database.Korisnik, Model.Korisnici>()
             .ForMember(dest => dest.KorisniciUloge, opt => opt.MapFrom(src => src.KorisnikUlogas));
            CreateMap<Database.Jelo, Model.Jela>()
            .ForMember(dest => dest.Kategorija, opt => opt.MapFrom(src => src.Kategorija));

            CreateMap<Database.Narudzba, Model.Narudzbe>()
           .ForMember(dest => dest.ImePrezime, opt => opt.MapFrom(src => src.Korisnik.Ime));

            CreateMap<Database.Narudzba, Model.Narudzbe>()
           .ForMember(dest => dest.StatusNaziv, opt => opt.MapFrom(src => src.Status.Naziv));

            CreateMap<Database.Narudzba, Model.Requests.NarudzbaInsertRequest>().ReverseMap()
           .ForMember(dest => dest.NarudzbaDetaljis, opt => opt.MapFrom(src => src.NarudzbaDetalji));

            CreateMap<Database.NarudzbaDetalji, Model.NarudzbaDetalji>()
           .ForMember(dest => dest.NazivJela, opt => opt.MapFrom(src => src.Jelo.Naziv));


            CreateMap<Database.Narudzba, Model.Narudzbe>().ReverseMap();
            CreateMap<Database.Narudzba, Model.Requests.NarudzbaInsertRequest>().ReverseMap();
            CreateMap<Database.Narudzba, Model.Requests.NarudzbaUpdateRequest>().ReverseMap();

            CreateMap<Database.Rezervacija, Model.Rezervacije>().ReverseMap();
            CreateMap<Database.Rezervacija, Model.Requests.RezervacijaUpsertRequest>().ReverseMap();
            CreateMap<Database.Rezervacija, Model.Rezervacije>()
          .ForMember(dest => dest.StatusNaziv, opt => opt.MapFrom(src => src.Status.Naziv));

           

            CreateMap<Database.NarudzbaDetalji, Model.NarudzbaDetalji>().ReverseMap();
            CreateMap<Database.NarudzbaDetalji, Model.Requests.NarudzbaDetaljiUpsertRequest>().ReverseMap();





        }

    }
}
