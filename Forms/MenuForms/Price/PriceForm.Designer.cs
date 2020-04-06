namespace DesktopApp.Forms.MenuForms.Price
{
    partial class PriceForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.contentPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.materialLabel1);
            this.contentPanel.Controls.Add(this.panel3);
            this.contentPanel.Controls.Add(this.panel2);
            this.contentPanel.Controls.Add(this.panel1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 600);
            this.contentPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.materialRaisedButton3);
            this.panel3.Location = new System.Drawing.Point(544, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 250);
            this.panel3.TabIndex = 3;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialRaisedButton3.Location = new System.Drawing.Point(0, 180);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(200, 70);
            this.materialRaisedButton3.TabIndex = 0;
            this.materialRaisedButton3.Text = "materialRaisedButton3";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialRaisedButton2);
            this.panel2.Location = new System.Drawing.Point(294, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 250);
            this.panel2.TabIndex = 3;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialRaisedButton2.Location = new System.Drawing.Point(0, 180);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(200, 70);
            this.materialRaisedButton2.TabIndex = 0;
            this.materialRaisedButton2.Text = "materialRaisedButton2";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialRaisedButton1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(52, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 250);
            this.panel1.TabIndex = 2;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialRaisedButton1.Location = new System.Drawing.Point(0, 180);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(200, 70);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "materialRaisedButton1";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(337, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Ceny biletów";
            // 
            // PriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.contentPanel);
            this.Name = "PriceForm";
            this.Text = "PriceForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}