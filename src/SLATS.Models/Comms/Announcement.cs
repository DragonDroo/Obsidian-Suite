using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class Announcement : NotifyEntity
    {
        public Announcement()
        {

        }
        public string Content { get; set; }
        public int StaffMember { get; set; }
        public bool AllStaff { get; set; }
        public int CprPool { get; set; }
        public int LeavePool { get; set; }
        public int Section { get; set; }
        public DateTime Created { get; }
        public DateTime Begins { get; set; }
        public DateTime Ends { get; set; }
    }
}
