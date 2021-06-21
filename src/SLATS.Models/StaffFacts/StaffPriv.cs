using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class StaffPriv : EntityTracked
    {
        public int PersonId { get; set; }
        public string PrivateEmail { get; set; }
        public string CascadeNumber { get; set; }
        public string CascadeAlt { get; set; }
        public string CascadePager { get; set; }
        public DateTime StationEod { get; set; }
        public DateTime SCD { get; set; }
        public DateTime ServiceStart { get; set; }
        public DateTime ServiceSeperation { get; set; }
        public DateTime DoB { get; set; }
        public virtual Person Person { get; set; }
    }
}
