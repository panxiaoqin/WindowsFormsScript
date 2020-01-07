namespace WindowsFormsScript
{
    partial class FrmEvent
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
            this.panelMouse = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelSleep = new System.Windows.Forms.Panel();
            this.panelSelectApp = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtSleepTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSelectApp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMouse.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelSleep.SuspendLayout();
            this.panelSelectApp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMouse
            // 
            this.panelMouse.Controls.Add(this.label1);
            this.panelMouse.Controls.Add(this.txtLocation);
            this.panelMouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMouse.Location = new System.Drawing.Point(0, 0);
            this.panelMouse.Name = "panelMouse";
            this.panelMouse.Size = new System.Drawing.Size(382, 50);
            this.panelMouse.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.txtTime);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.txtContent);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 50);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(382, 80);
            this.panelInput.TabIndex = 1;
            // 
            // panelSleep
            // 
            this.panelSleep.Controls.Add(this.txtSleepTime);
            this.panelSleep.Controls.Add(this.label4);
            this.panelSleep.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSleep.Location = new System.Drawing.Point(0, 130);
            this.panelSleep.Name = "panelSleep";
            this.panelSleep.Size = new System.Drawing.Size(382, 50);
            this.panelSleep.TabIndex = 2;
            // 
            // panelSelectApp
            // 
            this.panelSelectApp.Controls.Add(this.txtSelectApp);
            this.panelSelectApp.Controls.Add(this.label5);
            this.panelSelectApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectApp.Location = new System.Drawing.Point(0, 180);
            this.panelSelectApp.Name = "panelSelectApp";
            this.panelSelectApp.Size = new System.Drawing.Size(382, 50);
            this.panelSelectApp.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(115, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(149, 30);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(115, 12);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(255, 25);
            this.txtLocation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "鼠标点击位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入内容";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(115, 12);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(255, 25);
            this.txtContent.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "间隔时间";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(115, 44);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(255, 25);
            this.txtTime.TabIndex = 3;
            // 
            // txtSleepTime
            // 
            this.txtSleepTime.Location = new System.Drawing.Point(115, 12);
            this.txtSleepTime.Name = "txtSleepTime";
            this.txtSleepTime.Size = new System.Drawing.Size(255, 25);
            this.txtSleepTime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "间隔时间";
            // 
            // txtSelectApp
            // 
            this.txtSelectApp.Location = new System.Drawing.Point(115, 12);
            this.txtSelectApp.Name = "txtSelectApp";
            this.txtSelectApp.Size = new System.Drawing.Size(255, 25);
            this.txtSelectApp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "选择运用";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 53);
            this.panel1.TabIndex = 5;
            // 
            // FrmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSelectApp);
            this.Controls.Add(this.panelSleep);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelMouse);
            this.MaximizeBox = false;
            this.Name = "FrmEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑事件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEvent_FormClosing);
            this.Load += new System.EventHandler(this.FrmEvent_Load);
            this.panelMouse.ResumeLayout(false);
            this.panelMouse.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelSleep.ResumeLayout(false);
            this.panelSleep.PerformLayout();
            this.panelSelectApp.ResumeLayout(false);
            this.panelSelectApp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMouse;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelSleep;
        private System.Windows.Forms.Panel panelSelectApp;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSleepTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSelectApp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}