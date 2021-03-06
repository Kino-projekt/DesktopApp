﻿namespace DesktopApp.Forms.MenuForms.Settings
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
            this.deleteDataPanel = new System.Windows.Forms.Panel();
            this.deleteDataButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.themePanel = new System.Windows.Forms.Panel();
            this.springButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pinkButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.purpleButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.orangeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lightBlueButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.greenButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.redButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.blueButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.authorPanel = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.contentPanel.SuspendLayout();
            this.deleteDataPanel.SuspendLayout();
            this.themePanel.SuspendLayout();
            this.authorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.authorPanel);
            this.contentPanel.Controls.Add(this.deleteDataPanel);
            this.contentPanel.Controls.Add(this.themePanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 600);
            this.contentPanel.TabIndex = 0;
            // 
            // deleteDataPanel
            // 
            this.deleteDataPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteDataPanel.Controls.Add(this.deleteDataButton);
            this.deleteDataPanel.Location = new System.Drawing.Point(19, 159);
            this.deleteDataPanel.Margin = new System.Windows.Forms.Padding(10);
            this.deleteDataPanel.Name = "deleteDataPanel";
            this.deleteDataPanel.Size = new System.Drawing.Size(762, 85);
            this.deleteDataPanel.TabIndex = 4;
            // 
            // deleteDataButton
            // 
            this.deleteDataButton.AutoSize = true;
            this.deleteDataButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteDataButton.Depth = 0;
            this.deleteDataButton.Location = new System.Drawing.Point(253, 24);
            this.deleteDataButton.Margin = new System.Windows.Forms.Padding(10);
            this.deleteDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteDataButton.Name = "deleteDataButton";
            this.deleteDataButton.Primary = false;
            this.deleteDataButton.Size = new System.Drawing.Size(249, 36);
            this.deleteDataButton.TabIndex = 4;
            this.deleteDataButton.Text = "Usuń lokalne dane użytkownika";
            this.deleteDataButton.UseVisualStyleBackColor = true;
            this.deleteDataButton.Click += new System.EventHandler(this.deleteDataButton_Click);
            // 
            // themePanel
            // 
            this.themePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.themePanel.Controls.Add(this.springButton);
            this.themePanel.Controls.Add(this.pinkButton);
            this.themePanel.Controls.Add(this.purpleButton);
            this.themePanel.Controls.Add(this.orangeButton);
            this.themePanel.Controls.Add(this.lightBlueButton);
            this.themePanel.Controls.Add(this.materialLabel1);
            this.themePanel.Controls.Add(this.greenButton);
            this.themePanel.Controls.Add(this.redButton);
            this.themePanel.Controls.Add(this.blueButton);
            this.themePanel.Location = new System.Drawing.Point(19, 19);
            this.themePanel.Margin = new System.Windows.Forms.Padding(10);
            this.themePanel.Name = "themePanel";
            this.themePanel.Size = new System.Drawing.Size(762, 120);
            this.themePanel.TabIndex = 3;
            // 
            // springButton
            // 
            this.springButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.springButton.Depth = 0;
            this.springButton.Location = new System.Drawing.Point(344, 63);
            this.springButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.springButton.Name = "springButton";
            this.springButton.Primary = true;
            this.springButton.Size = new System.Drawing.Size(132, 44);
            this.springButton.TabIndex = 12;
            this.springButton.Text = "jasny zielony";
            this.springButton.UseVisualStyleBackColor = true;
            this.springButton.Click += new System.EventHandler(this.springButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinkButton.Depth = 0;
            this.pinkButton.Location = new System.Drawing.Point(620, 63);
            this.pinkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Primary = true;
            this.pinkButton.Size = new System.Drawing.Size(132, 44);
            this.pinkButton.TabIndex = 11;
            this.pinkButton.Text = "Różowy";
            this.pinkButton.UseVisualStyleBackColor = true;
            this.pinkButton.Click += new System.EventHandler(this.pinkButton_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purpleButton.Depth = 0;
            this.purpleButton.Location = new System.Drawing.Point(620, 13);
            this.purpleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Primary = true;
            this.purpleButton.Size = new System.Drawing.Size(132, 44);
            this.purpleButton.TabIndex = 8;
            this.purpleButton.Text = "Fioletowy";
            this.purpleButton.UseVisualStyleBackColor = true;
            this.purpleButton.Click += new System.EventHandler(this.purpleButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orangeButton.Depth = 0;
            this.orangeButton.Location = new System.Drawing.Point(482, 63);
            this.orangeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Primary = true;
            this.orangeButton.Size = new System.Drawing.Size(132, 44);
            this.orangeButton.TabIndex = 10;
            this.orangeButton.Text = "pomarańczowy";
            this.orangeButton.UseVisualStyleBackColor = true;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // lightBlueButton
            // 
            this.lightBlueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightBlueButton.Depth = 0;
            this.lightBlueButton.Location = new System.Drawing.Point(206, 63);
            this.lightBlueButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.lightBlueButton.Name = "lightBlueButton";
            this.lightBlueButton.Primary = true;
            this.lightBlueButton.Size = new System.Drawing.Size(132, 44);
            this.lightBlueButton.TabIndex = 9;
            this.lightBlueButton.Text = "Jasny niebieski";
            this.lightBlueButton.UseVisualStyleBackColor = true;
            this.lightBlueButton.Click += new System.EventHandler(this.newColorButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(42, 53);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Motyw graficzny:";
            // 
            // greenButton
            // 
            this.greenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenButton.Depth = 0;
            this.greenButton.Location = new System.Drawing.Point(344, 13);
            this.greenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.greenButton.Name = "greenButton";
            this.greenButton.Primary = true;
            this.greenButton.Size = new System.Drawing.Size(132, 44);
            this.greenButton.TabIndex = 6;
            this.greenButton.Text = "Zielony";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // redButton
            // 
            this.redButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redButton.Depth = 0;
            this.redButton.Location = new System.Drawing.Point(482, 13);
            this.redButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.redButton.Name = "redButton";
            this.redButton.Primary = true;
            this.redButton.Size = new System.Drawing.Size(132, 44);
            this.redButton.TabIndex = 7;
            this.redButton.Text = "Czerwony";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueButton.Depth = 0;
            this.blueButton.Location = new System.Drawing.Point(206, 13);
            this.blueButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.blueButton.Name = "blueButton";
            this.blueButton.Primary = true;
            this.blueButton.Size = new System.Drawing.Size(132, 44);
            this.blueButton.TabIndex = 4;
            this.blueButton.Text = "Niebieski";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // authorPanel
            // 
            this.authorPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.authorPanel.Controls.Add(this.materialLabel2);
            this.authorPanel.Location = new System.Drawing.Point(19, 515);
            this.authorPanel.Margin = new System.Windows.Forms.Padding(10);
            this.authorPanel.Name = "authorPanel";
            this.authorPanel.Size = new System.Drawing.Size(762, 75);
            this.authorPanel.TabIndex = 5;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(269, 29);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(207, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Autor programu: Karol Jaskot";
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
            this.deleteDataPanel.ResumeLayout(false);
            this.deleteDataPanel.PerformLayout();
            this.themePanel.ResumeLayout(false);
            this.themePanel.PerformLayout();
            this.authorPanel.ResumeLayout(false);
            this.authorPanel.PerformLayout();
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
        private MaterialSkin.Controls.MaterialRaisedButton lightBlueButton;
        private MaterialSkin.Controls.MaterialRaisedButton orangeButton;
        private MaterialSkin.Controls.MaterialRaisedButton pinkButton;
        private MaterialSkin.Controls.MaterialRaisedButton springButton;
        private System.Windows.Forms.Panel deleteDataPanel;
        private MaterialSkin.Controls.MaterialFlatButton deleteDataButton;
        private System.Windows.Forms.Panel authorPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}