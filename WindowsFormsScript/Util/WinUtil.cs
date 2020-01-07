using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowsFormsScript.Util
{
    public class WinUtil
    {
        [DllImport("user32.dll", EntryPoint = "PostMessage")]
        public static extern int PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("User32.dll ", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);//关键方法
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SendMessage(IntPtr HWnd, uint Msg, int WParam, int LParam);
        public const int WM_SYSCOMMAND = 0x112;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const uint WM_SYSCOMMAND2 = 0x0112;
        public const uint SC_MAXIMIZE2 = 0xF030;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        public static void minWindow(string processName)
        {
            Process[] processs = Process.GetProcessesByName(processName);
            if (processs.Length > 0)
            {
                foreach (Process p in processs)
                {
                    IntPtr handle = FindWindow(null, p.MainWindowTitle);
                    //IntPtr handle = FindWindow("YodaoMainWndClass",null);
                    PostMessage(handle, WM_SYSCOMMAND, SC_MINIMIZE, 0);
                }
            }
        }

        private static void selectWindow(Process process)
        {
            IntPtr handle = process.MainWindowHandle;
            SendMessage(handle, WM_SYSCOMMAND2, new IntPtr(SC_MAXIMIZE2), IntPtr.Zero); // 最大化
            SwitchToThisWindow(handle, true); // 激活
        }

        public static void selectWindow(string processName, string path = null)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            foreach (var item in processes)
            {
                if (item.MainModule?.FileName == path || path == null)
                {
                    selectWindow(item);
                    break;
                }
            }
        }
    }
}
