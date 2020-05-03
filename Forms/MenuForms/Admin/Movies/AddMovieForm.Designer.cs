namespace DesktopApp.Forms.MenuForms.Admin.Movies
{
    partial class AddMovieForm
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
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.sendButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.descriptionField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.titleField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.directLabel = new MaterialSkin.Controls.MaterialLabel();
            this.directField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.materialLabel5);
            this.contentPanel.Controls.Add(this.directLabel);
            this.contentPanel.Controls.Add(this.directField);
            this.contentPanel.Controls.Add(this.materialLabel4);
            this.contentPanel.Controls.Add(this.materialLabel3);
            this.contentPanel.Controls.Add(this.sendButton);
            this.contentPanel.Controls.Add(this.materialLabel2);
            this.contentPanel.Controls.Add(this.materialLabel1);
            this.contentPanel.Controls.Add(this.descriptionField);
            this.contentPanel.Controls.Add(this.titleField);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(786, 455);
            this.contentPanel.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(105, 259);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(193, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Min 3, maks 300 characters";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(105, 90);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(185, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Min 3, maks 50 characters";
            // 
            // sendButton
            // 
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.Depth = 0;
            this.sendButton.Location = new System.Drawing.Point(317, 324);
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
            this.materialLabel2.Location = new System.Drawing.Point(82, 211);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(43, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Opis:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(82, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Tytuł:";
            // 
            // descriptionField
            // 
            this.descriptionField.Depth = 0;
            this.descriptionField.Hint = "";
            this.descriptionField.Location = new System.Drawing.Point(86, 233);
            this.descriptionField.MouseState = MaterialSkin.MouseState.HOVER;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.PasswordChar = '\0';
            this.descriptionField.SelectedText = "";
            this.descriptionField.SelectionLength = 0;
            this.descriptionField.SelectionStart = 0;
            this.descriptionField.Size = new System.Drawing.Size(596, 23);
            this.descriptionField.TabIndex = 1;
            this.descriptionField.UseSystemPasswordChar = false;
            // 
            // titleField
            // 
            this.titleField.Depth = 0;
            this.titleField.Hint = "";
            this.titleField.Location = new System.Drawing.Point(86, 64);
            this.titleField.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleField.Name = "titleField";
            this.titleField.PasswordChar = '\0';
            this.titleField.SelectedText = "";
            this.titleField.SelectionLength = 0;
            this.titleField.SelectionStart = 0;
            this.titleField.Size = new System.Drawing.Size(223, 23);
            this.titleField.TabIndex = 0;
            this.titleField.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(105, 174);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(185, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Min 3, maks 50 characters";
            // 
            // directLabel
            // 
            this.directLabel.AutoSize = true;
            this.directLabel.Depth = 0;
            this.directLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.directLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.directLabel.Location = new System.Drawing.Point(82, 126);
            this.directLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.directLabel.Name = "directLabel";
            this.directLabel.Size = new System.Drawing.Size(65, 19);
            this.directLabel.TabIndex = 8;
            this.directLabel.Text = "Reżyser:";
            // 
            // directField
            // 
            this.directField.Depth = 0;
            this.directField.Hint = "";
            this.directField.Location = new System.Drawing.Point(86, 148);
            this.directField.MouseState = MaterialSkin.MouseState.HOVER;
            this.directField.Name = "directField";
            this.directField.PasswordChar = '\0';
            this.directField.SelectedText = "";
            this.directField.SelectionLength = 0;
            this.directField.SelectionStart = 0;
            this.directField.Size = new System.Drawing.Size(223, 23);
            this.directField.TabIndex = 7;
            this.directField.UseSystemPasswordChar = false;
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 455);
            this.Controls.Add(this.contentPanel);
            this.Name = "AddMovieForm";
            this.Text = "AddMovieForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel directLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField directField;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton sendButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField descriptionField;
        private MaterialSkin.Controls.MaterialSingleLineTextField titleField;
    }
}