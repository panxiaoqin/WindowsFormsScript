using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsScript
{
    public partial class FrmScript : Form
    {
        private BindingList<object> leftBindData = new BindingList<object>();
        private BindingList<object> rightBindData = new BindingList<object>();

        private ListBox listSource;//拖动源

        public FrmScript()
        {
            InitializeComponent();
        }

        private void FrmScript_Load(object sender, EventArgs e)
        {
            leftBindData.Add(new ListItem("1", "1"));
            leftBindData.Add(new ListItem("2", "2"));
            leftBindData.Add(new ListItem("3", "3"));
            leftBindData.Add(new ListItem("4", "4"));
            leftBindData.Add(new ListItem("5", "5"));

            listLeft.DataSource = leftBindData;
            listLeft.DisplayMember = "Name";
            //listLeft.ValueMember = "Value";

            listRight.DataSource = rightBindData;
            listRight.DisplayMember = "Name";
            //listRight.ValueMember = "Value";
        }

        private void ListLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            int index = listLeft.SelectedIndex;//为-1表示没选中
            if (index == -1 || listBox == null)
            {
                return;
            }
            listSource = listBox;
            //通过index索引找到的项，其实还是那个选中项
            object content = listBox.Items[index];
            //DragDropEffects 指定拖放操作的可能效果
            DragDropEffects dde1 = DoDragDrop(content, DragDropEffects.Move);
            //2.开始拖拽操作，s为要拖拽的数据:当执行这句话时候开始拖拽，然后系统会转到drag事件里，顺序：dragEnter-->dragDragDrop，完成后会调回。如果在下一句打断点会卡死
            //if (dde1 == DragDropEffects.Move)//如果移动成功
            //{
            //    leftBindData.RemoveAt(index);//是把自己位置的删除掉
            //}
        }

        private void ListLeft_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ListLeft_DragDrop(object sender, DragEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox == null)
            {
                return;
            }
            BindingList<object> binding = listBox.DataSource as BindingList<object>;
            if (binding == null)
            {
                return;
            }
            object dragItem = e.Data.GetData(typeof(ListItem));
            if (listBox.Equals(listSource))
            {
                binding.RemoveAt(listBox.SelectedIndex);
            }
            int indexoftarget = listBox.IndexFromPoint(listBox.PointToClient(new Point(e.X, e.Y)));
            if (indexoftarget == -1)
            {
                binding.Add(dragItem);
                listBox.SelectedIndex = binding.Count-1;
            }
            else
            {
                binding.Insert(indexoftarget, dragItem);
                listBox.SelectedIndex = indexoftarget;
            }
        }

        private void ListRight_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ListRight_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListItem)))
            {
                rightBindData.Add(e.Data.GetData(typeof(ListItem)));
            }

            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                listRight.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
            }
        }
    }

    public class ListItem
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public ListItem(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
