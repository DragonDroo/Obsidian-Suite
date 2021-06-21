using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Slats.Models;

namespace Slats.DAL
{
    public class MedPrivilegeRepository : TrackingRepository<MedPrivilege>, IMedPrivilegeRepository
    {
        public MedPrivilegeRepository(DbContextGeneral context) : base(context) { }
        public Task<List<MedPrivilege>> GetMedPrivileges()
        {
            throw new NotImplementedException();
        }
    }
}
