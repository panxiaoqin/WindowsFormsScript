using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WindowsFormsScript.RunTime;
using WindowsFormsScript.Util;

namespace WindowsFormsScript
{
    public partial class FrmMain : Form
    {
        private JSRunTime runTime;
        private JSInterface jsi;
        private readonly BindingList<object> cboBindData = new BindingList<object>();

        public FrmMain()
        {
            InitializeComponent();
            //var a = PrimaryScreen.DpiX;
            //var b = PrimaryScreen.ScaleX;
            //var c = PrimaryScreen.DESKTOP;
            //var d = PrimaryScreen.WorkingArea;
            //StartPosition = FormStartPosition.CenterParent;
            //var workingArea = PrimaryScreen.WorkingArea;
            //SimulateMouse.MouseToAnimation(new Point(workingArea.Width, workingArea.Height));
            //WinUtil.minWindow("msedge");
            //WinUtil.selectWindow("editplus");
        }

        public void reloadRightData()
        {
            cboBindData.Clear();
            foreach (var item in JSScript.getFileItems())
            {
                cboBindData.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jsi = new JSInterface(SetInfo);
            var workingArea = SystemInformation.WorkingArea;
            SetDesktopLocation(workingArea.Width - Size.Width, 40);
            reloadRightData();
            cboListScript.DataSource = cboBindData;
            HotKey.RegisterHotKey(Handle, 101, HotKey.KeyModifiers.Ctrl, Keys.F12);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var frmScript = new FrmScript();
            frmScript.ShowDialog();
            reloadRightData();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            runTime = new JSRunTime(SetInfo);
            List<FileInfo> files = new List<FileInfo>();
            files.Add(new FileInfo(JSONConfig.GetPath("base.js")));
            files.AddRange(JSScript.getFiles());
            runTime.injectJS(files);
            runTime.RegisterJsObject("runtime", jsi);
            if (cboListScript.SelectedItem is JSScriptItem item)
            {
                jsi.stop = false;
                runTime.CallFunction(item.Params[0]);
            }
        }

        public void SetInfo(string mess)
        {
            Console.WriteLine(mess);
            try
            {
                if (IsDisposed)
                {
                    return;
                }
                Invoke(new EventHandler(delegate
                {
                    txtInfo.AppendText(mess + "\r\n");
                    txtInfo.SelectionStart = txtInfo.Text.Length;
                    txtInfo.ScrollToCaret();
                }));
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            HotKey.UnregisterHotKey(Handle, 101);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            //按快捷键 
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 101:
                            jsi.stop = true;
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }
    }
}
