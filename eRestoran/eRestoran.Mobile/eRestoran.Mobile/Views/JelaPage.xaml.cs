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
    public partial class JelaPage : ContentPage
    {
        public JelaViewModel model { get; set; } = null;
        public JelaPage()
        {
            InitializeComponent();
            BindingContext = model = new JelaViewModel();
        }
        public JelaPage(string search)
        {
            InitializeComponent();
            BindingContext = model = new JelaViewModel(search);
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init(model.SearchQuery);
           
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBar.Text = "";
        }

        JeloDetaljiViewModel jeloDetlalji = null;
        private async void Button_Clicked(object sender, EventArgs e)
        {
            Jela jelo = (Jela)((Button)sender).BindingContext;
            jeloDetlalji = new JeloDetaljiViewModel(){ Jelo = jelo };
            if (KorpaService.Cart.ContainsKey(jelo.JeloID))
            {
                var x = KorpaService.Cart.Where(s => s.Key == jelo.JeloID).FirstOrDefault();
                x.Value.Kolicina++;
            }
            else
            {
                KorpaService.Cart.Add(jelo.JeloID, jeloDetlalji);
            }
            await Navigation.PushAsync(new NarudzbaPage());
        }

        
    }
}
