using eRestoran.Mobile.ViewModels;
using eRestoran.Model;
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
    public partial class NarudzbaPage : ContentPage
    {
        NarudzbaViewModel narudzba = null;
        public NarudzbaPage()
        {
            InitializeComponent();
            BindingContext = narudzba = new NarudzbaViewModel();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            decimal? ukupno = 0;
            foreach (var item in KorpaService.Cart)
            {
                ukupno += item.Value.Kolicina * item.Value.Jelo.Cijena;    
            }

            lbl_ukupno.Text = ukupno.ToString();
            narudzba.Init();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Jela jelo = (Jela)((Button)sender).BindingContext;
            if (KorpaService.Cart.ContainsKey(jelo.JeloID))
            {
                KorpaService.Cart.Remove(jelo.JeloID);
               
            }
            decimal? ukupno = 0;
            foreach (var item in KorpaService.Cart)
            {
                ukupno += item.Value.Kolicina * item.Value.Jelo.Cijena;
            }

            lbl_ukupno.Text = ukupno.ToString();
            narudzba.Init();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            KorpaService.Cart.Clear();
            lbl_ukupno.Text = 0.ToString();
            narudzba.Init();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            decimal? ukupno = 0;
            foreach (var item in KorpaService.Cart)
            {
                ukupno += item.Value.Kolicina * item.Value.Jelo.Cijena;
            }

            lbl_ukupno.Text = ukupno.ToString();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            decimal? ukupno = 0;
            foreach (var item in KorpaService.Cart)
            {
                ukupno += item.Value.Kolicina * item.Value.Jelo.Cijena;
            }

            lbl_ukupno.Text = ukupno.ToString();
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            if (narudzba.JelaList.Count() == 0)
                btn_narudzba.IsEnabled = false;
            else
                Application.Current.MainPage = new NarudzbaPodaciPage();


        }
    }
}