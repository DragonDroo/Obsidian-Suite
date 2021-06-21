using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class StaffProvider : EntityTracked
    {
        public StaffProvider()
        {
            MedPrivilegeProf = new HashSet<MedPrivilegeProf>();
            SpecLicenses = new HashSet<SpecLicense>();
            Clinics = new HashSet<Clinic>();
        }
        public int PersonId { get; set; }
        public string ProviderClass { get; set; }
        public int License { get; set; } // Convert to list to allow multiple licenses
        public int ClinicalSuper { get; set; }  // default to Admin Supervisor
        //public int Credentials { get; set; }  // Convert to list to allow multiple credentialing iterations
        public string NPI { get; set; }
        public int? CprPoolIdPerm { get; set; }
        public int? CprPoolIdTemp { get; set; }
        public string TaxonomyCode { get; set; }
        public int UsualCosigner { get; set; }
        public string UsualCosignerNid { get; set; }  // for use only if usual cosigner is not in the database
        public virtual Person Person { get; set; }
        public virtual ICollection<MedPrivilegeProf> MedPrivilegeProf { get; set; }
        public virtual ICollection<SpecLicense> SpecLicenses { get; set; }
        public virtual ICollection<Clinic> Clinics { get; set; }
    }
}
