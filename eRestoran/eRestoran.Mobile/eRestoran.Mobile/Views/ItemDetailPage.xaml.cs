using eRestoran.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace eRestoran.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}