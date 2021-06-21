using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models


{
    public partial class Person : EntityTracked
    {
        public Person()
        {
            ProviderRoles = new HashSet<StaffProvider>();
            AdminRoles = new HashSet<StaffAdmin>();
            PositionsAssigned = new HashSet<PositionAssigned>();
            StaffPriv = new StaffPriv();
        }
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public int SupervAdminId { get; set; }
        public int? SectionID { get; set; }
        public int? SupervAlt { get; set; }
        public string NtId { get; set; }
        public string VistaName { get; set; }
        //public virtual Person SupervAdmin { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        //public virtual Section Section { get; set; }
        //public int StaffPrivId { get; set; }
        public virtual ICollection<PositionAssigned> PositionsAssigned { get; set; }
        public virtual ICollection<StaffProvider> ProviderRoles { get; set; }
        public virtual ICollection<StaffAdmin> AdminRoles { get; set; }
        public virtual StaffPriv StaffPriv { get; set; }
    }
}