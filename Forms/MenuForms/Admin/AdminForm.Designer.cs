namespace DesktopApp.Forms.MenuForms.Admin
{
    partial class AdminForm
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
            this.mainMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.seanceTab = new System.Windows.Forms.TabPage();
            this.newsTab = new System.Windows.Forms.TabPage();
            this.seancesTab = new System.Windows.Forms.TabPage();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.moviesTab = new System.Windows.Forms.TabPage();
            this.roomsTab = new System.Windows.Forms.TabPage();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.mainPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.contentPanel);
            this.mainPanel.Controls.Add(this.menuPanel);
            this.mainPanel.Controls.Add(this.materialLabel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 600);
            this.mainPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.mainMenu);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 540);
            this.contentPanel.TabIndex = 2;
            // 
            // mainMenu
            // 
            this.mainMenu.Controls.Add(this.seanceTab);
            this.mainMenu.Controls.Add(this.newsTab);
            this.mainMenu.Controls.Add(this.seancesTab);
            this.mainMenu.Controls.Add(this.moviesTab);
            this.mainMenu.Controls.Add(this.roomsTab);
            this.mainMenu.Controls.Add(this.usersTab);
            this.mainMenu.Depth = 0;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.SelectedIndex = 0;
            this.mainMenu.Size = new System.Drawing.Size(800, 540);
            this.mainMenu.TabIndex = 0;
            // 
            // seanceTab
            // 
            this.seanceTab.Location = new System.Drawing.Point(4, 22);
            this.seanceTab.Name = "seanceTab";
            this.seanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.seanceTab.Size = new System.Drawing.Size(792, 514);
            this.seanceTab.TabIndex = 0;
            this.seanceTab.Text = "Sprawdzarka biletów";
            this.seanceTab.UseVisualStyleBackColor = true;
            // 
            // newsTab
            // 
            this.newsTab.Location = new System.Drawing.Point(4, 22);
            this.newsTab.Name = "newsTab";
            this.newsTab.Padding = new System.Windows.Forms.Padding(3);
            this.newsTab.Size = new System.Drawing.Size(792, 514);
            this.newsTab.TabIndex = 1;
            this.newsTab.Text = "Newsy";
            this.newsTab.UseVisualStyleBackColor = true;
            // 
            // seancesTab
            // 
            this.seancesTab.Location = new System.Drawing.Point(4, 22);
            this.seancesTab.Name = "seancesTab";
            this.seancesTab.Padding = new System.Windows.Forms.Padding(3);
            this.seancesTab.Size = new System.Drawing.Size(792, 514);
            this.seancesTab.TabIndex = 2;
            this.seancesTab.Text = "Seanse";
            this.seancesTab.UseVisualStyleBackColor = true;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.materialTabSelector1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(800, 60);
            this.menuPanel.TabIndex = 1;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.mainMenu;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 60);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(332, 226);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(99, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Panel admina";
            // 
            // moviesTab
            // 
            this.moviesTab.Location = new System.Drawing.Point(4, 22);
            this.moviesTab.Name = "moviesTab";
            this.moviesTab.Padding = new System.Windows.Forms.Padding(3);
            this.moviesTab.Size = new System.Drawing.Size(792, 514);
            this.moviesTab.TabIndex = 3;
            this.moviesTab.Text = "Filmy";
            this.moviesTab.UseVisualStyleBackColor = true;
            // 
            // roomsTab
            // 
            this.roomsTab.Location = new System.Drawing.Point(4, 22);
            this.roomsTab.Name = "roomsTab";
            this.roomsTab.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTab.Size = new System.Drawing.Size(792, 514);
            this.roomsTab.TabIndex = 4;
            this.roomsTab.Text = "Sale";
            this.roomsTab.UseVisualStyleBackColor = true;
            // 
            // usersTab
            // 
            this.usersTab.Location = new System.Drawing.Point(4, 22);
            this.usersTab.Name = "usersTab";
            this.usersTab.Padding = new System.Windows.Forms.Padding(3);
            this.usersTab.Size = new System.Drawing.Size(792, 514);
            this.usersTab.TabIndex = 5;
            this.usersTab.Text = "Użytkownicy";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainPanel);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel menuPanel;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl mainMenu;
        private System.Windows.Forms.TabPage newsTab;
        private System.Windows.Forms.TabPage seancesTab;
        private System.Windows.Forms.TabPage seanceTab;
        private System.Windows.Forms.TabPage moviesTab;
        private System.Windows.Forms.TabPage roomsTab;
        private System.Windows.Forms.TabPage usersTab;
    }
}