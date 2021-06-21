using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class Meeting : EntityTracked
    {
        public int MeetingNameId { get; set; }
        public DateTime MeetingStart { get; set; }
        public DateTime MeetingEnd { get; set; }
        public string Instructor { get; set; }
        public string Location { get; set; }
        public int LearningHrs { get; set; }
        public string MeetingMinutes { get; set; }

    }
}
