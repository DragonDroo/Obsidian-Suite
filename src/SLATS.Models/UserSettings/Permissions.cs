using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Slats.Models
{
    public class Permissions : EntityTracked
    {
        public int _UserID;
        public Permission OrgChart;
        public virtual Person User { get; set;}
    }

    public class Permission : Entity
    {
        //public Visibility visible;
        public bool CanEdit;
    }
}
