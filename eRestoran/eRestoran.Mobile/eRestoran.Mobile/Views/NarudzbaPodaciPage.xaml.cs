using eRestoran.Mobile.ViewModels;
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
    public partial class NarudzbaPodaciPage : ContentPage
    {
        NarudzbaViewModel model = null;
        public NarudzbaPodaciPage()
        {
            InitializeComponent();
            BindingContext = model = new NarudzbaViewModel();

        }
      
        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
            KorpaService.Cart.Clear();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            string tel = telefon.Text;
            string adr = adresa.Text;
            try
            {
                await model.Naruci(tel, adr);
            }
            catch (Exception ex)
            {
                throw new Exception("Error:",ex.InnerException);
            }
           

        }
    }
}