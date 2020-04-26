namespace DesktopApp.Forms.MenuForms.Admin.News
{
    partial class NewsInfoForm
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
            this.idLabel = new MaterialSkin.Controls.MaterialLabel();
            this.statusButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.statusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.descriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.contentPanel.Controls.Add(this.idLabel);
            this.contentPanel.Controls.Add(this.statusButton);
            this.contentPanel.Controls.Add(this.statusLabel);
            this.contentPanel.Controls.Add(this.descriptionLabel);
            this.contentPanel.Controls.Add(this.titleLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(760, 60);
            this.contentPanel.TabIndex = 0;
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
            // statusButton
            // 
            this.statusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusButton.Depth = 0;
            this.statusButton.Location = new System.Drawing.Point(616, 5);
            this.statusButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusButton.Name = "statusButton";
            this.statusButton.Primary = true;
            this.statusButton.Size = new System.Drawing.Size(132, 23);
            this.statusButton.TabIndex = 3;
            this.statusButton.Text = "Zmień status";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Depth = 0;
            this.statusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusLabel.Location = new System.Drawing.Point(476, 9);
            this.statusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(51, 19);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "status";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Depth = 0;
            this.descriptionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriptionLabel.Location = new System.Drawing.Point(12, 32);
            this.descriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(34, 19);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "text";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Depth = 0;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(109, 9);
            this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 19);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "title";
            // 
            // NewsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 60);
            this.Controls.Add(this.contentPanel);
            this.Name = "NewsInfoForm";
            this.Text = "NewsForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialLabel idLabel;
        private MaterialSkin.Controls.MaterialRaisedButton statusButton;
        private MaterialSkin.Controls.MaterialLabel statusLabel;
        private MaterialSkin.Controls.MaterialLabel descriptionLabel;
        private MaterialSkin.Controls.MaterialLabel titleLabel;
    }
}