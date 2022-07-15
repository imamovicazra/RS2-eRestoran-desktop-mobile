using eRestoran.Mobile.Views;
using eRestoran.Model;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
    public class NarudzbaViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Narudzba");

        public ObservableCollection<JeloDetaljiViewModel> JelaList { get; set; } = new ObservableCollection<JeloDetaljiViewModel>();

        public NarudzbaViewModel()
        {

        }
        public void Load()
        {
            Application.Current.MainPage = new AppShell();
        }
        public void Init()
        {
            JelaList.Clear();
            foreach (var item in KorpaService.Cart)
            {
                JelaList.Add(item.Value);
            }
        }
              

        public async Task Naruci(string telefon,string adresa)
        {
            if (string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(adresa))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Sva polja su obavezna", "OK");
            }
            else if (int.TryParse(telefon, out int number) == false)
                await Application.Current.MainPage.DisplayAlert("Error", "Pogrešan format telefonskog broja!", "OK");
            else
            {
                decimal? ukupno = 0;

                List<NarudzbaDetaljiUpsertRequest> narudzbaDetaljis = new List<NarudzbaDetaljiUpsertRequest>();
                

                NarudzbaInsertRequest narudzbaInsertRequest = new NarudzbaInsertRequest
                {
                    NarudzbaDetalji = narudzbaDetaljis,
                    Adresa = adresa,
                    DatumNarudzbe = DateTime.Now,
                    Telefon = telefon,
                    StatusID = 3
                };

                foreach (var item in KorpaService.Cart)
                {
                    ukupno += item.Value.Kolicina * item.Value.Jelo.Cijena;
                    narudzbaDetaljis.Add(new NarudzbaDetaljiUpsertRequest
                    {
                        JeloID = item.Value.Jelo.JeloID,
                        Cijena = item.Value.Jelo.Cijena,
                        Kolicina = (int?)item.Value.Kolicina
                    });
                }
                try
                {
                    await _service.Insert<Model.Narudzbe>(narudzbaInsertRequest);
                    KorpaService.Cart.Clear();
                    Application.Current.MainPage = new StripePaymentGatewayPage((decimal)ukupno);


                }
                catch (Exception ex)
                {

                    throw new Exception("Error:", ex.InnerException);
                }
            }

        }
    }
}
