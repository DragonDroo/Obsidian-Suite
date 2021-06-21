using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Functions
{
    [Flags]
    public enum SecurityFlags
    {
        None =            0b0000_0000_0000_0000,
        User =            0b0000_0000_0000_0001,
        Scheduler =       0b0000_0000_0000_0010,
        clinical =        0b0000_0000_0000_0100,
        x2 =              0b0000_0000_0000_1000,
        x3 =              0b0000_0000_0001_0000,
        x4 =              0b0000_0000_0010_0000,
        x5 =              0b0000_0000_0100_0000,
        Supervisor =      0b0000_0000_1000_0000,
        CprAssign =       0b0000_0001_0000_0000,
        CprBuild =        0b0000_0010_0000_0000,
        ClinicControl =   0b0000_0100_0000_0000,
        x10 =             0b0000_1000_0000_0000,
        x11 =             0b0001_0000_0000_0000,
        x12 =             0b0010_0000_0000_0000,
        Admin =           0b0100_0000_0000_0000,
        Developer =       0b1000_0000_0000_0000
    }
    class Security
    {
    }
}
