namespace DesktopApp.Forms.LoadForm
{
    partial class LoadingForm
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
            this.progressPanel = new System.Windows.Forms.Panel();
            this.textLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.progressPanel);
            this.contentPanel.Controls.Add(this.textLabel);
            this.contentPanel.Controls.Add(this.materialRaisedButton1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(500, 120);
            this.contentPanel.TabIndex = 0;
            // 
            // progressPanel
            // 
            this.progressPanel.Location = new System.Drawing.Point(50, 76);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(400, 32);
            this.progressPanel.TabIndex = 2;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Depth = 0;
            this.textLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.textLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textLabel.Location = new System.Drawing.Point(46, 54);
            this.textLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(35, 19);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "info";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(353, 12);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(135, 32);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Zamknij program";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 120);
            this.Controls.Add(this.contentPanel);
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.TopMost = true;
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel progressPanel;
        private MaterialSkin.Controls.MaterialLabel textLabel;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}