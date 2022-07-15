using eRestoran.Mobile.Helpers;
using eRestoran.Mobile.Views;
using eRestoran.Mobile.Views.Profil;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels.Profil
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
        public LoginViewModel()
        {
            SignUpLoadCommand = new Command(() => SignUpLoad());
            LoginCommand = new Command(async () => await Login());

        }
        string username;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        string password;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        public ICommand SignUpLoadCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        void SignUpLoad()
        {
            Application.Current.MainPage = new RegistracijaPage();
        }
        async Task Login()
        {
            if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Username))
            {
                IsBusy = false;
                await Application.Current.MainPage.DisplayAlert("Error", "Sva polja su obavezna", "OK");
            }
            else
            {
                IsBusy = true;
                APIService.KorisnickoIme = Username;
                APIService.Lozinka = Password;
                var request = new KorisnikAuthenticationRequest()
                {
                    KorisnickoIme = APIService.KorisnickoIme,
                    Lozinka = APIService.Lozinka
                };

                var user = await _service.Authenticate(request);

                if (user != null)
                {
                    var userRole = user.KorisniciUloge.FirstOrDefault(i => i.Uloga.UlogaID == 2);
                    if (userRole != null)
                    {
                        Application.Current.MainPage = new AppShell();
                        PrijavljeniKorisnikHelper.User = user;
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "Korisnik sa tim korisničkim imenom ne postoji", "OK");
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Pogrešno korisničko ime ili lozinka", "OK");
                }
            }
        }
    }
}