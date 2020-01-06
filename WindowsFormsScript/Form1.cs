using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsScript.Simulate;
using WindowsFormsScript.Util;

namespace WindowsFormsScript
{
    public partial class Form1 : Form
    {

        public Form1()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var workingArea = PrimaryScreen.DESKTOP;
            //SimulateMouse.MouseToAnimation(new Point(workingArea.Width, workingArea.Height));
            WinUtil.minWindow("msedge");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WinUtil.selectWindow("editplus");
        }
    }
}
