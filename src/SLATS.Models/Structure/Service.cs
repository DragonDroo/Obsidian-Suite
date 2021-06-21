using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class Service : EntityTracked
    {
        public string Name { get; set; }
        public virtual IEnumerable<Program> Programs { get; set; }
    }
}
