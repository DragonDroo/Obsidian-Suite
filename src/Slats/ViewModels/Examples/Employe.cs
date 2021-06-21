using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.ViewModels
{
    public class Employe
    {
        #region Public Constructors

        public Employe()
        {
        }

        public Employe(string lastName, string firstName, int? salary, DateTime? startDate, bool? manager = false)
        {
            LastName = lastName;
            FirstName = firstName;
            Salary = salary;
            StartDate = startDate;
            Manager = manager;
        }

        #endregion Public Constructors

        #region Public Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Manager { get; set; }
        public int? Salary { get; set; }
        public DateTime? StartDate { get; set; }

        #endregion Public Properties
    }
}
