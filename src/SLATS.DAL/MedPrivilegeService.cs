using System.Threading.Tasks;
using Slats.Models;

namespace Slats.DAL
{
    public class MedPrivilegeService : IMedPrivilegeService
    {
        IMedPrivilegeRepository _medPrivilege;
        IMedPrivilegeProfRepository _medPrivilegeProf;

        public MedPrivilegeService(IMedPrivilegeProfRepository medPrivilegeProfRepository, ITrackingRepository<MedPrivilegeProf> MedPrivProfRepo)
        {

        }
    }
}
