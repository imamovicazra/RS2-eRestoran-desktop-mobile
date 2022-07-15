using eRestoran.Mobile.Helpers;
using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels.Shared
{
    public class JeloViewModel:BaseViewModel
    {
        private readonly APIService _jeloService = new APIService("Jelo");
        private readonly APIService _service = new APIService("Korisnici");


        public ICommand ToggleFavouriteCommand { get; set; }


        private bool _isFavourite = false;
        public bool IsFavourite
        {
            get { return _isFavourite; }
            set
            {
                _isFavourite = value;
                OnPropertyChanged(nameof(IsFavouriteImage));
            }
        }
        private Model.Jela _jelo;
        public Jela Jelo
        {
            get { return _jelo; }
            set { SetProperty(ref _jelo, value); }
        }

       
        public ImageSource IsFavouriteImage
        {
            get => IsFavourite ? "heart-filled.png" : "srce3.png";
        }
        public JeloViewModel()
        {

        }

        
        public JeloViewModel(Model.Jela jelo)
        {
            Jelo = jelo;
            IsFavourite = false;
            InitCommand = new Command(async () => await Init(jelo));
            InitCommand.Execute(jelo);
            ToggleFavouriteCommand = new Command(async () => await ToggleFavouriteAsync());
        }

        public ObservableCollection<Model.Jela> LajkanaJela { get; set; } = new ObservableCollection<Model.Jela>();

        public ICommand InitCommand { get; set; }

        public async Task Init(Model.Jela jelo)
        {
            List<Model.Jela> jela = await _service.GetLajkanaJela<List<Model.Jela>>();
            foreach (var j in jela)
            {
                if (j.JeloID == jelo.JeloID)
                    IsFavourite = true;
            }

        }
        private async Task ToggleFavouriteAsync()
        {
            try
            {
                if (IsFavourite)
                {
                    await _jeloService.Dislike(Jelo.JeloID);
                    LikesHelper.Remove(Jelo);
                    IsFavourite = false;
                }
                else
                {
                    await _jeloService.Like(Jelo.JeloID);
                    LikesHelper.LajkanaJela.Add(Jelo);
                    IsFavourite = true;
                }

            }
            catch
            {

            }
        }

    }
}
