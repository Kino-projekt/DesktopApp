namespace DesktopApp.Forms.MenuForms.Admin.Seance
{
    partial class SeanceAdminInfoForm
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
            this.hallLabel = new MaterialSkin.Controls.MaterialLabel();
            this.movieLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.contentPanel.Controls.Add(this.materialRaisedButton1);
            this.contentPanel.Controls.Add(this.hallLabel);
            this.contentPanel.Controls.Add(this.movieLabel);
            this.contentPanel.Controls.Add(this.dateLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(760, 60);
            this.contentPanel.TabIndex = 4;
            // 
            // hallLabel
            // 
            this.hallLabel.AutoSize = true;
            this.hallLabel.Depth = 0;
            this.hallLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.hallLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hallLabel.Location = new System.Drawing.Point(309, 9);
            this.hallLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hallLabel.Name = "hallLabel";
            this.hallLabel.Size = new System.Drawing.Size(33, 19);
            this.hallLabel.TabIndex = 2;
            this.hallLabel.Text = "hall";
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Depth = 0;
            this.movieLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.movieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieLabel.Location = new System.Drawing.Point(12, 9);
            this.movieLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(50, 19);
            this.movieLabel.TabIndex = 1;
            this.movieLabel.Text = "movie";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Depth = 0;
            this.dateLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateLabel.Location = new System.Drawing.Point(12, 32);
            this.dateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 19);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "date";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(653, 30);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(95, 25);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Usuń";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // SeanceAdminInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 60);
            this.Controls.Add(this.contentPanel);
            this.Name = "SeanceAdminInfoForm";
            this.Text = "SeanceAdminInfoForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialLabel hallLabel;
        private MaterialSkin.Controls.MaterialLabel movieLabel;
        private MaterialSkin.Controls.MaterialLabel dateLabel;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}