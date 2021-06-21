using System;
using System.Collections.ObjectModel;

using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Models;
using Slats.Helpers;
using Slats.Models;

namespace Slats.ViewModels
{
    public class NewEditPersonVM : Observable, INavigationAware
    {
        Person NewPerson;
        public async void OnNavigatedTo(object parameter)
        {
            NewPerson = new Person();

        }

        public void OnNavigatedFrom()
        {
        }
    }
}
