using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
    public class PromjenaLozinkeViewModel: BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
       
        string newPassword;
        public string NewPassword
        {
            get { return newPassword; }
            set { SetProperty(ref newPassword, value); }
        }

        string newPasswordConfirmation;
        public string NewPasswordConfirmation
        {
            get { return newPasswordConfirmation; }
            set { SetProperty(ref newPasswordConfirmation, value); }
        }

        public PromjenaLozinkeViewModel()
        {
            SavePasswordCommand = new Command(async () => await SavePassword());
        }
        public ICommand SavePasswordCommand { get; set; }
        private async Task SavePassword()
        {
            if (string.IsNullOrEmpty(NewPassword) || string.IsNullOrEmpty(NewPasswordConfirmation))
                await Application.Current.MainPage.DisplayAlert("Error", "Sva polja su obavezna!", "OK");
            else
            {
                if (NewPassword == NewPasswordConfirmation)
                {
                    Model.Korisnici korisnik = Helpers.PrijavljeniKorisnikHelper.User;
                    List<int> ulogeList = new List<int>();
                    foreach (var item in korisnik.KorisniciUloge)
                    {
                        ulogeList.Add(item.UlogaID);
                    }
                    try
                    {
                        var user = Helpers.PrijavljeniKorisnikHelper.User;
                        var request = new KorisniciUpdateRequest()
                        {
                            Ime = user.Ime,
                            Prezime = user.Prezime,
                            Email = user.Email,
                            KorisnickoIme = user.KorisnickoIme,
                            Telefon = user.Telefon,
                            GradID = user.GradID,
                            Lozinka = NewPassword,
                            LozinkaPotvrda = NewPasswordConfirmation,
                            Uloge = ulogeList
                        };

                        await _service.Update<Model.Korisnici>(user.KorisnikID, request);
                        APIService.Lozinka = NewPassword;
                        await Application.Current.MainPage.DisplayAlert("Success", "Uspješno ste izmijenili lozinku!", "OK");
                        Application.Current.MainPage = new AppShell();
                    }
                    catch
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "Došlo je do greške!", "OK");
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Lozinke se ne podudaraju!", "OK");
                }
            }
        }
    }
}
