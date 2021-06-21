using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class ProgramRole : EntityTracked
    {
        public string Role { get; set; }
        public int? ProgramId { get; set; }
        public virtual Program Program { get; set; }        

    }
}
