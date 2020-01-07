using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsScript.RunTime;
using WindowsFormsScript.Util;

namespace WindowsFormsScript
{
    public partial class FrmEvent : Form
    {
        private int tag;
        private JSScriptItem edit;
        private bool isEdit = false;

        public FrmEvent(int tag)
        {
            InitializeComponent();
            this.tag = tag;
            createItem();
            isEdit = false;
        }

        public FrmEvent(JSScriptItem item)
        {
            InitializeComponent();
            edit = item;
            getTag();
            isEdit = true;
        }

        public void getTag()
        {
            switch (edit.FunName)
            {
                case JSScriptItem.Click: tag = 0; break;
                case JSScriptItem.KeyInput: tag = 1; break;
                case JSScriptItem.Sleep: tag = 2; break;
                case JSScriptItem.SelectApp: tag = 3; break;
            }
        }

        public void createItem()
        {
            switch (tag)
            {
                case 0: edit = new JSScriptItem(JSScriptItem.Click); break;
                case 1: edit = new JSScriptItem(JSScriptItem.KeyInput); break;
                case 2: edit = new JSScriptItem(JSScriptItem.Sleep); break;
                case 3: edit = new JSScriptItem(JSScriptItem.SelectApp); break;
            }
        }

        private void FrmEvent_Load(object sender, EventArgs e)
        {
            int height = 37;
            height += 30;
            if (tag == 1)
            {
                height += 80;
            }
            else
            {
                height += 50;
            }
            panelMouse.Visible = false;
            panelInput.Visible = false;
            panelSleep.Visible = false;
            panelSelectApp.Visible = false;
            Size = new Size(Size.Width, height);
            switch (tag)
            {
                case 0:
                    panelMouse.Visible = true;
                    if (isEdit)
                    {
                        txtLocation.Text = $"X = {edit.Params[0]}, Y = {edit.Params[1]}";
                    }
                    break;
                case 1:
                    panelInput.Visible = true;
                    if (isEdit)
                    {
                        txtContent.Text = edit.Params[0];
                        txtTime.Text = edit.Params[1];
                    }
                    break;
                case 2:
                    panelSleep.Visible = true;
                    if (isEdit)
                    {
                        txtSleepTime.Text = edit.Params[0];
                    }
                    break;
                case 3:
                    panelSelectApp.Visible = true;
                    if (isEdit)
                    {
                        txtSelectApp.Text = edit.Params[0];
                    }
                    break;
            }
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.None, Keys.F8);
        }

        public JSScriptItem getItem()
        {
            return edit;
        }

        private void FrmEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            HotKey.UnregisterHotKey(Handle, 100);
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
                        case 100:
                            getCursorPosition();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        public void getCursorPosition()
        {
            var point = Cursor.Position;
            txtLocation.Text = $"X = {point.X}, Y = {point.Y}";
            txtLocation.Tag = point;

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            edit.Params.Clear();
            switch (tag)
            {
                case 0:
                    var point = (Point)txtLocation.Tag;
                    edit.Params.Add(point.X.ToString());
                    edit.Params.Add(point.Y.ToString());
                    break;
                case 1:
                    edit.Params.Add(txtContent.Text);
                    edit.Params.Add(txtTime.Text);
                    break;
                case 2:
                    edit.Params.Add(txtTime.Text);
                    break;
                case 3:
                    edit.Params.Add(txtSelectApp.Text);
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
