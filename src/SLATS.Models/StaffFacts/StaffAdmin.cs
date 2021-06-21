using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class StaffAdmin : EntityTracked
    {
        public string Position { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
