using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class EntityTracked : Entity
    {
        public DateTime Start { get; set; }
        public DateTime Updated { get; set; }
        public DateTime End { get; set; }
        public bool Deleted { get; set; }

        public bool Current()
        {
            if (Start != null)
            {
                if (DateTime.Now > Start && (DateTime.Now < End || End == null))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
