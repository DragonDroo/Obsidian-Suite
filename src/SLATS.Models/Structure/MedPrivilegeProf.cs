using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class MedPrivilegeProf : EntityTracked
    {
        public MedPrivilegeProf()
        {
            //MedPrivilege = new HashSet<MedPrivilege>();
        }
        public int ProviderID { get; set; }
        public DateTime? Activation { get; set; }
        public DateTime? Expiration { get; set; }
        public DateTime? PsbApproval { get; set; }
        public string Comments { get; set; }
        public virtual StaffProvider Provider { get; set; }
        public virtual ICollection<MedPrivilege> MedPrivilege { get; set; }

    }
}
