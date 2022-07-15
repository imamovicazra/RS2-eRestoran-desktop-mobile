using eRestoran.Mobile.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
    public class PreporukaViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Preporuke");
        private readonly APIService _jeloService = new APIService("Jelo");

        public PreporukaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<JeloViewModel> JelaList { get; set; } = new ObservableCollection<JeloViewModel>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var listRecommendation = await _service.GetById<List<Model.Jela>>(Helpers.PrijavljeniKorisnikHelper.User.KorisnikID);
            var list = await _jeloService.Get<List<Model.Jela>>(null);
            List<int> categoryList = new List<int>();
            foreach (var x in listRecommendation)
            {
                categoryList.Add((int)x.KategorijaID);
            }
            JelaList.Clear();
            foreach (var jelo in list)
            {
                foreach (var x in categoryList)
                {
                    if(jelo.KategorijaID==x)
                        JelaList.Add(new JeloViewModel(jelo));
                }
                
            }
        }
    }
}
