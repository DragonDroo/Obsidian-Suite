using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using HPlusSports.Core;
using HPlusSports.DAL;
using HPlusSports.Models;
using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Models;
using Slats.Helpers;
using Slats.DAL;
using Slats.Models;
using System.ComponentModel;

namespace Slats.ViewModels
{
    public class CprPoolsVM : Observable, INavigationAware, INotifyPropertyChanged
    {
        public ICprPoolsRepository cprPoolRepository;

        public ObservableCollection<CprPool> Source { get; set; } = new ObservableCollection<CprPool>();

        public CprPoolsVM(ICprPoolsRepository cprPoolsRepository)
        {
            cprPoolRepository = cprPoolsRepository;
        }

        public async void OnNavigatedTo(object parameter)
        {
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await cprPoolRepository.GetAll();  //.GetSalesPeople();

            foreach (var item in data)
            {
                Source.Add(item);
            }

            CprPool cp = new CprPool();
            cp.AssignReview = true;
            cp.ReviewForm = 5;
            cp.CprPoolName = "asdf";
            cp.Comment = "Comment";
            cprPoolRepository.Add(cp);
        }

        public void OnNavigatedFrom()
        {
            cprPoolRepository.SaveChanges();
        }

        public void NewPool()
        {
            CprPool cp = new CprPool();
            cp.AssignReview = true;
            cp.ReviewForm = 5;
            cp.CprPoolName = "asdf";
            cp.Comment = "Comment";
            Source.Add(cp);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
