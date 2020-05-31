namespace DesktopApp.Forms.MenuForms.Movies.Comments
{
    partial class CommentsForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.commentTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.commentAddButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentsList = new System.Windows.Forms.ListView();
            this.mainPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.commentsList);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.titlePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(420, 520);
            this.mainPanel.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.Control;
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Controls.Add(this.materialLabel1);
            this.titlePanel.Location = new System.Drawing.Point(12, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(396, 63);
            this.titlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Depth = 0;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(156, 23);
            this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 19);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "title";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(152, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Komentarze do filmu:";
            // 
            // commentTextField
            // 
            this.commentTextField.Depth = 0;
            this.commentTextField.Hint = "Twój komentarz";
            this.commentTextField.Location = new System.Drawing.Point(13, 15);
            this.commentTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.commentTextField.Name = "commentTextField";
            this.commentTextField.PasswordChar = '\0';
            this.commentTextField.SelectedText = "";
            this.commentTextField.SelectionLength = 0;
            this.commentTextField.SelectionStart = 0;
            this.commentTextField.Size = new System.Drawing.Size(370, 23);
            this.commentTextField.TabIndex = 3;
            this.commentTextField.UseSystemPasswordChar = false;
            // 
            // commentAddButton
            // 
            this.commentAddButton.AutoSize = true;
            this.commentAddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.commentAddButton.Depth = 0;
            this.commentAddButton.Location = new System.Drawing.Point(241, 45);
            this.commentAddButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.commentAddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.commentAddButton.Name = "commentAddButton";
            this.commentAddButton.Primary = false;
            this.commentAddButton.Size = new System.Drawing.Size(142, 36);
            this.commentAddButton.TabIndex = 4;
            this.commentAddButton.Text = "Dodaj komentarz";
            this.commentAddButton.UseVisualStyleBackColor = true;
            this.commentAddButton.Click += new System.EventHandler(this.commentAddButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commentAddButton);
            this.panel1.Controls.Add(this.commentTextField);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 87);
            this.panel1.TabIndex = 5;
            // 
            // commentsList
            // 
            this.commentsList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsList.HideSelection = false;
            this.commentsList.Location = new System.Drawing.Point(12, 174);
            this.commentsList.Name = "commentsList";
            this.commentsList.Size = new System.Drawing.Size(396, 334);
            this.commentsList.TabIndex = 7;
            this.commentsList.TabStop = false;
            this.commentsList.UseCompatibleStateImageBehavior = false;
            this.commentsList.View = System.Windows.Forms.View.List;
            // 
            // CommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 520);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CommentsForm";
            this.Text = "CommentsForm";
            this.mainPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel titlePanel;
        private MaterialSkin.Controls.MaterialLabel titleLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton commentAddButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField commentTextField;
        private System.Windows.Forms.ListView commentsList;
    }
}