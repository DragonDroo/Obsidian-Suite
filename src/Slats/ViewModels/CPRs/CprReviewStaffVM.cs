using System;
using System.Collections.ObjectModel;

using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Models;
using Slats.Helpers;

namespace Slats.ViewModels
{
    public class CprReviewStaffVM : Observable, INavigationAware
    {

        public async void OnNavigatedTo(object parameter)
        {

        }

        public void OnNavigatedFrom()
        {
        }
    }
}
