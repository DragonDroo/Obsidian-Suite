using System;
using System.Collections.ObjectModel;

using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Models;
using Slats.Helpers;

namespace Slats.ViewModels
{
    public class EmployeeX
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DepartmentX   dept { get; set; }
        public Alternate alt { get; set; }
    }
    public enum Alternate
    {
        CharlotteHCC,
        CharlotteCBOC,
        Kernersville,
        Salisbury
    }
    public enum DepartmentX
    {
        Accounting,
        Economics,
        Finance,
        Management,
        Marketing,
    }
    public class PrivilegesVM : Observable, INavigationAware
    {

        public async void OnNavigatedTo(object parameter)
        {

        }

        public void OnNavigatedFrom()
        {
        }
    }
}