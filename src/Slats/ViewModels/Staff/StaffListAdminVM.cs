using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Models;
using Slats.Helpers;
using Slats.DAL;
using System.Collections.Generic;
using System.Linq;
using Slats.Models;
using System.Windows.Input;

namespace Slats.ViewModels
{
    public class StaffListAdminVM : Observable, INavigationAware, INotifyPropertyChanged
    {
        //private readonly DbContextGeneral _context = new DbContextGeneral();
        //private CollectionViewSource StaffListAdminViewSource;

        private readonly ISampleDataService _sampleDataService;

       //  Filter Grid
        private ICollectionView collView;
        private string search;
        public ObservableCollection<Employe> Employes { get; set; }
        public ObservableCollection<Employe> FilteredList { get; set; }

        //private readonly ISampleDataService _sampleDataService;
        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();


        public StaffListAdminVM(ISampleDataService sampleDataService)
        {
            //   _sampleDataService = sampleDataService;
            //_sampleDataService = Employes;
        }

        public ICommand RefreshCommand => new DelegateCommand(RefreshData);

        public string Search
        {
            get => search;
            set
            {
                search = value;

                collView.Filter = e =>
                {
                    var item = (Employe)e;
                    return item != null && ((item.LastName?.StartsWith(search, StringComparison.OrdinalIgnoreCase) ?? false)
                                            || (item.FirstName?.StartsWith(search, StringComparison.OrdinalIgnoreCase) ?? false));
                };

                collView.Refresh();

                FilteredList = new ObservableCollection<Employe>(collView.OfType<Employe>().ToList());

                OnPropertyChanged("Search");
                OnPropertyChanged("FilteredList");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async void OnNavigatedTo(object parameter)
        {
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await _sampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
        private void FillData()
        {
            search = "";

            var employe = new List<Employe>();

            // number of elements to be generated
            const int @int = 100000;

            // for distinct lastname set "true" at CreateRandomEmployee(true)
            for (var i = 0; i < @int; i++)
                employe.Add(RandomGenerator.CreateRandomEmployee(true));

            Employes = new ObservableCollection<Employe>(employe.AsParallel().OrderBy(o => o.LastName));

            FilteredList = new ObservableCollection<Employe>(Employes);
            collView = CollectionViewSource.GetDefaultView(FilteredList);

            OnPropertyChanged("Search");
            OnPropertyChanged("Employes");
            OnPropertyChanged("FilteredList");
        }
        private void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        /// <summary>
        /// refresh data
        /// </summary>
        /// <param name="obj"></param>
        private void RefreshData(object obj)
        {
            FillData();
        }

        public void OnNavigatedFrom()
        {
        }
    }
}



//private readonly DbContextGeneral _context = new DbContextGeneral();
//private CollectionViewSource StaffViewSource;

//public async void OnNavigatedTo(object parameter)
//        {
//            StaffViewSource = (CollectionViewSource)FindResource(nameof(peop))
//        }

//        public void OnNavigatedFrom()
//        {
//        }
//    }
//}
