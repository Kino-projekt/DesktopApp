namespace DesktopApp.Forms.MenuForms.Settings
{
    partial class SettingsForm
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
            this.themePanel = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.blueButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.greenButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.redButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.purpleButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contentPanel.SuspendLayout();
            this.themePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.themePanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 600);
            this.contentPanel.TabIndex = 0;
            // 
            // themePanel
            // 
            this.themePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.themePanel.Controls.Add(this.purpleButton);
            this.themePanel.Controls.Add(this.redButton);
            this.themePanel.Controls.Add(this.greenButton);
            this.themePanel.Controls.Add(this.materialLabel1);
            this.themePanel.Controls.Add(this.blueButton);
            this.themePanel.Location = new System.Drawing.Point(19, 19);
            this.themePanel.Margin = new System.Windows.Forms.Padding(10);
            this.themePanel.Name = "themePanel";
            this.themePanel.Size = new System.Drawing.Size(762, 120);
            this.themePanel.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(64, 52);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Motyw graficzny:";
            // 
            // blueButton
            // 
            this.blueButton.Depth = 0;
            this.blueButton.Location = new System.Drawing.Point(222, 27);
            this.blueButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.blueButton.Name = "blueButton";
            this.blueButton.Primary = true;
            this.blueButton.Size = new System.Drawing.Size(123, 44);
            this.blueButton.TabIndex = 4;
            this.blueButton.Text = "Niebieski";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.Depth = 0;
            this.greenButton.Location = new System.Drawing.Point(471, 27);
            this.greenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.greenButton.Name = "greenButton";
            this.greenButton.Primary = true;
            this.greenButton.Size = new System.Drawing.Size(114, 44);
            this.greenButton.TabIndex = 6;
            this.greenButton.Text = "Zielony";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // redButton
            // 
            this.redButton.Depth = 0;
            this.redButton.Location = new System.Drawing.Point(351, 27);
            this.redButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.redButton.Name = "redButton";
            this.redButton.Primary = true;
            this.redButton.Size = new System.Drawing.Size(114, 44);
            this.redButton.TabIndex = 7;
            this.redButton.Text = "Czerwony";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.Depth = 0;
            this.purpleButton.Location = new System.Drawing.Point(591, 27);
            this.purpleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Primary = true;
            this.purpleButton.Size = new System.Drawing.Size(114, 44);
            this.purpleButton.TabIndex = 8;
            this.purpleButton.Text = "Fioletowy";
            this.purpleButton.UseVisualStyleBackColor = true;
            this.purpleButton.Click += new System.EventHandler(this.purpleButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.contentPanel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.contentPanel.ResumeLayout(false);
            this.themePanel.ResumeLayout(false);
            this.themePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel themePanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton blueButton;
        private MaterialSkin.Controls.MaterialRaisedButton greenButton;
        private MaterialSkin.Controls.MaterialRaisedButton redButton;
        private MaterialSkin.Controls.MaterialRaisedButton purpleButton;
    }
}