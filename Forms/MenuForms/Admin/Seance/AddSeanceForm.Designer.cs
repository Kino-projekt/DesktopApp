namespace DesktopApp.Forms.MenuForms.Admin.Seance
{
    partial class AddSeanceForm
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
            this.timePickerData = new System.Windows.Forms.DateTimePicker();
            this.directLabel = new MaterialSkin.Controls.MaterialLabel();
            this.sendButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.movieLabel = new MaterialSkin.Controls.MaterialLabel();
            this.hallLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nextMovieButtopn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.previoseMovieButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.previoseHallButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.nextHallButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.previoseHallButton);
            this.contentPanel.Controls.Add(this.nextHallButton);
            this.contentPanel.Controls.Add(this.previoseMovieButton);
            this.contentPanel.Controls.Add(this.nextMovieButtopn);
            this.contentPanel.Controls.Add(this.hallLabel);
            this.contentPanel.Controls.Add(this.movieLabel);
            this.contentPanel.Controls.Add(this.timePickerData);
            this.contentPanel.Controls.Add(this.directLabel);
            this.contentPanel.Controls.Add(this.sendButton);
            this.contentPanel.Controls.Add(this.materialLabel2);
            this.contentPanel.Controls.Add(this.materialLabel1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(786, 455);
            this.contentPanel.TabIndex = 2;
            // 
            // timePickerData
            // 
            this.timePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timePickerData.Location = new System.Drawing.Point(360, 274);
            this.timePickerData.Name = "timePickerData";
            this.timePickerData.Size = new System.Drawing.Size(172, 20);
            this.timePickerData.TabIndex = 10;
            // 
            // directLabel
            // 
            this.directLabel.AutoSize = true;
            this.directLabel.Depth = 0;
            this.directLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.directLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.directLabel.Location = new System.Drawing.Point(279, 154);
            this.directLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.directLabel.Name = "directLabel";
            this.directLabel.Size = new System.Drawing.Size(42, 19);
            this.directLabel.TabIndex = 8;
            this.directLabel.Text = "Sala:";
            // 
            // sendButton
            // 
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.Depth = 0;
            this.sendButton.Location = new System.Drawing.Point(312, 354);
            this.sendButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendButton.Name = "sendButton";
            this.sendButton.Primary = true;
            this.sendButton.Size = new System.Drawing.Size(146, 44);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Wyślij";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(283, 275);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Data:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(283, 41);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(42, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Film:";
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Depth = 0;
            this.movieLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.movieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieLabel.Location = new System.Drawing.Point(349, 42);
            this.movieLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(50, 19);
            this.movieLabel.TabIndex = 14;
            this.movieLabel.Text = "movie";
            // 
            // hallLabel
            // 
            this.hallLabel.AutoSize = true;
            this.hallLabel.Depth = 0;
            this.hallLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.hallLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hallLabel.Location = new System.Drawing.Point(345, 154);
            this.hallLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hallLabel.Name = "hallLabel";
            this.hallLabel.Size = new System.Drawing.Size(33, 19);
            this.hallLabel.TabIndex = 15;
            this.hallLabel.Text = "hall";
            // 
            // nextMovieButtopn
            // 
            this.nextMovieButtopn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextMovieButtopn.Depth = 0;
            this.nextMovieButtopn.Location = new System.Drawing.Point(392, 74);
            this.nextMovieButtopn.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextMovieButtopn.Name = "nextMovieButtopn";
            this.nextMovieButtopn.Primary = true;
            this.nextMovieButtopn.Size = new System.Drawing.Size(99, 28);
            this.nextMovieButtopn.TabIndex = 16;
            this.nextMovieButtopn.Text = "Następny";
            this.nextMovieButtopn.UseVisualStyleBackColor = true;
            this.nextMovieButtopn.Click += new System.EventHandler(this.nextMovieButtopn_Click);
            // 
            // previoseMovieButton
            // 
            this.previoseMovieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previoseMovieButton.Depth = 0;
            this.previoseMovieButton.Location = new System.Drawing.Point(287, 74);
            this.previoseMovieButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.previoseMovieButton.Name = "previoseMovieButton";
            this.previoseMovieButton.Primary = true;
            this.previoseMovieButton.Size = new System.Drawing.Size(95, 28);
            this.previoseMovieButton.TabIndex = 17;
            this.previoseMovieButton.Text = "Poprzedni";
            this.previoseMovieButton.UseVisualStyleBackColor = true;
            this.previoseMovieButton.Click += new System.EventHandler(this.previoseMovieButton_Click);
            // 
            // previoseHallButton
            // 
            this.previoseHallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previoseHallButton.Depth = 0;
            this.previoseHallButton.Location = new System.Drawing.Point(283, 187);
            this.previoseHallButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.previoseHallButton.Name = "previoseHallButton";
            this.previoseHallButton.Primary = true;
            this.previoseHallButton.Size = new System.Drawing.Size(99, 28);
            this.previoseHallButton.TabIndex = 19;
            this.previoseHallButton.Text = "Poprzednia";
            this.previoseHallButton.UseVisualStyleBackColor = true;
            this.previoseHallButton.Click += new System.EventHandler(this.previoseHallButton_Click);
            // 
            // nextHallButton
            // 
            this.nextHallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextHallButton.Depth = 0;
            this.nextHallButton.Location = new System.Drawing.Point(388, 187);
            this.nextHallButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextHallButton.Name = "nextHallButton";
            this.nextHallButton.Primary = true;
            this.nextHallButton.Size = new System.Drawing.Size(99, 28);
            this.nextHallButton.TabIndex = 18;
            this.nextHallButton.Text = "Następna";
            this.nextHallButton.UseVisualStyleBackColor = true;
            this.nextHallButton.Click += new System.EventHandler(this.nextHallButton_Click);
            // 
            // AddSeanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 455);
            this.Controls.Add(this.contentPanel);
            this.Name = "AddSeanceForm";
            this.Text = "AddSeanceForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialLabel directLabel;
        private MaterialSkin.Controls.MaterialRaisedButton sendButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker timePickerData;
        private MaterialSkin.Controls.MaterialRaisedButton previoseHallButton;
        private MaterialSkin.Controls.MaterialRaisedButton nextHallButton;
        private MaterialSkin.Controls.MaterialRaisedButton previoseMovieButton;
        private MaterialSkin.Controls.MaterialRaisedButton nextMovieButtopn;
        private MaterialSkin.Controls.MaterialLabel hallLabel;
        private MaterialSkin.Controls.MaterialLabel movieLabel;
    }
}