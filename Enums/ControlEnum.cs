using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Altis_pLauncher.Enums
{
    [Flags]
    enum ControlLocation : uint
    {
        CloseButton  = 0,
        PlayButton   = 1,
        UsernameText = 5,
        PasswordText = 3
    }
}
