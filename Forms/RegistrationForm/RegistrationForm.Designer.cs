namespace DesktopApp.Forms.RegistrationForm
{
    partial class RegistrationForm
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
            this.loginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.regitstrationButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.passwordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordCharLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordSizeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.wrongPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.wrongEmailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Depth = 0;
            this.loginButton.Location = new System.Drawing.Point(269, 368);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = false;
            this.loginButton.Size = new System.Drawing.Size(90, 36);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Logowanie";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(31, 376);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(200, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Masz już konto? Zaloguj się:";
            // 
            // regitstrationButton
            // 
            this.regitstrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regitstrationButton.Depth = 0;
            this.regitstrationButton.Location = new System.Drawing.Point(138, 303);
            this.regitstrationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.regitstrationButton.Name = "regitstrationButton";
            this.regitstrationButton.Primary = true;
            this.regitstrationButton.Size = new System.Drawing.Size(134, 43);
            this.regitstrationButton.TabIndex = 7;
            this.regitstrationButton.Text = "Rejestracja";
            this.regitstrationButton.UseVisualStyleBackColor = true;
            this.regitstrationButton.Click += new System.EventHandler(this.regitstrationButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Depth = 0;
            this.passwordField.Hint = "Hasło";
            this.passwordField.Location = new System.Drawing.Point(78, 215);
            this.passwordField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '\0';
            this.passwordField.SelectedText = "";
            this.passwordField.SelectionLength = 0;
            this.passwordField.SelectionStart = 0;
            this.passwordField.Size = new System.Drawing.Size(247, 23);
            this.passwordField.TabIndex = 6;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // emailField
            // 
            this.emailField.Depth = 0;
            this.emailField.Hint = "Email";
            this.emailField.Location = new System.Drawing.Point(78, 145);
            this.emailField.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailField.Name = "emailField";
            this.emailField.PasswordChar = '\0';
            this.emailField.SelectedText = "";
            this.emailField.SelectionLength = 0;
            this.emailField.SelectionStart = 0;
            this.emailField.Size = new System.Drawing.Size(247, 23);
            this.emailField.TabIndex = 5;
            this.emailField.UseSystemPasswordChar = false;
            // 
            // passwordCharLabel
            // 
            this.passwordCharLabel.AutoSize = true;
            this.passwordCharLabel.Depth = 0;
            this.passwordCharLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passwordCharLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordCharLabel.Location = new System.Drawing.Point(31, 262);
            this.passwordCharLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordCharLabel.Name = "passwordCharLabel";
            this.passwordCharLabel.Size = new System.Drawing.Size(342, 19);
            this.passwordCharLabel.TabIndex = 13;
            this.passwordCharLabel.Text = "Hasło musi zawierać dużą, małą literę oraz liczbę!";
            this.passwordCharLabel.Visible = false;
            // 
            // passwordSizeLabel
            // 
            this.passwordSizeLabel.AutoSize = true;
            this.passwordSizeLabel.Depth = 0;
            this.passwordSizeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passwordSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordSizeLabel.Location = new System.Drawing.Point(77, 243);
            this.passwordSizeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordSizeLabel.Name = "passwordSizeLabel";
            this.passwordSizeLabel.Size = new System.Drawing.Size(256, 19);
            this.passwordSizeLabel.TabIndex = 12;
            this.passwordSizeLabel.Text = "Hasło musi mieć od 6 do 20 znaków!";
            this.passwordSizeLabel.Visible = false;
            // 
            // wrongPasswordLabel
            // 
            this.wrongPasswordLabel.AutoSize = true;
            this.wrongPasswordLabel.Depth = 0;
            this.wrongPasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.wrongPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wrongPasswordLabel.Location = new System.Drawing.Point(74, 193);
            this.wrongPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.wrongPasswordLabel.Name = "wrongPasswordLabel";
            this.wrongPasswordLabel.Size = new System.Drawing.Size(139, 19);
            this.wrongPasswordLabel.TabIndex = 11;
            this.wrongPasswordLabel.Text = "Niewłaściwe hasło!";
            this.wrongPasswordLabel.Visible = false;
            // 
            // wrongEmailLabel
            // 
            this.wrongEmailLabel.AutoSize = true;
            this.wrongEmailLabel.Depth = 0;
            this.wrongEmailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.wrongEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wrongEmailLabel.Location = new System.Drawing.Point(74, 123);
            this.wrongEmailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.wrongEmailLabel.Name = "wrongEmailLabel";
            this.wrongEmailLabel.Size = new System.Drawing.Size(183, 19);
            this.wrongEmailLabel.TabIndex = 10;
            this.wrongEmailLabel.Text = "Niewłaściwy adres e-mail!";
            this.wrongEmailLabel.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.passwordCharLabel);
            this.Controls.Add(this.passwordSizeLabel);
            this.Controls.Add(this.wrongPasswordLabel);
            this.Controls.Add(this.wrongEmailLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.regitstrationButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailField);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja do systemu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton loginButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton regitstrationButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordField;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailField;
        private MaterialSkin.Controls.MaterialLabel passwordCharLabel;
        private MaterialSkin.Controls.MaterialLabel passwordSizeLabel;
        private MaterialSkin.Controls.MaterialLabel wrongPasswordLabel;
        private MaterialSkin.Controls.MaterialLabel wrongEmailLabel;
    }
}