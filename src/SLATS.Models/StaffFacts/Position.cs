using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class Position : EntityTracked
    {
        public Position()
        {
            PositionsAssigned = new HashSet<PositionAssigned>();
        }
        public int Number { get; set; }
        public string Status { get; set; }
        public bool Budgeted { get; set; }
        public int DepartmentId { get; set; }
        public int JobCode { get; set; }
        public string OfficialPositionTitle { get; set; }
        public int OccSeries { get; set; }
        public int ReportsTo { get; set; }
        public int PdFsNumber { get; set; }
        public string PayPlan { get; set; }
        public int Fte { get; set; }
        public int FteEquivalent { get; set; }
        public int Grade { get; set; }
        public int TargetFrade { get; set; }
        public int BusCode { get; set; }
        public int CostCenter { get; set; }
        public string OrgCode { get; set; }
        public string Location { get; set; }
        public string LocationDescription { get; set; }
        public DateTime PosCreated { get; set; }
        public DateTime PosRetired { get; set; }
        public virtual ICollection<PositionAssigned> PositionsAssigned { get; set; }

    }
}
