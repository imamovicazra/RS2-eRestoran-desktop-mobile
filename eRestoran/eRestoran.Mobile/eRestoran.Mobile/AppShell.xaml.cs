using eRestoran.Mobile.ViewModels;
using eRestoran.Mobile.Views;
using eRestoran.Mobile.Views.Profil;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace eRestoran.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(JelaPage), typeof(JelaPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(RezervacijaPage), typeof(RezervacijaPage));
            Routing.RegisterRoute(nameof(FavoritiPage), typeof(FavoritiPage));
            Routing.RegisterRoute(nameof(MojProfilPage), typeof(MojProfilPage));
            Routing.RegisterRoute(nameof(PreporukaPage), typeof(PreporukaPage));




        }

        private void OnMenuItemClicked(object sender, EventArgs e)
        {
            KorpaService.Cart.Clear();
            Application.Current.MainPage = new LoginPage();

        }
    }
}
