using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class Acronyms : Entity
    {
        public string Diminutive { get; set; }
        public string FullForm { get; set; }
        public string Verbose { get; set; }
    }
}
