using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class PositionAssigned : Entity
    {
        public int PersonId { get; set; }
        public int PositionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Position Position { get; set; }
        public virtual Person Person { get; set; }

    }
}
