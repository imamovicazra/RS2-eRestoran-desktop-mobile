using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eRestoran.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MojProfilPage : ContentPage
    {
        public MojProfilPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Model.Korisnici korisnik = Helpers.PrijavljeniKorisnikHelper.User;
            ime.Text = korisnik.Ime;
            prezime.Text = korisnik.Prezime;
            korisnicko_ime.Text = korisnik.KorisnickoIme;
            email.Text = korisnik.Email;
            broj_telefona.Text = korisnik.Telefon;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PromjenaLozinkePage());

        }
    }
}