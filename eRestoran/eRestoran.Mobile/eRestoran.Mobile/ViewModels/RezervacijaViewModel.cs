using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
    public class RezervacijaViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("rezervacija");
        DateTime datum;
        public DateTime Datum
        {
            get { return datum; }
            set { SetProperty(ref datum, value); }
        }
        TimeSpan vrijeme;
        public TimeSpan Vrijeme
        {
            get { return vrijeme; }
            set { SetProperty(ref vrijeme, value); }
        }

        int brojOsoba;
        public int BrojOsoba
        {
            get { return brojOsoba; }
            set { SetProperty(ref brojOsoba, value); }
        }

        string brojTelefona;
        public string BrojTelefona
        {
            get { return brojTelefona; }
            set { SetProperty(ref brojTelefona, value); }
        }
        public RezervacijaViewModel()
        {
            RezervisiCommand = new Command(async () => await Rezervisi());
        }
        public ICommand RezervisiCommand { get; set; }
        async Task Rezervisi()
        {
            if (string.IsNullOrEmpty(BrojTelefona) || brojOsoba==0 || Datum == null || vrijeme == null)
                await Application.Current.MainPage.DisplayAlert("Error", "Sva polja su obavezna!", "OK");
            else if(Datum<DateTime.Now)
                await Application.Current.MainPage.DisplayAlert("Error", "Molimo Vas da izaberete datum počevši od sutra!", "OK");
            else if (int.TryParse(BrojTelefona, out int number) == false || BrojTelefona.Length<6)
                await Application.Current.MainPage.DisplayAlert("Error", "Pogrešan format telefonskog broja!", "OK");
            else
            {
                RezervacijaUpsertRequest request = new RezervacijaUpsertRequest
                {
                    BrojMjesta = BrojOsoba,
                    Telefon = BrojTelefona,
                    DatumRezervacije = new DateTime(Datum.Year, Datum.Month, Datum.Day, Vrijeme.Hours, Vrijeme.Minutes, Vrijeme.Seconds)
                };

                try
                {

                    await _service.Insert<Model.Rezervacije>(request);
                    await Application.Current.MainPage.DisplayAlert("Uspjeh", "Rezervacija uspješno poslana!", "OK");
                    Application.Current.MainPage = new AppShell();
                }
                catch
                {
                    await Application.Current.MainPage.DisplayAlert("Uspjeh", "Došlo je do greške!", "OK");


                }
            }

        }

       
    }
}
