using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models

{
    class TmsCourses : Entity
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public bool Required { get; set; }
    }
}
