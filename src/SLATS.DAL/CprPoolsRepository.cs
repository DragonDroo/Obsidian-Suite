using System;
using System.Collections.Generic;
using System.Text;
using Slats.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Slats.DAL
{
    public class CprPoolsRepository : TrackingRepository<CprPool>, ICprPoolsRepository
    {
        public CprPoolsRepository(DbContextGeneral context) : base(context) { }

        public Task<List<Person>> GetPeople()
        {
            throw new NotImplementedException();
        }
    }
}
