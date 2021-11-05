using System;
using System.Collections.ObjectModel;

using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Models;
using Slats.Helpers;

namespace Slats.ViewModels

{
    public class LeavePollVM : Observable, INavigationAware
    {

        public async void OnNavigatedTo(object parameter)
        {
            sldVal = 100;
        }

        public void OnNavigatedFrom()
        {
        }

        private double _sldVal;

        public double sldVal { get => _sldVal; set { Set(ref _sldVal, value); sldVal2 = _sldVal * 1.1; } }

        private double _sldVal2;

        public double sldVal2 { get => _sldVal2; set => Set(ref _sldVal2, value); }
    }
}
