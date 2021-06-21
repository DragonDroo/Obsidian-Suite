using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class Staff : EntityTracked
    {
        public int? SectionID { get; set; }
        public virtual Section Section {get; set;}
    }
}
