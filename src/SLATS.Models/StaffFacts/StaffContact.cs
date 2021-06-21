using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class StaffContact : EntityTracked
    {
        public string VaPagerNumber { get; set; }
        public string VaCellNumber { get; set; }
        public string VaFaxNumber { get; set; }
        public string VaEmail { get; set; }
        public string RoomNumber { get; set; }
        public string Extension { get; set; }
        public string AltExtension { get; set; }

    }
}
