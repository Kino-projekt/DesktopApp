﻿namespace DesktopApp.Forms.MenuForms.User
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
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.oldPasswordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.newPasswordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saveNewPasswordButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.mainPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.statisticTab.Location = new System.Drawing.Point(4, 22);
            this.statisticTab.Name = "statisticTab";
            this.statisticTab.Padding = new System.Windows.Forms.Padding(3);
            this.statisticTab.Size = new System.Drawing.Size(792, 514);
            this.statisticTab.TabIndex = 1;
            this.statisticTab.Text = "Statystyki użytkownika";
            this.statisticTab.UseVisualStyleBackColor = true;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.panel1);
            this.settingsTab.Controls.Add(this.passwordPanel);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(792, 514);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Ustawienia konta";
            this.settingsTab.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialSingleLineTextField2);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Location = new System.Drawing.Point(15, 153);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 120);
            this.panel1.TabIndex = 2;
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
            this.materialLabel6.Location = new System.Drawing.Point(327, 21);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(86, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Usuń konto";
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
            this.settingsTab.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}