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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listRight = new System.Windows.Forms.ListBox();
            this.listLeft = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.listRight);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(450, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(350, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 450);
            this.panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 425);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 25);
            this.textBox1.TabIndex = 0;
            // 
            // listRight
            // 
            this.listRight.AllowDrop = true;
            this.listRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRight.FormattingEnabled = true;
            this.listRight.IntegralHeight = false;
            this.listRight.ItemHeight = 15;
            this.listRight.Location = new System.Drawing.Point(0, 0);
            this.listRight.Name = "listRight";
            this.listRight.Size = new System.Drawing.Size(350, 425);
            this.listRight.TabIndex = 1;
            this.listRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListRight_DragDrop);
            this.listRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListRight_DragEnter);
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
            // FrmScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listLeft;
        private System.Windows.Forms.ListBox listRight;
    }
}