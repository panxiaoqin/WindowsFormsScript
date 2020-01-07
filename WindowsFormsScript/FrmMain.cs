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
            jsi = new JSInterface();
            var workingArea = SystemInformation.WorkingArea;
            SetDesktopLocation(workingArea.Width - Size.Width, 40);
            reloadRightData();
            cboListScript.DataSource = cboBindData;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var frmScript = new FrmScript();
            frmScript.ShowDialog();
            reloadRightData();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            runTime = new JSRunTime();
            List<FileInfo> files = new List<FileInfo>();
            files.Add(new FileInfo(JSONConfig.GetPath("base.js")));
            files.AddRange(JSScript.getFiles());
            runTime.injectJS(files);
            runTime.RegisterJsObject("runtime", jsi);
            if (cboListScript.SelectedItem is JSScriptItem item)
            {
                runTime.CallFunction(item.Params[0]);
            }
        }
    }
}
