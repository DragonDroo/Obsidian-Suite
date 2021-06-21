using System;
using System.Collections.Generic;
using System.Text;
using Slats.Models;
using System.Threading.Tasks;

namespace Slats.DAL
{
    public interface IPersonsRepository : ITrackingRepository<Person>
    {
        Task<List<Person>> GetSalesPeopleByStateGroup(string state);
        Task<List<Person>> GetPeople();

        //Task<List<Person>> GetWithOrders();
    }
}
