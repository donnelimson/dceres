namespace DBO2.Forms.POSMainForms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.DepartmentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TaskbarPanel = new System.Windows.Forms.Panel();
            this.DateTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.AppUserFullNameLabel = new MetroFramework.Controls.MetroLabel();
            this.MainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.TaskbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartmentPanel
            // 
            this.DepartmentPanel.Location = new System.Drawing.Point(0, 433);
            this.DepartmentPanel.Name = "DepartmentPanel";
            this.DepartmentPanel.Size = new System.Drawing.Size(509, 252);
            this.DepartmentPanel.TabIndex = 0;
            // 
            // TaskbarPanel
            // 
            this.TaskbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.TaskbarPanel.Controls.Add(this.DateTimeLabel);
            this.TaskbarPanel.Controls.Add(this.AppUserFullNameLabel);
            this.TaskbarPanel.Location = new System.Drawing.Point(0, 735);
            this.TaskbarPanel.Name = "TaskbarPanel";
            this.TaskbarPanel.Size = new System.Drawing.Size(1026, 33);
            this.TaskbarPanel.TabIndex = 1;
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.DateTimeLabel.CustomBackground = true;
            this.DateTimeLabel.CustomForeColor = true;
            this.DateTimeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DateTimeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.DateTimeLabel.ForeColor = System.Drawing.Color.White;
            this.DateTimeLabel.Location = new System.Drawing.Point(818, 8);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(111, 25);
            this.DateTimeLabel.TabIndex = 3;
            this.DateTimeLabel.Text = "metroLabel1";
            // 
            // AppUserFullNameLabel
            // 
            this.AppUserFullNameLabel.AutoSize = true;
            this.AppUserFullNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.AppUserFullNameLabel.CustomBackground = true;
            this.AppUserFullNameLabel.CustomForeColor = true;
            this.AppUserFullNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AppUserFullNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.AppUserFullNameLabel.ForeColor = System.Drawing.Color.White;
            this.AppUserFullNameLabel.Location = new System.Drawing.Point(3, 8);
            this.AppUserFullNameLabel.Name = "AppUserFullNameLabel";
            this.AppUserFullNameLabel.Size = new System.Drawing.Size(111, 25);
            this.AppUserFullNameLabel.TabIndex = 2;
            this.AppUserFullNameLabel.Text = "metroLabel1";
            // 
            // MainFormTimer
            // 
            this.MainFormTimer.Enabled = true;
            this.MainFormTimer.Tick += new System.EventHandler(this.MainFormTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.TaskbarPanel);
            this.Controls.Add(this.DepartmentPanel);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TaskbarPanel.ResumeLayout(false);
            this.TaskbarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel DepartmentPanel;
        private System.Windows.Forms.Panel TaskbarPanel;
        private MetroFramework.Controls.MetroLabel AppUserFullNameLabel;
        private MetroFramework.Controls.MetroLabel DateTimeLabel;
        private System.Windows.Forms.Timer MainFormTimer;
    }
}