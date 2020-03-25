namespace DesktopApp.MainForm
{
    partial class MainForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.mainTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.startTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tokenLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tabRepertoire = new System.Windows.Forms.TabPage();
            this.priceListTab = new System.Windows.Forms.TabPage();
            this.cinemaHallsTab = new System.Windows.Forms.TabPage();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.exitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.topPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.startTab.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.exitPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.menuPanel);
            this.topPanel.Controls.Add(this.loginPanel);
            this.topPanel.Controls.Add(this.exitPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1173, 76);
            this.topPanel.TabIndex = 1;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.mainTabSelector);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(851, 76);
            this.menuPanel.TabIndex = 1;
            // 
            // mainTabSelector
            // 
            this.mainTabSelector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainTabSelector.BaseTabControl = this.mainTabs;
            this.mainTabSelector.Depth = 0;
            this.mainTabSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabSelector.Location = new System.Drawing.Point(0, 0);
            this.mainTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabSelector.Name = "mainTabSelector";
            this.mainTabSelector.Size = new System.Drawing.Size(851, 76);
            this.mainTabSelector.TabIndex = 0;
            this.mainTabSelector.Text = "Menu";
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.startTab);
            this.mainTabs.Controls.Add(this.tabRepertoire);
            this.mainTabs.Controls.Add(this.priceListTab);
            this.mainTabs.Controls.Add(this.cinemaHallsTab);
            this.mainTabs.Controls.Add(this.settingsTab);
            this.mainTabs.Depth = 0;
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1173, 595);
            this.mainTabs.TabIndex = 0;
            // 
            // startTab
            // 
            this.startTab.Controls.Add(this.textBox1);
            this.startTab.Controls.Add(this.tokenLabel);
            this.startTab.Location = new System.Drawing.Point(4, 22);
            this.startTab.Name = "startTab";
            this.startTab.Padding = new System.Windows.Forms.Padding(3);
            this.startTab.Size = new System.Drawing.Size(1165, 569);
            this.startTab.TabIndex = 0;
            this.startTab.Text = "Start";
            this.startTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Token";
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Depth = 0;
            this.tokenLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tokenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tokenLabel.Location = new System.Drawing.Point(345, 183);
            this.tokenLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(51, 19);
            this.tokenLabel.TabIndex = 0;
            this.tokenLabel.Text = "Token";
            // 
            // tabRepertoire
            // 
            this.tabRepertoire.Location = new System.Drawing.Point(4, 22);
            this.tabRepertoire.Name = "tabRepertoire";
            this.tabRepertoire.Padding = new System.Windows.Forms.Padding(3);
            this.tabRepertoire.Size = new System.Drawing.Size(1165, 569);
            this.tabRepertoire.TabIndex = 1;
            this.tabRepertoire.Text = "Repertuar";
            this.tabRepertoire.UseVisualStyleBackColor = true;
            // 
            // priceListTab
            // 
            this.priceListTab.Location = new System.Drawing.Point(4, 22);
            this.priceListTab.Name = "priceListTab";
            this.priceListTab.Padding = new System.Windows.Forms.Padding(3);
            this.priceListTab.Size = new System.Drawing.Size(1165, 569);
            this.priceListTab.TabIndex = 2;
            this.priceListTab.Text = "Cennik";
            this.priceListTab.UseVisualStyleBackColor = true;
            // 
            // cinemaHallsTab
            // 
            this.cinemaHallsTab.Location = new System.Drawing.Point(4, 22);
            this.cinemaHallsTab.Name = "cinemaHallsTab";
            this.cinemaHallsTab.Padding = new System.Windows.Forms.Padding(3);
            this.cinemaHallsTab.Size = new System.Drawing.Size(1165, 569);
            this.cinemaHallsTab.TabIndex = 3;
            this.cinemaHallsTab.Text = "Sale kinowe";
            this.cinemaHallsTab.UseVisualStyleBackColor = true;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.logoutButton);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginPanel.Location = new System.Drawing.Point(851, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(160, 76);
            this.loginPanel.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Depth = 0;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutButton.Location = new System.Drawing.Point(0, 0);
            this.logoutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Primary = true;
            this.logoutButton.Size = new System.Drawing.Size(160, 76);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Depth = 0;
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.Location = new System.Drawing.Point(0, 0);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = true;
            this.loginButton.Size = new System.Drawing.Size(160, 76);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Logowanie";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitPanel
            // 
            this.exitPanel.Controls.Add(this.exitButton);
            this.exitPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitPanel.Location = new System.Drawing.Point(1011, 0);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(162, 76);
            this.exitPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Depth = 0;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(0, 0);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.Primary = true;
            this.exitButton.Size = new System.Drawing.Size(162, 76);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Wyjście";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.mainTabs);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 76);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1173, 595);
            this.contentPanel.TabIndex = 2;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.materialRaisedButton2);
            this.settingsTab.Controls.Add(this.materialRaisedButton1);
            this.settingsTab.Controls.Add(this.materialLabel1);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(1165, 569);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "Ustawienia";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(159, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(102, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Styl graficzny:";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(299, 63);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Ciemny";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(449, 63);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton2.TabIndex = 4;
            this.materialRaisedButton2.Text = "Jasny";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 671);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.mainTabs.ResumeLayout(false);
            this.startTab.ResumeLayout(false);
            this.startTab.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.exitPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialTabControl mainTabs;
        private System.Windows.Forms.TabPage startTab;
        private System.Windows.Forms.TabPage tabRepertoire;
        private System.Windows.Forms.Panel menuPanel;
        private MaterialSkin.Controls.MaterialTabSelector mainTabSelector;
        private System.Windows.Forms.TabPage priceListTab;
        private System.Windows.Forms.TabPage cinemaHallsTab;
        private System.Windows.Forms.Panel loginPanel;
        private MaterialSkin.Controls.MaterialLabel tokenLabel;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialRaisedButton exitButton;
        private MaterialSkin.Controls.MaterialRaisedButton logoutButton;
        private MaterialSkin.Controls.MaterialRaisedButton loginButton;
        private System.Windows.Forms.TabPage settingsTab;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}