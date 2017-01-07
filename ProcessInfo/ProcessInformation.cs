using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Altis_pLauncher.ProcessInfo
{
    public static class ProcessInformation
    {
        public static bool IsOpen(string processName)
        {
            return Process.GetProcesses().Any((Process p) => p.ProcessName == (processName));
        }

        public static IntPtr WindowHandle(string processName)
        {
            return Process.GetProcessesByName(processName)[0].MainWindowHandle;
        }

    }
}
