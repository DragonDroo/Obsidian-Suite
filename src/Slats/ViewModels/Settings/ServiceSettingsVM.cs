using System;
using System.Windows.Input;

using Microsoft.Extensions.Options;

using Slats.Contracts.Services;
using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Helpers;
using Slats.Helpers;
using Slats.Models;

namespace Slats.ViewModels
{
    public class ServiceSettingsVM : Observable, INavigationAware
    {
        public ServiceSettingsVM()
        {
        }
        public void OnNavigatedTo(object parameter)
        {
        }
         public void OnNavigatedFrom()
        {
        }
    }
}
