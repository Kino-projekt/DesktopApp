namespace DesktopApp.Forms.MenuForms.Admin.Users
{
    partial class UsersListForm
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
            this.pageNumberLabel = new MaterialSkin.Controls.MaterialLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.infoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextPageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.previusPageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contentPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.pageNumberLabel);
            this.contentPanel.Controls.Add(this.panel6);
            this.contentPanel.Controls.Add(this.panel5);
            this.contentPanel.Controls.Add(this.panel4);
            this.contentPanel.Controls.Add(this.panel3);
            this.contentPanel.Controls.Add(this.panel2);
            this.contentPanel.Controls.Add(this.panel1);
            this.contentPanel.Controls.Add(this.nextPageButton);
            this.contentPanel.Controls.Add(this.previusPageButton);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(786, 455);
            this.contentPanel.TabIndex = 1;
            // 
            // pageNumberLabel
            // 
            this.pageNumberLabel.AutoSize = true;
            this.pageNumberLabel.Depth = 0;
            this.pageNumberLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pageNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pageNumberLabel.Location = new System.Drawing.Point(350, 416);
            this.pageNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pageNumberLabel.Name = "pageNumberLabel";
            this.pageNumberLabel.Size = new System.Drawing.Size(53, 19);
            this.pageNumberLabel.TabIndex = 15;
            this.pageNumberLabel.Text = "Strona";
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(12, 342);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(760, 60);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(12, 276);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(760, 60);
            this.panel5.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(12, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 60);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.infoLabel);
            this.panel3.Location = new System.Drawing.Point(12, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 60);
            this.panel3.TabIndex = 11;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Depth = 0;
            this.infoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoLabel.Location = new System.Drawing.Point(292, 44);
            this.infoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(180, 19);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Błąd pobierania z servera!";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 60);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 60);
            this.panel1.TabIndex = 9;
            // 
            // nextPageButton
            // 
            this.nextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPageButton.Depth = 0;
            this.nextPageButton.Location = new System.Drawing.Point(440, 408);
            this.nextPageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Primary = true;
            this.nextPageButton.Size = new System.Drawing.Size(166, 34);
            this.nextPageButton.TabIndex = 8;
            this.nextPageButton.Text = "Następna strona";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click_1);
            // 
            // previusPageButton
            // 
            this.previusPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previusPageButton.Depth = 0;
            this.previusPageButton.Location = new System.Drawing.Point(166, 408);
            this.previusPageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.previusPageButton.Name = "previusPageButton";
            this.previusPageButton.Primary = true;
            this.previusPageButton.Size = new System.Drawing.Size(166, 34);
            this.previusPageButton.TabIndex = 7;
            this.previusPageButton.Text = "Poprzednia strona";
            this.previusPageButton.UseVisualStyleBackColor = true;
            this.previusPageButton.Click += new System.EventHandler(this.previusPageButton_Click_1);
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 455);
            this.Controls.Add(this.contentPanel);
            this.Name = "UsersListForm";
            this.Text = "UsersListForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialLabel pageNumberLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel infoLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton nextPageButton;
        private MaterialSkin.Controls.MaterialRaisedButton previusPageButton;
    }
}