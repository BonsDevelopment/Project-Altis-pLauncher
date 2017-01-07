using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Project_Altis_pLauncher.Enums;

namespace Project_Altis_pLauncher.ExternalTTPA
{
    public static class HideWindow
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public static void HideTTPA(int xSize, int ySize)
        {
            Process pName = Process.Start(@"C:\Users\Public\Desktop\Project Altis Launcher.lnk");
            
            Process GethWnd = Process.GetProcessesByName("Project Altis Launcher")[0];
            
            while (!MoveWindow(GethWnd.MainWindowHandle, 0, 0, 1, 1, true))
            {
                MoveWindow(GethWnd.MainWindowHandle, 0, 0, 1, 1, true);
            }
            
            //ShowWindow(GethWnd.MainWindowHandle, (int)ShowStyle.Hide);
            
        }

    }
}
