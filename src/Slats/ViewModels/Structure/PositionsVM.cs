using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Models;
using Slats.Helpers;
using Slats.Converters;
using Slats.DAL;
using Slats.Models;
using System.Windows;

namespace Slats.ViewModels
{
    public class PositionsVM : Observable, INavigationAware, INotifyPropertyChanged
    {
        public IRepository<Position> repository;
        //DisplaySettingsPositions displaySettingsPositions;

        private bool _isLoggedIn;
        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set {
                //Set(ref _isLoggedIn, value);
                _isLoggedIn = value;
                OnPropertyChanged(nameof(IsLoggedIn));
            }
        }

        private bool _firstColumnChecked;
        public bool FirstColumnChecked
        {
            get { return _firstColumnChecked; }
            set
            {
                _firstColumnChecked = value;
                OnPropertyChanged(nameof(FirstColumnChecked));
            }
        }

        private bool _numberVis;
        public bool NumberVis
        {
            get { return _numberVis; }
            set
            {
                _firstColumnChecked = value;
                OnPropertyChanged(nameof(NumberVis));
            }
        }

        public async void PositionVM()
        {

        }
        //public int 
        public async void OnNavigatedTo(object parameter)
        {
            //restore last visible
            //NumberVis = false;
        }

        public void OnNavigatedFrom()
        {
            //save current visible
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class BindingProxy : Freezable
    {
        public static readonly DependencyProperty DataProperty =
           DependencyProperty.Register("Data", typeof(object),
              typeof(BindingProxy));

        public object Data
        {
            get { return GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        #region Overrides of Freezable

        protected override Freezable CreateInstanceCore()
        {
            return new BindingProxy();
        }

        #endregion
    }
    //public class Converters : IValueConverter
    //{
    //    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        Visibility rv = Visibility.Visible;
    //        try
    //        {
    //            var x = bool.Parse(value.ToString());
    //            if (x)
    //            {
    //                rv = Visibility.Visible;
    //            }
    //            else
    //            {
    //                rv = Visibility.Collapsed;
    //            }
    //        }
    //        catch (Exception)
    //        {
    //        }
    //        return rv;
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        return value;
    //    }

    //}
}