using System;
using System.Collections.Generic;
using System.Text;
using Slats.Models;
using System.Threading.Tasks;


namespace Slats.DAL
{
    public interface ICprPoolsRepository : ITrackingRepository<CprPool>
    {
        Task<List<Person>> GetPeople();

    }
}
