using eRestoran.Mobile.ViewModels;
using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Mobile
{
    public static class KorpaService
    {
        public static Dictionary<int, JeloDetaljiViewModel> Cart { get; set; } = new Dictionary<int, JeloDetaljiViewModel>();
    }
}
