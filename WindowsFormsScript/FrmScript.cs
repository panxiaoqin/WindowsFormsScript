using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsScript.RunTime;

namespace WindowsFormsScript
{
    public partial class FrmScript : Form
    {
        private readonly BindingList<object> leftBindData = new BindingList<object>();
        private readonly BindingList<object> rightBindData = new BindingList<object>();

        private ListBox listSource;//拖动源

        public FrmScript()
        {
            InitializeComponent();
        }

        public void reloadRightData()
        {
            string filter = txtSearch.Text.Trim();
            rightBindData.Clear();
            foreach (var item in JSScript.getFileItems())
            {
                if (string.IsNullOrWhiteSpace(filter))
                {
                    rightBindData.Add(item);
                }
                else if (item.FunName.Contains(filter))
                {
                    rightBindData.Add(item);
                }
            }
        }

        private void FrmScript_Load(object sender, EventArgs e)
        {
            reloadRightData();
            listLeft.DataSource = leftBindData;
            listRight.DataSource = rightBindData;
        }

        private void ListLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox == null)
            {
                return;
            }
            int index = listBox.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            listSource = listBox;
            DoDragDrop(listBox.Items[index], DragDropEffects.Move);
        }

        private void ListLeft_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(typeof(JSScriptItem)) ? DragDropEffects.Move : DragDropEffects.None;
        }

        private void ListLeft_DragDrop(object sender, DragEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            BindingList<object> binding = listBox?.DataSource as BindingList<object>;
            if (binding == null)
            {
                return;
            }
            object dragItem = e.Data.GetData(typeof(JSScriptItem));
            if (listBox.Equals(listSource))
            {
                binding.RemoveAt(listBox.SelectedIndex);
            }
            int indexOfTarget = listBox.IndexFromPoint(listBox.PointToClient(new Point(e.X, e.Y)));
            if (indexOfTarget == -1)
            {
                binding.Add(dragItem);
                listBox.SelectedIndex = binding.Count - 1;
            }
            else
            {
                binding.Insert(indexOfTarget, dragItem);
                listBox.SelectedIndex = indexOfTarget;
            }
        }

        private void LabDelete_DragDrop(object sender, DragEventArgs e)
        {
            Label lab = sender as Label;
            int tag = Convert.ToInt32(lab?.Tag ?? "0");
            BindingList<object> binding = listSource?.DataSource as BindingList<object>;
            JSScriptItem dragItem = (JSScriptItem)e.Data.GetData(typeof(JSScriptItem));
            if (binding == null)
            {
                return;
            }
            switch (tag)
            {
                case 0:
                    {
                        if (listSource == listRight)
                        {
                            if (MessageBox.Show("确定要删除吗?", "删除脚本", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                JSScript.deleteFile(dragItem.Params[0]);
                                reloadRightData();
                            }
                        }
                        else
                        {
                            binding.RemoveAt(listSource.SelectedIndex);
                        }
                    }
                    break;
                case 1:
                    {
                        if (dragItem.FunName == JSScriptItem.Script)
                        {
                            editScript(dragItem);
                            return;
                        }
                        FrmEvent frmEvent = new FrmEvent(dragItem);
                        if (frmEvent.ShowDialog() == DialogResult.OK)
                        {
                            binding[listSource.SelectedIndex] = frmEvent.getItem();
                        }
                    }
                    break;
            }
        }

        public void editScript(JSScriptItem dragItem)
        {
            var script = new JSScript(dragItem.Params[0]);
            leftBindData.Clear();
            foreach (var item in script.Items)
            {
                leftBindData.Add(item);
            }
            txtName.Text = script.Name;
            txtRemarks.Text = script.Remarks;
        }

        private void BtnAddEvent_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null)
            {
                return;
            }
            int tag = Convert.ToInt32(btn.Tag);
            FrmEvent frmEvent = new FrmEvent(tag);
            if (frmEvent.ShowDialog() == DialogResult.OK)
            {
                leftBindData.Add(frmEvent.getItem());
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            reloadRightData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var script = new JSScript(txtName.Text, txtRemarks.Text);
            foreach (JSScriptItem item in leftBindData)
            {
                script.Items.Add(item);
            }
            script.toFile();
            leftBindData.Clear();
            reloadRightData();
            txtName.Text = txtRemarks.Text = "";
        }
    }
}
