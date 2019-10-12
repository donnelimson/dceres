namespace DBO2
{
    partial class LoginForm
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
            this.UsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.UsernameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.DCERESLabel = new System.Windows.Forms.Label();
            this.LoginButton = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UsernameLabel.Location = new System.Drawing.Point(173, 385);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(89, 25);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PasswordLabel.Location = new System.Drawing.Point(180, 459);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 25);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.UsernameTextbox.Location = new System.Drawing.Point(296, 375);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(445, 35);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PasswordTextbox.Location = new System.Drawing.Point(296, 449);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '•';
            this.PasswordTextbox.Size = new System.Drawing.Size(445, 35);
            this.PasswordTextbox.TabIndex = 1;
            // 
            // DCERESLabel
            // 
            this.DCERESLabel.AutoSize = true;
            this.DCERESLabel.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCERESLabel.Location = new System.Drawing.Point(0, 5);
            this.DCERESLabel.Name = "DCERESLabel";
            this.DCERESLabel.Size = new System.Drawing.Size(58, 32);
            this.DCERESLabel.TabIndex = 3;
            this.DCERESLabel.Text = "dceres";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(800, 402);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(96, 61);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.LoginButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.DCERESLabel);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "LoginForm";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel UsernameLabel;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroTextBox UsernameTextbox;
        private MetroFramework.Controls.MetroTextBox PasswordTextbox;
        private System.Windows.Forms.Label DCERESLabel;
        private MetroFramework.Controls.MetroTile LoginButton;
    }
}

