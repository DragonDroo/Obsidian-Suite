using System.Collections.Generic;
using Slats.Models.Enum;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slats.Models
{
    public class User
    {
        public User()
        {
            this.Courses = new Collection<Course>();
            this.Quizs = new Collection<Quiz>();
            this.Results = new Collection<Result>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }

        public int? EducationId { get; set; }
        [ForeignKey("EducationId")]
        public virtual Education Education { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Quiz> Quizs { get; set; }
        public virtual ICollection<Result> Results { get; set; }
 
        public List<string> BusinessPhones { get; set; }

        public string DisplayName { get; set; }

        public string GivenName { get; set; }

        public object JobTitle { get; set; }

        public string Mail { get; set; }

        public string MobilePhone { get; set; }

        public object OfficeLocation { get; set; }

        public string PreferredLanguage { get; set; }

        public string Surname { get; set; }

        public string UserPrincipalName { get; set; }

        public string Photo { get; set; }
    }
}
