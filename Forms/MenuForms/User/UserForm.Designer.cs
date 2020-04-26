namespace DesktopApp.Forms.MenuForms.User
{
    partial class UserForm
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.tabMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.reservationTab = new System.Windows.Forms.TabPage();
            this.statisticTab = new System.Windows.Forms.TabPage();
            this.userStatsPanel = new System.Windows.Forms.Panel();
            this.emailField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tokenField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.accoutnDeletePanel = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.saveNewPasswordButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.newPasswordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.oldPasswordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.statisticTab.SuspendLayout();
            this.userStatsPanel.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.accoutnDeletePanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.contentPanel);
            this.mainPanel.Controls.Add(this.menuPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 600);
            this.mainPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.tabMenu);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 540);
            this.contentPanel.TabIndex = 1;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.reservationTab);
            this.tabMenu.Controls.Add(this.statisticTab);
            this.tabMenu.Controls.Add(this.settingsTab);
            this.tabMenu.Depth = 0;
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(800, 540);
            this.tabMenu.TabIndex = 0;
            // 
            // reservationTab
            // 
            this.reservationTab.Location = new System.Drawing.Point(4, 22);
            this.reservationTab.Name = "reservationTab";
            this.reservationTab.Padding = new System.Windows.Forms.Padding(3);
            this.reservationTab.Size = new System.Drawing.Size(792, 514);
            this.reservationTab.TabIndex = 0;
            this.reservationTab.Text = "Moje rezerwacje";
            this.reservationTab.UseVisualStyleBackColor = true;
            // 
            // statisticTab
            // 
            this.statisticTab.Controls.Add(this.userStatsPanel);
            this.statisticTab.Location = new System.Drawing.Point(4, 22);
            this.statisticTab.Name = "statisticTab";
            this.statisticTab.Padding = new System.Windows.Forms.Padding(3);
            this.statisticTab.Size = new System.Drawing.Size(792, 514);
            this.statisticTab.TabIndex = 1;
            this.statisticTab.Text = "Statystyki użytkownika";
            this.statisticTab.UseVisualStyleBackColor = true;
            // 
            // userStatsPanel
            // 
            this.userStatsPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userStatsPanel.Controls.Add(this.emailField);
            this.userStatsPanel.Controls.Add(this.tokenField);
            this.userStatsPanel.Controls.Add(this.materialLabel4);
            this.userStatsPanel.Location = new System.Drawing.Point(35, 113);
            this.userStatsPanel.Name = "userStatsPanel";
            this.userStatsPanel.Size = new System.Drawing.Size(668, 211);
            this.userStatsPanel.TabIndex = 1;
            // 
            // emailField
            // 
            this.emailField.Depth = 0;
            this.emailField.Hint = "";
            this.emailField.Location = new System.Drawing.Point(18, 76);
            this.emailField.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailField.Name = "emailField";
            this.emailField.PasswordChar = '\0';
            this.emailField.SelectedText = "";
            this.emailField.SelectionLength = 0;
            this.emailField.SelectionStart = 0;
            this.emailField.Size = new System.Drawing.Size(633, 23);
            this.emailField.TabIndex = 2;
            this.emailField.Text = "email";
            this.emailField.UseSystemPasswordChar = false;
            // 
            // tokenField
            // 
            this.tokenField.Depth = 0;
            this.tokenField.Hint = "";
            this.tokenField.Location = new System.Drawing.Point(18, 138);
            this.tokenField.MouseState = MaterialSkin.MouseState.HOVER;
            this.tokenField.Name = "tokenField";
            this.tokenField.PasswordChar = '\0';
            this.tokenField.SelectedText = "";
            this.tokenField.SelectionLength = 0;
            this.tokenField.SelectionStart = 0;
            this.tokenField.Size = new System.Drawing.Size(633, 23);
            this.tokenField.TabIndex = 1;
            this.tokenField.Text = "token";
            this.tokenField.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(200, 22);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(275, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Chwilowe info o użytkowniku do testów";
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.accoutnDeletePanel);
            this.settingsTab.Controls.Add(this.passwordPanel);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(792, 514);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Ustawienia konta";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // accoutnDeletePanel
            // 
            this.accoutnDeletePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.accoutnDeletePanel.Controls.Add(this.materialFlatButton1);
            this.accoutnDeletePanel.Controls.Add(this.materialLabel5);
            this.accoutnDeletePanel.Controls.Add(this.materialSingleLineTextField2);
            this.accoutnDeletePanel.Controls.Add(this.materialLabel6);
            this.accoutnDeletePanel.Location = new System.Drawing.Point(15, 153);
            this.accoutnDeletePanel.Margin = new System.Windows.Forms.Padding(10);
            this.accoutnDeletePanel.Name = "accoutnDeletePanel";
            this.accoutnDeletePanel.Size = new System.Drawing.Size(762, 120);
            this.accoutnDeletePanel.TabIndex = 2;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.MintCream;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(619, 63);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(97, 36);
            this.materialFlatButton1.TabIndex = 3;
            this.materialFlatButton1.Text = "Usuń konto";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(94, 54);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(49, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Hasło";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Password";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(33, 76);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(191, 23);
            this.materialSingleLineTextField2.TabIndex = 1;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(312, 19);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(122, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Likwidacja konta";
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordPanel.Controls.Add(this.saveNewPasswordButton);
            this.passwordPanel.Controls.Add(this.materialLabel3);
            this.passwordPanel.Controls.Add(this.newPasswordField);
            this.passwordPanel.Controls.Add(this.materialLabel2);
            this.passwordPanel.Controls.Add(this.oldPasswordField);
            this.passwordPanel.Controls.Add(this.materialLabel1);
            this.passwordPanel.Location = new System.Drawing.Point(15, 13);
            this.passwordPanel.Margin = new System.Windows.Forms.Padding(10);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(762, 120);
            this.passwordPanel.TabIndex = 1;
            // 
            // saveNewPasswordButton
            // 
            this.saveNewPasswordButton.AutoSize = true;
            this.saveNewPasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveNewPasswordButton.Depth = 0;
            this.saveNewPasswordButton.Location = new System.Drawing.Point(619, 66);
            this.saveNewPasswordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveNewPasswordButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveNewPasswordButton.Name = "saveNewPasswordButton";
            this.saveNewPasswordButton.Primary = false;
            this.saveNewPasswordButton.Size = new System.Drawing.Size(113, 36);
            this.saveNewPasswordButton.TabIndex = 5;
            this.saveNewPasswordButton.Text = "Zapisz zmianę";
            this.saveNewPasswordButton.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(369, 57);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(89, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Nowe hasło";
            // 
            // newPasswordField
            // 
            this.newPasswordField.Depth = 0;
            this.newPasswordField.Hint = "Password";
            this.newPasswordField.Location = new System.Drawing.Point(331, 79);
            this.newPasswordField.MouseState = MaterialSkin.MouseState.HOVER;
            this.newPasswordField.Name = "newPasswordField";
            this.newPasswordField.PasswordChar = '\0';
            this.newPasswordField.SelectedText = "";
            this.newPasswordField.SelectionLength = 0;
            this.newPasswordField.SelectionStart = 0;
            this.newPasswordField.Size = new System.Drawing.Size(191, 23);
            this.newPasswordField.TabIndex = 3;
            this.newPasswordField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(71, 57);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(100, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Obecne hasło";
            // 
            // oldPasswordField
            // 
            this.oldPasswordField.Depth = 0;
            this.oldPasswordField.Hint = "Password";
            this.oldPasswordField.Location = new System.Drawing.Point(33, 79);
            this.oldPasswordField.MouseState = MaterialSkin.MouseState.HOVER;
            this.oldPasswordField.Name = "oldPasswordField";
            this.oldPasswordField.PasswordChar = '\0';
            this.oldPasswordField.SelectedText = "";
            this.oldPasswordField.SelectionLength = 0;
            this.oldPasswordField.SelectionStart = 0;
            this.oldPasswordField.Size = new System.Drawing.Size(191, 23);
            this.oldPasswordField.TabIndex = 1;
            this.oldPasswordField.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(312, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(99, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Zmiana hasła";
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.tabSelector);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(800, 60);
            this.menuPanel.TabIndex = 0;
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabMenu;
            this.tabSelector.Depth = 0;
            this.tabSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSelector.Location = new System.Drawing.Point(0, 0);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(800, 60);
            this.tabSelector.TabIndex = 0;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainPanel);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.mainPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.statisticTab.ResumeLayout(false);
            this.userStatsPanel.ResumeLayout(false);
            this.userStatsPanel.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.accoutnDeletePanel.ResumeLayout(false);
            this.accoutnDeletePanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialTabControl tabMenu;
        private System.Windows.Forms.TabPage reservationTab;
        private System.Windows.Forms.TabPage statisticTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Panel menuPanel;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private System.Windows.Forms.Panel passwordPanel;
        private MaterialSkin.Controls.MaterialFlatButton saveNewPasswordButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField newPasswordField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField oldPasswordField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel accoutnDeletePanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel userStatsPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailField;
        private MaterialSkin.Controls.MaterialSingleLineTextField tokenField;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}