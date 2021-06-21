using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    class MonitoredFolder : EntityTracked
    {
        public string Alias { get; set; }
        public string FullPath { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public DateTime Recorded { get; set; }
        public bool Archive { get; set; }
        public string ArchiveLocation { get; set; }
    }
}
