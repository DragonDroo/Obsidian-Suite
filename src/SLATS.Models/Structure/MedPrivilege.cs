

namespace Slats.Models
{
    public class MedPrivilege : EntityTracked
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string CptCode { get; set; } // possibly need to add more than 1
        public string DxCode { get; set; } // possibly need to add more than 1
        public int MedPrivilegeProfID { get; set; }
        public virtual MedPrivilegeProf MedPrivilegeProf { get; set; }
    }
}
