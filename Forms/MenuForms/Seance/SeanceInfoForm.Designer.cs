namespace DesktopApp.Forms.MenuForms.Seance
{
    partial class SeanceInfoForm
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
            this.reservationPanel = new System.Windows.Forms.Panel();
            this.reservationButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.seatsNumerField = new System.Windows.Forms.NumericUpDown();
            this.hallLabel = new MaterialSkin.Controls.MaterialLabel();
            this.movieLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.sizeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.contentPanel.SuspendLayout();
            this.reservationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumerField)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.contentPanel.Controls.Add(this.sizeLabel);
            this.contentPanel.Controls.Add(this.reservationPanel);
            this.contentPanel.Controls.Add(this.hallLabel);
            this.contentPanel.Controls.Add(this.movieLabel);
            this.contentPanel.Controls.Add(this.dateLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(762, 60);
            this.contentPanel.TabIndex = 3;
            // 
            // reservationPanel
            // 
            this.reservationPanel.Controls.Add(this.reservationButton);
            this.reservationPanel.Controls.Add(this.materialLabel2);
            this.reservationPanel.Controls.Add(this.materialLabel1);
            this.reservationPanel.Controls.Add(this.seatsNumerField);
            this.reservationPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.reservationPanel.Location = new System.Drawing.Point(514, 0);
            this.reservationPanel.Name = "reservationPanel";
            this.reservationPanel.Size = new System.Drawing.Size(248, 60);
            this.reservationPanel.TabIndex = 4;
            // 
            // reservationButton
            // 
            this.reservationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservationButton.Depth = 0;
            this.reservationButton.Location = new System.Drawing.Point(139, 31);
            this.reservationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Primary = true;
            this.reservationButton.Size = new System.Drawing.Size(97, 22);
            this.reservationButton.TabIndex = 6;
            this.reservationButton.Text = "Rezerwuje!";
            this.reservationButton.UseVisualStyleBackColor = true;
            this.reservationButton.Click += new System.EventHandler(this.reservationButton_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 31);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Numer:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(51, 5);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(146, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Rezerwacja miejsca:";
            // 
            // seatsNumerField
            // 
            this.seatsNumerField.Location = new System.Drawing.Point(78, 31);
            this.seatsNumerField.Margin = new System.Windows.Forms.Padding(0);
            this.seatsNumerField.Name = "seatsNumerField";
            this.seatsNumerField.Size = new System.Drawing.Size(58, 20);
            this.seatsNumerField.TabIndex = 3;
            // 
            // hallLabel
            // 
            this.hallLabel.AutoSize = true;
            this.hallLabel.Depth = 0;
            this.hallLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.hallLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hallLabel.Location = new System.Drawing.Point(244, 9);
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
            this.movieLabel.Location = new System.Drawing.Point(28, 9);
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
            this.dateLabel.Location = new System.Drawing.Point(28, 32);
            this.dateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 19);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "date";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Depth = 0;
            this.sizeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.sizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sizeLabel.Location = new System.Drawing.Point(244, 34);
            this.sizeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(33, 19);
            this.sizeLabel.TabIndex = 5;
            this.sizeLabel.Text = "hall";
            // 
            // SeanceInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 60);
            this.Controls.Add(this.contentPanel);
            this.Name = "SeanceInfoForm";
            this.Text = "SeanceInfoForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.reservationPanel.ResumeLayout(false);
            this.reservationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumerField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialLabel hallLabel;
        private MaterialSkin.Controls.MaterialLabel movieLabel;
        private MaterialSkin.Controls.MaterialLabel dateLabel;
        private System.Windows.Forms.Panel reservationPanel;
        private System.Windows.Forms.NumericUpDown seatsNumerField;
        private MaterialSkin.Controls.MaterialRaisedButton reservationButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel sizeLabel;
    }
}