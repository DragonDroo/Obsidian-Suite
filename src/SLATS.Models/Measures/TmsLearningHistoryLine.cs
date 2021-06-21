using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    class TmsLearningHistory : Entity
    {
        public int StaffId { get; set; }
        public string Status { get; set; }
        public int? DaysRemaining { get; set; }
        public string ItemId { get; set; }
        public int? ReportId { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime ReportDate { get; set; }
    }
}
