using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class DeMeasure : Entity
    {
        public int Quarter { get; set; }
        public int MetricId { get; set; }
        public string DeValue { get; set; }
        public int StaffID { get; set; }
        public virtual DeMetric OsMetric { get; set; }
    }
}
