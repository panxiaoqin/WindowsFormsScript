using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsScript.Simulate;
using WindowsFormsScript.Util;

namespace WindowsFormsScript
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();

            //var a = PrimaryScreen.DpiX;
            //var b = PrimaryScreen.ScaleX;
            //var c = PrimaryScreen.DESKTOP;
            //var d = PrimaryScreen.WorkingArea;
            //StartPosition = FormStartPosition.CenterParent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var workingArea = SystemInformation.WorkingArea;
            SetDesktopLocation(workingArea.Width - Size.Width, 40);
            //var workingArea = PrimaryScreen.WorkingArea;
            //SimulateMouse.MouseToAnimation(new Point(workingArea.Width, workingArea.Height));
            //WinUtil.minWindow("msedge");
            //WinUtil.selectWindow("editplus");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var frmScript = new FrmScript();
            frmScript.ShowDialog();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {

        }
    }
}
