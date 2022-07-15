using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
    public class JeloDetaljiViewModel:BaseViewModel
    {
        public Jela Jelo { get; set; }

        public JeloDetaljiViewModel()
        {
            PovecajKolicinuCommand = new Command(() => PovecajKolicinu());
            SmanjiKolicinuCommand = new Command(() => SmanjiKolicinu());
            NaruciCommand = new Command(Naruci);
        }
        public ICommand NaruciCommand { get; set; }

        private void Naruci()
        {
            if (KorpaService.Cart.ContainsKey(Jelo.JeloID))
            {
                KorpaService.Cart.Remove(Jelo.JeloID);
            }
            KorpaService.Cart.Add(Jelo.JeloID, this);
        }
        decimal _kolicina = 1;
        public decimal Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand PovecajKolicinuCommand { get; set; }
        public void PovecajKolicinu()
        {
            Kolicina += 1;
        }
        public ICommand SmanjiKolicinuCommand { get; set; }
        public void SmanjiKolicinu()
        {
            if (Kolicina > 1)
                Kolicina -= 1;
            else
                Kolicina = 1;
        }


    }

}
