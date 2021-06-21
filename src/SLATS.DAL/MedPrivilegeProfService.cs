using System.Threading.Tasks;
using Slats.Models;

namespace Slats.DAL
{
    public class MedPrivilegeProfService : IMedPrivilegeProfService
    {
        IMedPrivilegeRepository _medPrivilege;
        IMedPrivilegeProfRepository _medPrivilegeProf;

        public MedPrivilegeProfService(IMedPrivilegeProfRepository medPrivilegeProfRepository, ITrackingRepository<MedPrivilegeProf> MedPrivProfRepo)
        {

        }
    }
}
