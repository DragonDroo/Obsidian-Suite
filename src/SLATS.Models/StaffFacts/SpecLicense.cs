using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class SpecLicense : Entity
    {
        public int ProviderID { get; set; }
        public string State { get; set; }
        public string LicenseNum { get; set; }
        public string LicenseText { get; set; }
        public DateTime Active { get; set; }
        public DateTime Expiration { get; set; }
        public virtual StaffProvider Provider { get; set; }

    }
}
