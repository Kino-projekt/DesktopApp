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
            this.exitPanel = new System.Windows.Forms.Panel();
            this.exitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.mainTabControler = new MaterialSkin.Controls.MaterialTabControl();
            this.startTab = new System.Windows.Forms.TabPage();
            this.tabRepertoire = new System.Windows.Forms.TabPage();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.mainTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.priceListTab = new System.Windows.Forms.TabPage();
            this.cinemaHallsTab = new System.Windows.Forms.TabPage();
            this.topPanel.SuspendLayout();
            this.exitPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.mainTabControler.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.menuPanel);
            this.topPanel.Controls.Add(this.exitPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1173, 76);
            this.topPanel.TabIndex = 1;
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
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.mainTabSelector);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1011, 76);
            this.menuPanel.TabIndex = 1;
            // 
            // mainTabSelector
            // 
            this.mainTabSelector.BaseTabControl = this.mainTabControler;
            this.mainTabSelector.Depth = 0;
            this.mainTabSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabSelector.Location = new System.Drawing.Point(0, 0);
            this.mainTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabSelector.Name = "mainTabSelector";
            this.mainTabSelector.Size = new System.Drawing.Size(1011, 76);
            this.mainTabSelector.TabIndex = 0;
            this.mainTabSelector.Text = "Menu";
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
            this.exitPanel.ResumeLayout(false);
            this.exitPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.mainTabControler.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
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
    }
}