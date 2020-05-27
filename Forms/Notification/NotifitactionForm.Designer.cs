namespace DesktopApp.Forms.Notification
{
    partial class NotifitactionForm
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.textLabel = new MaterialSkin.Controls.MaterialLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.textLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(320, 40);
            this.contentPanel.TabIndex = 0;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Depth = 0;
            this.textLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.textLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textLabel.Location = new System.Drawing.Point(12, 9);
            this.textLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(108, 19);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "materialLabel1";
            // 
            // timer
            // 
            this.timer.Interval = 8000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // NotifitactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(320, 40);
            this.Controls.Add(this.contentPanel);
            this.Name = "NotifitactionForm";
            this.Text = "NotifitactionForm";
            this.Load += new System.EventHandler(this.NotifitactionForm_Load);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialLabel textLabel;
        private System.Windows.Forms.Timer timer;
    }
}