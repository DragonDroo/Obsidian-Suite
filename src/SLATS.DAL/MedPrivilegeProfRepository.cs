using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Slats.Models;

namespace Slats.DAL
{
    public class MedPrivilegeProfRepository : TrackingRepository<MedPrivilegeProf>, IMedPrivilegeProfRepository
    {
        public MedPrivilegeProfRepository(DbContextGeneral context) : base(context) { }
        public Task<List<MedPrivilegeProf>> GetAllCurrentPrivileges()
        {
            return _context.Set<MedPrivilegeProf>().Include(s => s.MedPrivilege).ToListAsync();
        }

        public Task<List<MedPrivilegeProf>> GetAllForProvider(int ProviderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<MedPrivilegeProf>> GetCurrent()
        {
            throw new NotImplementedException();
        }

        public Task<List<MedPrivilegeProf>> GetExpiringPrivileges(int Days)
        {
            throw new NotImplementedException();
        }
    }
}
