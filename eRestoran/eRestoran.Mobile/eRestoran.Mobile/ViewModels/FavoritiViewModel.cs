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
    public class FavoritiViewModel: BaseViewModel
    {
        private readonly APIService _korisniciService = new APIService("Korisnici");
        public FavoritiViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }

        public ObservableCollection<JeloViewModel> JelaList { get; set; } = new ObservableCollection<JeloViewModel>();
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
                var list = await _korisniciService.GetLajkanaJela<List<Model.Jela>>();
                JelaList.Clear();
                foreach (var jelo in list)
                {
                    JelaList.Add(new JeloViewModel(jelo));
                }
           
        }
    }
}
