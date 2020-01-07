namespace WindowsFormsScript
{
    partial class FrmScript
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listLeft = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listRight = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddSelect = new System.Windows.Forms.Button();
            this.btnAddPause = new System.Windows.Forms.Button();
            this.btnAddKey = new System.Windows.Forms.Button();
            this.btnAddMouse = new System.Windows.Forms.Button();
            this.labDelete = new System.Windows.Forms.Label();
            this.labEdit = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 450);
            this.panel1.TabIndex = 0;
            // 
            // listLeft
            // 
            this.listLeft.AllowDrop = true;
            this.listLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLeft.FormattingEnabled = true;
            this.listLeft.IntegralHeight = false;
            this.listLeft.ItemHeight = 15;
            this.listLeft.Location = new System.Drawing.Point(0, 0);
            this.listLeft.Name = "listLeft";
            this.listLeft.Size = new System.Drawing.Size(350, 450);
            this.listLeft.TabIndex = 0;
            this.listLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListLeft_DragDrop);
            this.listLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListLeft_DragEnter);
            this.listLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListLeft_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listRight);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(470, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 450);
            this.panel2.TabIndex = 1;
            // 
            // listRight
            // 
            this.listRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRight.FormattingEnabled = true;
            this.listRight.IntegralHeight = false;
            this.listRight.ItemHeight = 15;
            this.listRight.Location = new System.Drawing.Point(0, 0);
            this.listRight.Name = "listRight";
            this.listRight.Size = new System.Drawing.Size(350, 425);
            this.listRight.TabIndex = 1;
            this.listRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListLeft_DragDrop);
            this.listRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListLeft_DragEnter);
            this.listRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListLeft_MouseDown);
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSearch.Location = new System.Drawing.Point(0, 425);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.labEdit);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.labDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(350, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 450);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddSelect);
            this.panel4.Controls.Add(this.btnAddPause);
            this.panel4.Controls.Add(this.btnAddKey);
            this.panel4.Controls.Add(this.btnAddMouse);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 160);
            this.panel4.TabIndex = 1;
            // 
            // btnAddSelect
            // 
            this.btnAddSelect.Location = new System.Drawing.Point(10, 118);
            this.btnAddSelect.Name = "btnAddSelect";
            this.btnAddSelect.Size = new System.Drawing.Size(100, 30);
            this.btnAddSelect.TabIndex = 3;
            this.btnAddSelect.Tag = "3";
            this.btnAddSelect.Text = "运用选择";
            this.btnAddSelect.UseVisualStyleBackColor = true;
            this.btnAddSelect.Click += new System.EventHandler(this.BtnAddEvent_Click);
            // 
            // btnAddPause
            // 
            this.btnAddPause.Location = new System.Drawing.Point(10, 82);
            this.btnAddPause.Name = "btnAddPause";
            this.btnAddPause.Size = new System.Drawing.Size(100, 30);
            this.btnAddPause.TabIndex = 2;
            this.btnAddPause.Tag = "2";
            this.btnAddPause.Text = "添加暂停";
            this.btnAddPause.UseVisualStyleBackColor = true;
            this.btnAddPause.Click += new System.EventHandler(this.BtnAddEvent_Click);
            // 
            // btnAddKey
            // 
            this.btnAddKey.Location = new System.Drawing.Point(10, 46);
            this.btnAddKey.Name = "btnAddKey";
            this.btnAddKey.Size = new System.Drawing.Size(100, 30);
            this.btnAddKey.TabIndex = 1;
            this.btnAddKey.Tag = "1";
            this.btnAddKey.Text = "添加键盘";
            this.btnAddKey.UseVisualStyleBackColor = true;
            this.btnAddKey.Click += new System.EventHandler(this.BtnAddEvent_Click);
            // 
            // btnAddMouse
            // 
            this.btnAddMouse.Location = new System.Drawing.Point(10, 10);
            this.btnAddMouse.Name = "btnAddMouse";
            this.btnAddMouse.Size = new System.Drawing.Size(100, 30);
            this.btnAddMouse.TabIndex = 0;
            this.btnAddMouse.Tag = "0";
            this.btnAddMouse.Text = "添加鼠标";
            this.btnAddMouse.UseVisualStyleBackColor = true;
            this.btnAddMouse.Click += new System.EventHandler(this.BtnAddEvent_Click);
            // 
            // labDelete
            // 
            this.labDelete.AllowDrop = true;
            this.labDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labDelete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDelete.Location = new System.Drawing.Point(0, 410);
            this.labDelete.Name = "labDelete";
            this.labDelete.Size = new System.Drawing.Size(120, 40);
            this.labDelete.TabIndex = 0;
            this.labDelete.Tag = "0";
            this.labDelete.Text = "删除";
            this.labDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labDelete.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabDelete_DragDrop);
            this.labDelete.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListLeft_DragEnter);
            // 
            // labEdit
            // 
            this.labEdit.AllowDrop = true;
            this.labEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labEdit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labEdit.Location = new System.Drawing.Point(0, 370);
            this.labEdit.Name = "labEdit";
            this.labEdit.Size = new System.Drawing.Size(120, 40);
            this.labEdit.TabIndex = 2;
            this.labEdit.Tag = "1";
            this.labEdit.Text = "编辑";
            this.labEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labEdit.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabDelete_DragDrop);
            this.labEdit.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListLeft_DragEnter);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.txtRemarks);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 161);
            this.panel5.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "名字";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(101, 25);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "备注";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(10, 77);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(100, 25);
            this.txtRemarks.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Tag = "3";
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "脚本编辑";
            this.Load += new System.EventHandler(this.FrmScript_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listLeft;
        private System.Windows.Forms.ListBox listRight;
        private System.Windows.Forms.Label labDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddMouse;
        private System.Windows.Forms.Button btnAddKey;
        private System.Windows.Forms.Button btnAddPause;
        private System.Windows.Forms.Button btnAddSelect;
        private System.Windows.Forms.Label labEdit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnSave;
    }
}