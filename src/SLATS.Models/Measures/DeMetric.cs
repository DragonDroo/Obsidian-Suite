using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class DeMetric : Entity
    {
        string DeMeasure { get; set; }
        string AppliesTo { get; set; }
        string DefaultValue { get; set; }
    }
}
