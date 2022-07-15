using eRestoran.Mobile.ViewModels.Profil;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eRestoran.Mobile.Views.Profil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistracijaPage : ContentPage
    {
        private readonly APIService _gradoviService = new APIService("grad");
        RegistracijaViewModel model = new RegistracijaViewModel();
        public ObservableCollection<string> Gradovi { get; set; } = new ObservableCollection<string>();
        public async Task LoadGradoviAsync()
        {
            var gradovi = await _gradoviService.Get<List<Model.Gradovi>>(null);
            Gradovi.Clear();
            foreach (var grad in gradovi)
            {
                Gradovi.Add(grad.Naziv);
            }
        }
        public RegistracijaPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await LoadGradoviAsync();
            GradoviPicker.ItemsSource = Gradovi;
            GradoviPicker.SelectedIndex = 1;
        }

        private void GradoviPicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}