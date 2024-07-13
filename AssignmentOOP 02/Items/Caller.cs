using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP_02.Items
{
   [Flags]
    public enum Caller
    {
        guest = 1,
        Developer =2,
        seceratery =4,
        DBA =8
    }
}
