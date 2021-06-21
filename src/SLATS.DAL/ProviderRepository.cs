using System;
using System.Collections.Generic;
using System.Text;
using Slats.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Slats.DAL
{
    public class ProviderRepository : TrackingRepository<StaffProvider>, IProviderRepository
    {
        public ProviderRepository(DbContextGeneral context) : base(context) { }

        public Task<List<StaffProvider>> GetCprDue(int days)
        {
            throw new NotImplementedException();
        }

        public Task<List<StaffProvider>> GetFppeDue(int days)
        {
            throw new NotImplementedException();
        }

        public Task<List<StaffProvider>> GetLicensedProviders()
        {
            return _context.Set<StaffProvider>().Where(p => p.License != 0).ToListAsync();

        }

        public Task<List<StaffProvider>> GetUpcomingRecredentials(int days)
        {
            throw new NotImplementedException();
        }
    }
}
