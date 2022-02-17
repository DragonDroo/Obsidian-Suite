using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Models;
using Slats.Helpers;
using Slats.Models;

namespace Slats.ViewModels
{ 
    public class FileManagerVM : Observable, INavigationAware
    {
        private DelegateCommand updatePathCommand;
        public ICommand UpdatePathCommand
        {
            set
            {
                //currentPath = 
            }
            
            
        }
        public ObservableCollection<Item> _fileItems { get; set; } = new ObservableCollection<Item>();

        private string currentPath;

        public string GetCurrentPath()
        {
            return currentPath;
        }

        public void SetCurrentPath(string value)
        {
            currentPath = value;
        }

        ItemProvider itemProvider = new ItemProvider();
        //public List<Item> fileItems;

        //var items = itemProvider.GetItems("S:\\11M - ACOS (MH&BS)\\02_Supervisors\\TMS Data");
        //DataContext = items;

        public async void OnNavigatedTo(object parameter)
        {

            _fileItems = itemProvider.GetItems("S:\\11M - ACOS (MH&BS)\\02_Supervisors\\PDs_&_FSs");

        }

        public void OnNavigatedFrom()
        {
        }

        public void UpdatePath(string path)
        {
            //itemProvider = new ItemProvider(path);
            _fileItems = itemProvider.GetItems(path);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}