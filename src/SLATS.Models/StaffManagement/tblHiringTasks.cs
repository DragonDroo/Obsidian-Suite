using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class tblHiringTasks : Entity
    {
        public string TaskName { get; set; }
        public int TaskOrder { get; set; }
        public string TaskNotes { get; set; }

    }
}
