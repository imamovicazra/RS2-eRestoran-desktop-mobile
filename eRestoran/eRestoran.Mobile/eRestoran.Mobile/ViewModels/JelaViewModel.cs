using eRestoran.Mobile.ViewModels.Shared;
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
    public class JelaViewModel:BaseViewModel
    {
        private readonly APIService _jelaService = new APIService("Jelo");
        private readonly APIService _kategorijeService = new APIService("Kategorija");
        public string SearchQuery { get; set; }

        public ICommand InitCommand { get; set; }

        public JelaViewModel()
        {
            InitCommand = new Command(async (object query) => await Init(query));
        }
        public JelaViewModel(string search)
        {
            InitCommand = new Command(async (object query) => await Init(query));
            SearchQuery = search;
            InitCommand.Execute(search);
        }
        public ObservableCollection<JeloViewModel> JelaList { get; set; } = new ObservableCollection<JeloViewModel>();
        public ObservableCollection<Model.Kategorije> KategorijeList { get; set; } = new ObservableCollection<Model.Kategorije>();

        Model.Kategorije _selectedKategorija = null;
        public Model.Kategorije SelectedKategorija
        {
            get { return _selectedKategorija; }
            set
            { 
                SetProperty(ref _selectedKategorija, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        
       
        public async Task Init(object query)
        {
            string queryString = query as string;

            SearchQuery = queryString;
            if (KategorijeList.Count == 0)
            {
                var kategorije = await _kategorijeService.Get<List<Model.Kategorije>>(null);
                foreach (var kategorija in kategorije)
                {
                    KategorijeList.Add(kategorija);
                }
                
            }
            if (SelectedKategorija == null)
            {


                JelaSearchRequest search = null;
                if (!string.IsNullOrEmpty(queryString))
                {
                    search = new JelaSearchRequest
                    {
                        Naziv = queryString
                    };
                }

                var list = await _jelaService.Get<List<Model.Jela>>(search);
                JelaList.Clear();
                foreach (var jelo in list)
                {
                    JelaList.Add(new JeloViewModel(jelo));
                }

            }
            else if (SelectedKategorija.KategorijaID==6)
            {
                JelaSearchRequest search = null;
                if (!string.IsNullOrEmpty(queryString))
                {
                    search = new JelaSearchRequest
                    {
                        Naziv = queryString
                    };
                }
                var list = await _jelaService.Get<List<Model.Jela>>(search);
                JelaList.Clear();
                foreach (var jelo in list)
                {
                    JelaList.Add(new JeloViewModel(jelo));
                }
            }
            else
            {
                JelaSearchRequest search = new JelaSearchRequest
                {
                    KategorijaID = SelectedKategorija.KategorijaID,
                    Naziv = queryString
                };
                if (!string.IsNullOrEmpty(queryString))
                {
                    search.Naziv = queryString;
                }
                var list = await _jelaService.Get<List<Model.Jela>>(search);
                JelaList.Clear();
                foreach (var jelo in list)
                {
                    JelaList.Add(new JeloViewModel(jelo));
                }

            }
          
            
        }
    }
}
