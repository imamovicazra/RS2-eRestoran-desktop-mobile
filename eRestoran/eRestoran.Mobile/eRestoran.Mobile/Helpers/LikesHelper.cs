using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.Helpers
{
    public class LikesHelper
    {
        private readonly APIService _service = new APIService("Korisnici");
        public static List<Model.Jela> LajkanaJela { get; set; } = new List<Model.Jela>();
        public LikesHelper()
        {
            InitCommand = new Command(async () => await Init());

        }

        public ICommand InitCommand { get; set; }

        private async Task Init()
        {
            LajkanaJela = await _service.GetLajkanaJela<List<Model.Jela>>();
        }


        public static bool Remove(Model.Jela item)
        {
            var itemToRemove = LajkanaJela.Where(i => i.JeloID == item.JeloID).FirstOrDefault();
            return LajkanaJela.Remove(itemToRemove);
        }
    }
}
