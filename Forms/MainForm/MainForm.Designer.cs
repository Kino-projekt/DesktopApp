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
            this.mainTabControler = new MaterialSkin.Controls.MaterialTabControl();
            this.startTab = new System.Windows.Forms.TabPage();
            this.tabRepertoire = new System.Windows.Forms.TabPage();
            this.priceListTab = new System.Windows.Forms.TabPage();
            this.cinemaHallsTab = new System.Windows.Forms.TabPage();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logolabel = new MaterialSkin.Controls.MaterialLabel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.exitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.topPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.mainTabControler.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.exitPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.menuPanel);
            this.topPanel.Controls.Add(this.logoPanel);
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
            this.menuPanel.Location = new System.Drawing.Point(160, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(691, 76);
            this.menuPanel.TabIndex = 1;
            // 
            // mainTabSelector
            // 
            this.mainTabSelector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainTabSelector.BaseTabControl = this.mainTabControler;
            this.mainTabSelector.Depth = 0;
            this.mainTabSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabSelector.Location = new System.Drawing.Point(0, 0);
            this.mainTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabSelector.Name = "mainTabSelector";
            this.mainTabSelector.Size = new System.Drawing.Size(691, 76);
            this.mainTabSelector.TabIndex = 0;
            this.mainTabSelector.Text = "Menu";
            // 
            // mainTabControler
            // 
            this.mainTabControler.Controls.Add(this.startTab);
            this.mainTabControler.Controls.Add(this.tabRepertoire);
            this.mainTabControler.Controls.Add(this.priceListTab);
            this.mainTabControler.Controls.Add(this.cinemaHallsTab);
            this.mainTabControler.Depth = 0;
            this.mainTabControler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControler.Location = new System.Drawing.Point(0, 0);
            this.mainTabControler.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControler.Name = "mainTabControler";
            this.mainTabControler.SelectedIndex = 0;
            this.mainTabControler.Size = new System.Drawing.Size(1173, 595);
            this.mainTabControler.TabIndex = 0;
            // 
            // startTab
            // 
            this.startTab.Location = new System.Drawing.Point(4, 22);
            this.startTab.Name = "startTab";
            this.startTab.Padding = new System.Windows.Forms.Padding(3);
            this.startTab.Size = new System.Drawing.Size(1165, 569);
            this.startTab.TabIndex = 0;
            this.startTab.Text = "Start";
            this.startTab.UseVisualStyleBackColor = true;
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
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.logolabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(160, 76);
            this.logoPanel.TabIndex = 2;
            // 
            // logolabel
            // 
            this.logolabel.AutoSize = true;
            this.logolabel.Depth = 0;
            this.logolabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.logolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logolabel.Location = new System.Drawing.Point(48, 28);
            this.logolabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.logolabel.Name = "logolabel";
            this.logolabel.Size = new System.Drawing.Size(43, 19);
            this.logolabel.TabIndex = 0;
            this.logolabel.Text = "Logo";
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
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Depth = 0;
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.Location = new System.Drawing.Point(0, 0);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = false;
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
            this.exitButton.AutoSize = true;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Depth = 0;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.Location = new System.Drawing.Point(0, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.Primary = false;
            this.exitButton.Size = new System.Drawing.Size(162, 76);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Wyjście";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.mainTabControler);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 76);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1173, 595);
            this.contentPanel.TabIndex = 2;
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Depth = 0;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutButton.Location = new System.Drawing.Point(0, 0);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logoutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Primary = false;
            this.logoutButton.Size = new System.Drawing.Size(160, 76);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
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
            this.mainTabControler.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.exitPanel.ResumeLayout(false);
            this.exitPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel exitPanel;
        private MaterialSkin.Controls.MaterialFlatButton exitButton;
        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialTabControl mainTabControler;
        private System.Windows.Forms.TabPage startTab;
        private System.Windows.Forms.TabPage tabRepertoire;
        private System.Windows.Forms.Panel menuPanel;
        private MaterialSkin.Controls.MaterialTabSelector mainTabSelector;
        private System.Windows.Forms.TabPage priceListTab;
        private System.Windows.Forms.TabPage cinemaHallsTab;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel loginPanel;
        private MaterialSkin.Controls.MaterialFlatButton loginButton;
        private MaterialSkin.Controls.MaterialLabel logolabel;
        private MaterialSkin.Controls.MaterialFlatButton logoutButton;
    }
}