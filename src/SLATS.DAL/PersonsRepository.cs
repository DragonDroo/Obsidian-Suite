using System;
using System.Collections.Generic;
using System.Text;
using Slats.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Slats.DAL
{
    public class PersonsRepository : TrackingRepository<Person>, IPersonsRepository
    {
        public PersonsRepository(DbContextGeneral context) : base(context) { }

        public Task<List<Person>> GetSalesPeopleByStateGroup(string state)
        {
            return _context.Set<Person>().Where(s => s.SupervAdminId == 3).ToListAsync();
        }
        public Task<List<Person>> GetPeople()
        {
            return _context.Set<Person>().ToListAsync();
        }
        public int Count()
        {
            return _context.Set<Person>().Where(p => p.Deleted == false).Count();
        }

        //public Task<List<Person>> GetWithOrders()
        //{
        //  //  return _context.Set<Person>().Include(s => s.Order).ToListAsync();
        //}
    }
}
