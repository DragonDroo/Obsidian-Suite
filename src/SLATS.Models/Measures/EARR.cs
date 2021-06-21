using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    class EARR
    {
        public int StaffId { get; set; }
        public DateTime EncDate { get; set; }
        public int Clinic { get; set; } // lookup from Clinics data
        public int IssueCode { get; set; } // lookup from a Global list of staff errors (not DB pr code errors)
        public string Responsibility { get; set; }
    }
}
