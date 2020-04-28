namespace DesktopApp.Forms.AccessForms.LoginForm
{
    partial class LoginForm
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
            this.emailField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.registractionButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.wrongEmailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.wrongPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.rememberMeButton = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // emailField
            // 
            this.emailField.Depth = 0;
            this.emailField.Hint = "Email";
            this.emailField.Location = new System.Drawing.Point(77, 144);
            this.emailField.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailField.Name = "emailField";
            this.emailField.PasswordChar = '\0';
            this.emailField.SelectedText = "";
            this.emailField.SelectionLength = 0;
            this.emailField.SelectionStart = 0;
            this.emailField.Size = new System.Drawing.Size(247, 23);
            this.emailField.TabIndex = 0;
            this.emailField.UseSystemPasswordChar = false;
            // 
            // passwordField
            // 
            this.passwordField.Depth = 0;
            this.passwordField.Hint = "Hasło";
            this.passwordField.Location = new System.Drawing.Point(77, 214);
            this.passwordField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '\0';
            this.passwordField.SelectedText = "";
            this.passwordField.SelectionLength = 0;
            this.passwordField.SelectionStart = 0;
            this.passwordField.Size = new System.Drawing.Size(247, 23);
            this.passwordField.TabIndex = 1;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Depth = 0;
            this.loginButton.Location = new System.Drawing.Point(138, 299);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = true;
            this.loginButton.Size = new System.Drawing.Size(134, 43);
            this.loginButton.TabIndex = 2;
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
            this.materialLabel1.Location = new System.Drawing.Point(31, 375);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(225, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Nie masz konta? Zarejestruj się:";
            // 
            // registractionButton
            // 
            this.registractionButton.AutoSize = true;
            this.registractionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registractionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registractionButton.Depth = 0;
            this.registractionButton.Location = new System.Drawing.Point(268, 367);
            this.registractionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registractionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registractionButton.Name = "registractionButton";
            this.registractionButton.Primary = false;
            this.registractionButton.Size = new System.Drawing.Size(104, 36);
            this.registractionButton.TabIndex = 4;
            this.registractionButton.Text = "Rejestracja";
            this.registractionButton.UseVisualStyleBackColor = true;
            this.registractionButton.Click += new System.EventHandler(this.registractionButton_Click);
            // 
            // wrongEmailLabel
            // 
            this.wrongEmailLabel.AutoSize = true;
            this.wrongEmailLabel.Depth = 0;
            this.wrongEmailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.wrongEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wrongEmailLabel.Location = new System.Drawing.Point(73, 122);
            this.wrongEmailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.wrongEmailLabel.Name = "wrongEmailLabel";
            this.wrongEmailLabel.Size = new System.Drawing.Size(183, 19);
            this.wrongEmailLabel.TabIndex = 5;
            this.wrongEmailLabel.Text = "Niewłaściwy adres e-mail!";
            this.wrongEmailLabel.Visible = false;
            // 
            // wrongPasswordLabel
            // 
            this.wrongPasswordLabel.AutoSize = true;
            this.wrongPasswordLabel.Depth = 0;
            this.wrongPasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.wrongPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wrongPasswordLabel.Location = new System.Drawing.Point(73, 192);
            this.wrongPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.wrongPasswordLabel.Name = "wrongPasswordLabel";
            this.wrongPasswordLabel.Size = new System.Drawing.Size(139, 19);
            this.wrongPasswordLabel.TabIndex = 6;
            this.wrongPasswordLabel.Text = "Niewłaściwe hasło!";
            this.wrongPasswordLabel.Visible = false;
            // 
            // rememberMeButton
            // 
            this.rememberMeButton.AutoSize = true;
            this.rememberMeButton.Checked = true;
            this.rememberMeButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rememberMeButton.Depth = 0;
            this.rememberMeButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.rememberMeButton.Location = new System.Drawing.Point(138, 254);
            this.rememberMeButton.Margin = new System.Windows.Forms.Padding(0);
            this.rememberMeButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rememberMeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.rememberMeButton.Name = "rememberMeButton";
            this.rememberMeButton.Ripple = true;
            this.rememberMeButton.Size = new System.Drawing.Size(133, 30);
            this.rememberMeButton.TabIndex = 7;
            this.rememberMeButton.Text = "Zapamiętaj mnie";
            this.rememberMeButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.rememberMeButton);
            this.Controls.Add(this.wrongPasswordLabel);
            this.Controls.Add(this.wrongEmailLabel);
            this.Controls.Add(this.registractionButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailField);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie do systemu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField emailField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordField;
        private MaterialSkin.Controls.MaterialRaisedButton loginButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton registractionButton;
        private MaterialSkin.Controls.MaterialLabel wrongEmailLabel;
        private MaterialSkin.Controls.MaterialLabel wrongPasswordLabel;
        private MaterialSkin.Controls.MaterialCheckBox rememberMeButton;
    }
}