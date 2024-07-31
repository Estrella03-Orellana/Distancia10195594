using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia10195594.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private int x1;

        [ObservableProperty]
        private int x2;

        [ObservableProperty]
        private int totalX;

        [ObservableProperty]
        private int saldar1;

        [ObservableProperty]
        private int y1;

        [ObservableProperty]
        private int y2;

        [ObservableProperty]
        private int totalY;

        [ObservableProperty]
        private int saldar2;

        [ObservableProperty]
        private int distanciaTotal;

        [ObservableProperty]
        private int sumaTotal;

        [RelayCommand]

        public void DistanciaResultado()
        {
            TotalX = X1 - X2;
             Saldar1 = Convert.ToInt32(Math.Pow(TotalX, 2));

            TotalY = Y1 - Y2;
            Saldar2 = Convert.ToInt32(Math.Pow(TotalY, 2));

            SumaTotal = Convert.ToInt32(Saldar1 + Saldar2);
            DistanciaTotal = Convert.ToInt32(Math.Sqrt(SumaTotal));
        }
    }
}
