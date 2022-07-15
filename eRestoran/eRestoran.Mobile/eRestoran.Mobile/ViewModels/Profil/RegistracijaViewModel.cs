using eRestoran.Mobile.Views.Profil;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels.Profil
{
    public class RegistracijaViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("korisnici");
        private readonly APIService _gradoviService = new APIService("grad");

        public RegistracijaViewModel()
        {
            RegistracijaCommand = new Command(async () => await Registracija());
            SignInLoadCommand = new Command(() => SignInLoad());
        }

        int gradID = 0;
        public int GradID
        {
            get { return gradID; }
            set { SetProperty(ref gradID, value); }
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

        string lozinka;
        public string Lozinka
        {
            get { return lozinka; }
            set { SetProperty(ref lozinka, value); }
        }

        string lozinkaPotvrda;
        public string LozinkaPotvrda
        {
            get { return lozinkaPotvrda; }
            set { SetProperty(ref lozinkaPotvrda, value); }
        }

        public ICommand RegistracijaCommand { get; set; }
        public ICommand SignInLoadCommand { get; set; }
        void SignInLoad()
        {
            Application.Current.MainPage = new LoginPage();
        }
        private async Task Registracija()
        {
            if (string.IsNullOrEmpty(Ime) || string.IsNullOrEmpty(Prezime) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(BrojTelefona)
                || string.IsNullOrEmpty(Lozinka) || string.IsNullOrEmpty(LozinkaPotvrda) || string.IsNullOrEmpty(KorisnickoIme))
                await Application.Current.MainPage.DisplayAlert("Error", "Sva polja su obavezna!", "OK");
            else if(!Email.Contains("@"))
                await Application.Current.MainPage.DisplayAlert("Error", "Pogrešan format email adrese!", "OK");
            else if(int.TryParse(BrojTelefona, out int number)==false)
                await Application.Current.MainPage.DisplayAlert("Error", "Pogrešan format telefonskog broja!", "OK");
            else
            {
                try
                {
                    var request = new KorisniciInsertRequest()
                    {
                        Ime = Ime,
                        Prezime = Prezime,
                        KorisnickoIme = KorisnickoIme,
                        Email = Email,
                        Telefon = BrojTelefona,
                        Lozinka = Lozinka,
                        LozinkaPotvrda = LozinkaPotvrda,
                        Uloge = new List<int> { 2 },
                        GradID = GradID + 1
                    };

                    await _service.SignUp(request);
                    await Application.Current.MainPage.DisplayAlert("Success", "Uspješno ste registrovani", "OK");
                    Application.Current.MainPage = new LoginPage();
                }
                catch
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Došlo je do pogreške", "OK");
                }
            }
        }
    }
}
