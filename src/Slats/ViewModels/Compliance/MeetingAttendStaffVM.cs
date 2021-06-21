using Slats.Contracts.ViewModels;
using Slats.Helpers;
using Slats.DAL;
using Slats.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Slats.ViewModels
{
    public class UserX
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Mail { get; set; }
    }
    public class MeetingAttendStaffVM : Observable, INavigationAware
    {
        public IPersonsRepository _personRepository;
        public ObservableCollection<Person> Source { get; set; } = new ObservableCollection<Person>();

        public MeetingAttendStaffVM(IPersonsRepository personsRepository)
        {
            _personRepository = personsRepository;
        }
        public async void OnNavigatedTo(object parameter)
        {
            Source.Clear();

            var data = await _personRepository.GetAll();

            foreach (var item in data)
            {
                Source.Add(item);
            }

            
        }

        public void OnNavigatedFrom()
        {
        }
    }
}
