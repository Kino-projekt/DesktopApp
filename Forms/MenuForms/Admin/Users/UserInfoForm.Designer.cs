namespace DesktopApp.Forms.MenuForms.Admin.Users
{
    partial class UserInfoForm
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.banButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.idLabel = new MaterialSkin.Controls.MaterialLabel();
            this.roleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.emailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.contentPanel.Controls.Add(this.banButton);
            this.contentPanel.Controls.Add(this.materialRaisedButton1);
            this.contentPanel.Controls.Add(this.idLabel);
            this.contentPanel.Controls.Add(this.roleLabel);
            this.contentPanel.Controls.Add(this.emailLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(760, 60);
            this.contentPanel.TabIndex = 1;
            // 
            // banButton
            // 
            this.banButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.banButton.Depth = 0;
            this.banButton.Location = new System.Drawing.Point(655, 28);
            this.banButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.banButton.Name = "banButton";
            this.banButton.Primary = true;
            this.banButton.Size = new System.Drawing.Size(102, 29);
            this.banButton.TabIndex = 6;
            this.banButton.Text = "Banuj!";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.Click += new System.EventHandler(this.banButton_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(331, 6);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(167, 26);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Zmień uprawnienia";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Depth = 0;
            this.idLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idLabel.Location = new System.Drawing.Point(12, 9);
            this.idLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 19);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "id";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Depth = 0;
            this.roleLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.roleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roleLabel.Location = new System.Drawing.Point(219, 9);
            this.roleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(34, 19);
            this.roleLabel.TabIndex = 1;
            this.roleLabel.Text = "text";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailLabel.Location = new System.Drawing.Point(12, 28);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 19);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "title";
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 60);
            this.Controls.Add(this.contentPanel);
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialLabel idLabel;
        private MaterialSkin.Controls.MaterialLabel roleLabel;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton banButton;
    }
}