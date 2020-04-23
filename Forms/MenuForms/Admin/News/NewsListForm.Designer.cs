namespace DesktopApp.Forms.MenuForms.Admin.News
{
    partial class NewsListForm
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
            this.nextPageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.previusPageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
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
            this.contentPanel.TabIndex = 0;
            // 
            // nextPageButton
            // 
            this.nextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPageButton.Depth = 0;
            this.nextPageButton.Location = new System.Drawing.Point(385, 409);
            this.nextPageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Primary = true;
            this.nextPageButton.Size = new System.Drawing.Size(166, 34);
            this.nextPageButton.TabIndex = 8;
            this.nextPageButton.Text = "Następna strona";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // previusPageButton
            // 
            this.previusPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previusPageButton.Depth = 0;
            this.previusPageButton.Location = new System.Drawing.Point(213, 409);
            this.previusPageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.previusPageButton.Name = "previusPageButton";
            this.previusPageButton.Primary = true;
            this.previusPageButton.Size = new System.Drawing.Size(166, 34);
            this.previusPageButton.TabIndex = 7;
            this.previusPageButton.Text = "Poprzednia strona";
            this.previusPageButton.UseVisualStyleBackColor = true;
            this.previusPageButton.Click += new System.EventHandler(this.previusPageButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 60);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 60);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 60);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(12, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 60);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(12, 276);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(760, 60);
            this.panel5.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(12, 342);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(760, 60);
            this.panel6.TabIndex = 14;
            // 
            // NewsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 455);
            this.Controls.Add(this.contentPanel);
            this.Name = "NewsListForm";
            this.Text = "NewsListForm";
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialRaisedButton nextPageButton;
        private MaterialSkin.Controls.MaterialRaisedButton previusPageButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}