using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{

    public class CprAnswerOptions : Entity
    {
        public string Option { get; set; }
        public int QuestionId { get; set; }
        public bool GoodAnswer { get; set; }
    }
}
