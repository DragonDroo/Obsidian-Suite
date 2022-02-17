using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    class ActivityLog : Entity
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string ActivityNote { get; set; }
        public int UserID { get; set; }
        public int SubjectId { get; set; }
        public string Error { get; set; }
    }
}

//Table Indexes
//Name Number of Fields
//PrimaryKey 1
//Fields:
//ID Ascending
//SubjectId 1
//Fields:
//SubjectId Ascending
//UserID 1
//Fields:
//UserID Ascending