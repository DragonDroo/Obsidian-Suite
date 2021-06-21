using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class FlipPageNode : Entity
    {
        public string Name { get; set; }
        public int ParentI { get; set; }
        public int NoteI { get; set; }
        public virtual FlipPageNode Parent { get; set; }
        public virtual FlipPageNote Note { get; set; }
    }
}
