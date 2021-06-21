using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public class CprCore : Entity
    {
        public string PatientID { get; set; }
        public DateTime NoteDate { get; set; }
        public DateTime ReviewDate { get; set; }
        public string ReviewerComments { get; set; }
        public int Rating { get; set; }
        public string CPReviewer { get; set; }
        public int CpRating { get; set; }
        public string CpComment { get; set; }
        public DateTime CpReviewDate { get; set; }
        public int AdjRating { get; set; }
        public string AdjComment { get; set; }
        public DateTime AdjReviewDate { get; set; }
    }
}

