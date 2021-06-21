using Slats.Contracts.ViewModels;
using Slats.Helpers;
using Slats.DAL;
using Slats.Models;
using System.Collections.ObjectModel;

namespace Slats.ViewModels
{
    public class StaffListSupervisorVM : Observable, INavigationAware
    {
        public IProviderRepository _providerRepository;

        public ObservableCollection<StaffProvider> Source { get; set; } = new ObservableCollection<StaffProvider>();


        public StaffListSupervisorVM(IProviderRepository providerRepository)
        {
            _providerRepository = providerRepository;
        }

        public async void OnNavigatedTo(object parameter)
        {
            Source.Clear();

            var data = await _providerRepository.GetAll();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }

        public void OnNavigatedFrom()
        {
            _providerRepository.SaveChanges();
        }
    }
}

//namespace Slats.ViewModels
//{
//    public class StaffListSupervisorVM : Observable, INavigationAware
//    {
//        private readonly ISampleDataService _sampleDataService;

//        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

//        public StaffListSupervisorVM(ISampleDataService sampleDataService)
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