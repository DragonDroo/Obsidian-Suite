using System;
using System.Collections.ObjectModel;

using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Models;
using Slats.Helpers;
using RtfEditor;

namespace Slats.ViewModels
{
    public class NotifyEmailTemplatesVM : Observable, INavigationAware
    {

        public async void OnNavigatedTo(object parameter)
        {

        }

        public void OnNavigatedFrom()
        {
        }
    }
}