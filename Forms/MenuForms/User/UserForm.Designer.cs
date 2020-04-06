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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.reservationTab = new System.Windows.Forms.TabPage();
            this.statisticTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mainPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.settingsTab.SuspendLayout();
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
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.tabSelector);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(800, 60);
            this.menuPanel.TabIndex = 0;
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
            this.settingsTab.Controls.Add(this.materialRaisedButton1);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(792, 514);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Ustawienia konta";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.materialRaisedButton1.Location = new System.Drawing.Point(324, 414);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(151, 63);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Usuń konto";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
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
            this.menuPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialTabControl tabMenu;
        private System.Windows.Forms.TabPage reservationTab;
        private System.Windows.Forms.TabPage statisticTab;
        private System.Windows.Forms.TabPage settingsTab;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Panel menuPanel;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
    }
}