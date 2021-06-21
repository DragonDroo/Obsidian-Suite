using System.Collections.Generic;
using System.Threading.Tasks;
using Slats.Models;

namespace Slats.DAL
{
    public interface IMedPrivilegeProfRepository : ITrackingRepository<MedPrivilegeProf>
    {
        Task<List<MedPrivilegeProf>> GetCurrent();
        Task<List<MedPrivilegeProf>> GetAllForProvider(int ProviderId);
        Task<List<MedPrivilegeProf>> GetAllCurrentPrivileges();
        Task<List<MedPrivilegeProf>> GetExpiringPrivileges(int Days);
    }
}
