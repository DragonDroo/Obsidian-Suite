using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    public enum QuestionType
    {
        MultiChoice = 0,
        OpenQuestion = 1
    }
    public class CprQuestion : Entity
    {
        public string Question   { get; set; }
        public int DisplayOrder  { get; set; }
        public int CorrectAnswer { get; set; }
        public QuestionType Type { get; set; }
        public string reportID   { get; set; }
    }
}
