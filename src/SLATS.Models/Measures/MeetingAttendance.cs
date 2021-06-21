using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class MeetingAttendance : EntityTracked
    {
        public int MeetingId { get; set; }
        public int StaffId { get; set; }
        public int AttendOptId { get; set; }
        public string ProviderComment { get; set; }
        public string AdminComment { get; set; }
    }
}
