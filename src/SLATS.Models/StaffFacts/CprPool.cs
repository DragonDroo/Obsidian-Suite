using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Slats.Models

{
    public partial class CprPool : EntityTracked, INotifyPropertyChanged
    {
        public CprPool()
        {
           
        }
        private string cprPoolName;
        private string comment;
        private bool assignReview;
        private int reviewForm;
        private DateTime effective;
        private DateTime retired;

        //public string CprPoolName { get; set; }
        //public string Comment { get; set; }
        //public bool AssignReview { get; set; }
        //public int ReviewForm { get; set; }
        //public DateTime Effective { get; set; }
        //public DateTime Retired { get; set; }

        public virtual string CprPoolName { get { return cprPoolName; } set { cprPoolName = value; OnPropertyRaised("CprPoolName"); } }
        public virtual string Comment { get { return comment; } set { comment = value; OnPropertyRaised("Comment"); } }
        public virtual bool AssignReview { get { return assignReview; } set { assignReview = value; OnPropertyRaised("AssignReview"); } }
        public virtual int ReviewForm { get { return reviewForm; } set { reviewForm = value; OnPropertyRaised("ReviewForm"); } }
        public virtual DateTime Effective { get { return effective; } set { effective = value; OnPropertyRaised("Effective"); } }
        public virtual DateTime Retired { get { return retired; } set { retired = value; OnPropertyRaised("Retired"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
