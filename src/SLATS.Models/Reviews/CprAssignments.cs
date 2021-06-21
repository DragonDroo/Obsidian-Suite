using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Slats.Models

{
    public class CprAssignments : EntityTracked
    {
        public int Reviewer { get; set; }
        public int Reviewed { get; set; }
        public DateTime Completed { get; set; }
        public int Quarter { get; set; }
        public string Comment { get; set; }
        public int CprPool { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime AssignDate { get; set; }
        public List<CprCore> Cores { get; set; }
    }
}
