using System;
using System.Drawing;
using System.Text;
using System.Threading;
using WindowsFormsScript.Simulate;
using WindowsFormsScript.Util;

namespace WindowsFormsScript.RunTime
{
    public class JSInterface
    {
        public static int defaultSleepTime = 1000;
        private readonly Action<string> webLogListener;
        public bool stop = false;

        public JSInterface(Action<string> action)
        {
            webLogListener = action;
        }

        public void sleep(int time)
        {
            if (stop)
            {
                return;
            }
            setMessage($"暂停 {time / 1000.0} 秒");
            Thread.Sleep(time);
        }

        public void click(int x, int y)
        {
            if (stop)
            {
                return;
            }
            setMessage($"移动到 ({x}, {y}) 进行点击");
            SimulateMouse.MouseToAnimation(new Point(x, y));
            SimulateMouse.MouseLeftClick();
            Thread.Sleep(defaultSleepTime);
        }

        public void input(string content, int time)
        {
            if (stop)
            {
                return;
            }
            setMessage($"输入内容 {content} 每个文字间隔 {time / 1000.0} 秒");
            SimulateKeyboard.PressContent(content, time);
            Thread.Sleep(defaultSleepTime);
        }

        public void inputKey(string content, int time)
        {
            if (stop)
            {
                return;
            }
            SimulateKeyboard.PressKey(content, time);
            Thread.Sleep(defaultSleepTime);
        }

        public void selectApp(string name, string path)
        {
            if (stop)
            {
                return;
            }
            var base64 = Convert.FromBase64String(name);
            string nname = Encoding.UTF8.GetString(base64);
            base64 = Convert.FromBase64String(path);
            string npath = Encoding.UTF8.GetString(base64);
            setMessage($"选择 {nname} 运用");
            WinUtil.selectWindow(nname, npath);
            Thread.Sleep(defaultSleepTime);
        }

        public void setMessage(string msg)
        {
            webLogListener?.Invoke(msg);
        }
    }
}
