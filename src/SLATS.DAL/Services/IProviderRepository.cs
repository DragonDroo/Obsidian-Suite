using System;
using System.Collections.Generic;
using System.Text;
using Slats.Models;
using System.Threading.Tasks;

namespace Slats.DAL
{
    public interface IProviderRepository : ITrackingRepository<StaffProvider>
    {
        Task<List<StaffProvider>> GetLicensedProviders();
        Task<List<StaffProvider>> GetUpcomingRecredentials(int days); //return all providers to be recredentialed in x days
        Task<List<StaffProvider>> GetCprDue(int days); // return all providers with CPR due in x days or overdue
        Task<List<StaffProvider>> GetFppeDue(int days); // return all providers with Fppe due in x days or overdue

    }
}
