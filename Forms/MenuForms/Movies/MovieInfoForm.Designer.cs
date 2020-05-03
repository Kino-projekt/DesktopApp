namespace DesktopApp.Forms.MenuForms.Movies
{
    partial class MovieInfoForm
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
            this.directLabel = new MaterialSkin.Controls.MaterialLabel();
            this.descriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.contentPanel.Controls.Add(this.directLabel);
            this.contentPanel.Controls.Add(this.descriptionLabel);
            this.contentPanel.Controls.Add(this.titleLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(776, 60);
            this.contentPanel.TabIndex = 2;
            // 
            // directLabel
            // 
            this.directLabel.AutoSize = true;
            this.directLabel.Depth = 0;
            this.directLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.directLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.directLabel.Location = new System.Drawing.Point(455, 9);
            this.directLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.directLabel.Name = "directLabel";
            this.directLabel.Size = new System.Drawing.Size(57, 19);
            this.directLabel.TabIndex = 2;
            this.directLabel.Text = "reżyser";
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
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 19);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "title";
            // 
            // MovieInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 60);
            this.Controls.Add(this.contentPanel);
            this.Name = "MovieInfoForm";
            this.Text = "MovieInfoForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialLabel directLabel;
        private MaterialSkin.Controls.MaterialLabel descriptionLabel;
        private MaterialSkin.Controls.MaterialLabel titleLabel;
    }
}