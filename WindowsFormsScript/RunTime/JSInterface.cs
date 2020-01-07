using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsScript.Simulate;
using WindowsFormsScript.Util;

namespace WindowsFormsScript.RunTime
{
    public class JSInterface
    {
        public static int defaultSleepTime = 1000;

        public void sleep(int time)
        {
            Thread.Sleep(time);
        }

        public void click(int x, int y)
        {
            SimulateMouse.MouseToAnimation(new Point(x, y));
            SimulateMouse.MouseLeftClick();
            Thread.Sleep(defaultSleepTime);
        }

        public void input(string content, int time)
        {
            SimulateKeyboard.PressContent(content, time);
            Thread.Sleep(defaultSleepTime);
        }

        public void inputKey(string content, int time)
        {
            SimulateKeyboard.PressKey(content, time);
            Thread.Sleep(defaultSleepTime);
        }

        public void selectApp(string name, string path)
        {
            var base64 = Convert.FromBase64String(name);
            string nname = Encoding.UTF8.GetString(base64);
            base64 = Convert.FromBase64String(path);
            string npath = Encoding.UTF8.GetString(base64);
            WinUtil.selectWindow(nname, npath);
            Thread.Sleep(defaultSleepTime);
        }
    }
}
