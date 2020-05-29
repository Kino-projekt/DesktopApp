namespace DesktopApp.Forms.MenuForms.Admin.Halls
{
    partial class HallsAdminInfoForm
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
            this.deleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.idLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.seatsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.contentPanel.Controls.Add(this.seatsLabel);
            this.contentPanel.Controls.Add(this.deleteButton);
            this.contentPanel.Controls.Add(this.idLabel);
            this.contentPanel.Controls.Add(this.nameLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(760, 60);
            this.contentPanel.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Depth = 0;
            this.deleteButton.Location = new System.Drawing.Point(616, 25);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Primary = true;
            this.deleteButton.Size = new System.Drawing.Size(132, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Depth = 0;
            this.nameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameLabel.Location = new System.Drawing.Point(158, 9);
            this.nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "title";
            // 
            // seatsLabel
            // 
            this.seatsLabel.AutoSize = true;
            this.seatsLabel.Depth = 0;
            this.seatsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.seatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seatsLabel.Location = new System.Drawing.Point(426, 9);
            this.seatsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(46, 19);
            this.seatsLabel.TabIndex = 6;
            this.seatsLabel.Text = "seats";
            // 
            // HallsAdminInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 60);
            this.Controls.Add(this.contentPanel);
            this.Name = "HallsAdminInfoForm";
            this.Text = "HallsAdminInfoForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialRaisedButton deleteButton;
        private MaterialSkin.Controls.MaterialLabel idLabel;
        private MaterialSkin.Controls.MaterialLabel nameLabel;
        private MaterialSkin.Controls.MaterialLabel seatsLabel;
    }
}