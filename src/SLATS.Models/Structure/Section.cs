using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class Section : Entity
    {
        public string SectionName { get; set; }
        public string Note { get; set; }
        public int? SectionChiefId { get; set; }
        public int? SectionAdminId { get; set; }
        //public virtual Person SectionChief { get; set; }
        //public virtual Person SectionAdmin { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
