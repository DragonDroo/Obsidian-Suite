using System;
using System.Collections.ObjectModel;
using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Models;
using Slats.Helpers;
using Slats.DAL;
using Slats.Models;

namespace Slats.ViewModels
{
    public class DataGridViewModel : Observable, INavigationAware
    {
        //  private readonly ISampleDataService _sampleDataService;
        //  public ISalesPersonRepository _salesPersonRepository;
        public IPersonsRepository personRepository;

        //    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();
        //  public ObservableCollection<Salesperson> Source { get; set; } = new ObservableCollection<Salesperson>();
        public ObservableCollection<Person> Source { get; set; } = new ObservableCollection<Person>();


        public DataGridViewModel(IPersonsRepository sampleDataService)
        {
            //   _sampleDataService = sampleDataService;
            personRepository = sampleDataService;
        }

        public async void OnNavigatedTo(object parameter)
        {
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await personRepository.GetPeople();  //.GetSalesPeople();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }

        public void OnNavigatedFrom()
        {
            personRepository.SaveChanges();
        }
    }
}

// Original VM Code


//using System;
//using System.Collections.ObjectModel;

//using Slats.Contracts.ViewModels;
//using Slats.Core.Contracts.Services;
//using Slats.Core.Models;
//using Slats.Helpers;

//namespace Slats.ViewModels
//{
//    public class DataGridViewModel : Observable, INavigationAware
//    {
//        private readonly ISampleDataService _sampleDataService;

//        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

//        public DataGridViewModel(ISampleDataService sampleDataService)
//        {
//            _sampleDataService = sampleDataService;
//        }

//        public async void OnNavigatedTo(object parameter)
//        {
//            Source.Clear();

//            // TODO WTS: Replace this with your actual data
//            var data = await _sampleDataService.GetGridDataAsync();

//            foreach (var item in data)
//            {
//                Source.Add(item);
//            }
//        }

//        public void OnNavigatedFrom()
//        {
//        }
//    }
//}