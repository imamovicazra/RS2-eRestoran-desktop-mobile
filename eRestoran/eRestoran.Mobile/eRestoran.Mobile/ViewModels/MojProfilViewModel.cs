using eRestoran.Mobile.Views;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
    public class MojProfilViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("korisnici");

        public MojProfilViewModel()
        {
            SaveCommand = new Command(async () => await Sacuvaj());
            //ChangePasswordPageCommand = new Command(() => ChangePasswordLoad());
        }
        string ime;
        public string Ime
        {
            get { return ime; }
            set { SetProperty(ref ime, value); }
        }

        string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { SetProperty(ref prezime, value); }
        }

        string korisnickoIme;
        public string KorisnickoIme
        {
            get { return korisnickoIme; }
            set { SetProperty(ref korisnickoIme, value); }
        }

        string email;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        string brojTelefona;
        public string BrojTelefona
        {
            get { return brojTelefona; }
            set { SetProperty(ref brojTelefona, value); }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand ChangePasswordPageCommand { get; set; }

        //private async void ChangePasswordLoad()
        //{
           
        //    await naPushAsync(new NarudzbaPage());
        //}
        private async Task Sacuvaj()
        {
            if (string.IsNullOrEmpty(Ime) || string.IsNullOrEmpty(Prezime) || string.IsNullOrEmpty(KorisnickoIme)
                || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(BrojTelefona))
                await Application.Current.MainPage.DisplayAlert("Error", "Sva polja su obavezna!", "OK");
            else if (!Email.Contains("@"))
                await Application.Current.MainPage.DisplayAlert("Error", "Pogrešan format email adrese!", "OK");
            else if (int.TryParse(BrojTelefona, out int number) == false || BrojTelefona.Length<6)
                await Application.Current.MainPage.DisplayAlert("Error", "Pogrešan format telefonskog broja!", "OK");
            else
            {
                Model.Korisnici korisnik = Helpers.PrijavljeniKorisnikHelper.User;
                List<int> ulogeList = new List<int>();
                foreach (var item in korisnik.KorisniciUloge)
                {
                    ulogeList.Add(item.UlogaID);
                }

                try
                {

                    var request = new KorisniciUpdateRequest()
                    {
                        Ime = Ime,
                        Prezime = Prezime,
                        KorisnickoIme = KorisnickoIme,
                        Email = Email,
                        Telefon = BrojTelefona,
                        GradID = korisnik.GradID,
                        Uloge = ulogeList

                    };

                    Helpers.PrijavljeniKorisnikHelper.User = await _service.Update<Model.Korisnici>(korisnik.KorisnikID, request);
                    await Application.Current.MainPage.DisplayAlert("Success", "Uspješno ste izmijenili podatke!", "OK");
                    Application.Current.MainPage = new AppShell();
                }
                catch
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Došlo je do greške!", "OK");
                }
            }
        }

    }
}
