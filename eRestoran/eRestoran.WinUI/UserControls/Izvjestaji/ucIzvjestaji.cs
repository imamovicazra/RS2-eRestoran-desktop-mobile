using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.UserControls.Izvjestaji
{
    
    public partial class ucIzvjestaji : UserControl
    {
        private readonly APIService _jelService = new APIService("Jelo");
        private readonly APIService _narudzbeService = new APIService("Narudzba");
        private readonly APIService _narudzbeDetaljiService = new APIService("NarudzbaDetalji");
        private readonly APIService _korisniciService = new APIService("Korisnici");
        private readonly APIService _likesService = new APIService("Likes");
        public ucIzvjestaji()
        {
            InitializeComponent();
        }

        private async void btnJela_Click(object sender, EventArgs e)
        {
            var jela = await _jelService.Get<List<Model.Jela>>(null);
            var narudzbe = await _narudzbeDetaljiService.Get<List<Model.NarudzbaDetalji>>(null);
            var returnList = new List<Model.NajprodavanijeJelo>();

            foreach (var jelo in jela)
            {
                int TimesOrdered = 0;
                int? ArticleSold = 0;
                TimesOrdered = narudzbe.Where(x => x.JeloID == jelo.JeloID).Count();
                var listOrders = narudzbe.Where(x => x.JeloID == jelo.JeloID).ToList();
                foreach (var item in listOrders)
                {
                    ArticleSold += item.Kolicina;
                }
                var returnArticle = new Model.NajprodavanijeJelo()
                {
                    BrojNarudzbi = TimesOrdered,
                    KolicinaProdatih = (int)ArticleSold,
                    JeloID = jelo.JeloID,
                    Naziv = jelo.Naziv,
                    Cijena = (decimal)jelo.Cijena
                };
                returnList.Add(returnArticle);
            }
            returnList = returnList.OrderByDescending(x => x.KolicinaProdatih).Where(x => x.KolicinaProdatih > 0).ToList();
            dgvPrikaz.DataSource = returnList;

        }

        private async void btnKupci_Click(object sender, EventArgs e)
        {
            List<Model.Jela> jelaList = await _jelService.Get<List<Model.Jela>>(null);
            List<Model.Korisnici> korisniciList = await _korisniciService.Get<List<Model.Korisnici>>(null);
            List<Model.Narudzbe> narudzbeList = await _narudzbeService.Get<List<Model.Narudzbe>>(null);
            var returnList = new List<Model.NajboljiKupci>();

            foreach (var client in korisniciList)
            {
                int TimesOrdered = 0;
                TimesOrdered = narudzbeList.Where(x => x.KorisnikID == client.KorisnikID).Count();
                var returnclient = new Model.NajboljiKupci()
                {
                    Email = client.Email,
                    Ime = client.Ime,
                    Prezime = client.Prezime,
                    BrojNarudzbi = TimesOrdered,
                    KorisnickoIme = client.KorisnickoIme
                };

                returnList.Add(returnclient);
            }
            returnList = returnList.OrderByDescending(x => x.BrojNarudzbi).Where(s=>s.BrojNarudzbi>0).ToList();
            dgvPrikaz.DataSource = returnList;


        }

        private async void btnLikes_Click(object sender, EventArgs e)
        {
            List<Model.Jela> jelaList = await _jelService.Get<List<Model.Jela>>(null);
            List<Model.Likes> likesList = await _likesService.Get<List<Model.Likes>>(null);
            var returnList = new List<Model.JeloSaNajviseLajkova>();

            foreach (var jelo in jelaList)
            {
                int TimesLiked= 0;
                TimesLiked = likesList.Where(x => x.JeloID == jelo.JeloID).Count();
                var returnArticle = new Model.JeloSaNajviseLajkova
                {
                    JeloID = jelo.JeloID,
                    Naziv = jelo.Naziv,
                    BrojLajkova = TimesLiked
                };
                returnList.Add(returnArticle);

            }
            returnList = returnList.OrderByDescending(x => x.BrojLajkova).Where(s=>s.BrojLajkova>0).ToList();
            dgvPrikaz.DataSource = returnList;

        }
    }
}
