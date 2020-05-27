namespace DesktopApp.Forms.MenuForms.Seance
{
    partial class SeanceListForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.infoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageNumberLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nextPageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.previusPageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contentPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.mainPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 600);
            this.contentPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel7);
            this.mainPanel.Controls.Add(this.panel6);
            this.mainPanel.Controls.Add(this.panel5);
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.pageNumberLabel);
            this.mainPanel.Controls.Add(this.nextPageButton);
            this.mainPanel.Controls.Add(this.previusPageButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 600);
            this.mainPanel.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(19, 499);
            this.panel7.Margin = new System.Windows.Forms.Padding(10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(762, 60);
            this.panel7.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(19, 419);
            this.panel6.Margin = new System.Windows.Forms.Padding(10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(762, 60);
            this.panel6.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(19, 339);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(762, 60);
            this.panel5.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.infoLabel);
            this.panel4.Location = new System.Drawing.Point(19, 259);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(762, 60);
            this.panel4.TabIndex = 20;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Depth = 0;
            this.infoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoLabel.Location = new System.Drawing.Point(265, -10);
            this.infoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(230, 19);
            this.infoLabel.TabIndex = 25;
            this.infoLabel.Text = "Błąd pobierania filmów z servera!";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(19, 179);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 60);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(19, 99);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 60);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 60);
            this.panel1.TabIndex = 17;
            // 
            // pageNumberLabel
            // 
            this.pageNumberLabel.AutoSize = true;
            this.pageNumberLabel.Depth = 0;
            this.pageNumberLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pageNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pageNumberLabel.Location = new System.Drawing.Point(356, 570);
            this.pageNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pageNumberLabel.Name = "pageNumberLabel";
            this.pageNumberLabel.Size = new System.Drawing.Size(53, 19);
            this.pageNumberLabel.TabIndex = 16;
            this.pageNumberLabel.Text = "Strona";
            // 
            // nextPageButton
            // 
            this.nextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPageButton.Depth = 0;
            this.nextPageButton.Location = new System.Drawing.Point(444, 562);
            this.nextPageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Primary = true;
            this.nextPageButton.Size = new System.Drawing.Size(166, 34);
            this.nextPageButton.TabIndex = 9;
            this.nextPageButton.Text = "Następna strona";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // previusPageButton
            // 
            this.previusPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previusPageButton.Depth = 0;
            this.previusPageButton.Location = new System.Drawing.Point(167, 562);
            this.previusPageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.previusPageButton.Name = "previusPageButton";
            this.previusPageButton.Primary = true;
            this.previusPageButton.Size = new System.Drawing.Size(166, 34);
            this.previusPageButton.TabIndex = 8;
            this.previusPageButton.Text = "Poprzednia strona";
            this.previusPageButton.UseVisualStyleBackColor = true;
            this.previusPageButton.Click += new System.EventHandler(this.previusPageButton_Click);
            // 
            // SeanceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.contentPanel);
            this.Name = "SeanceListForm";
            this.Text = "SeanceForm";
            this.contentPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel infoLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel pageNumberLabel;
        private MaterialSkin.Controls.MaterialRaisedButton nextPageButton;
        private MaterialSkin.Controls.MaterialRaisedButton previusPageButton;
    }
}