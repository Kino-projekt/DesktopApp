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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.loginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.exitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.usertPanel = new System.Windows.Forms.Panel();
            this.newsButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.seancebutton = new MaterialSkin.Controls.MaterialFlatButton();
            this.priceButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.settingsButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuPanel.Controls.Add(this.settingsButton);
            this.menuPanel.Controls.Add(this.priceButton);
            this.menuPanel.Controls.Add(this.seancebutton);
            this.menuPanel.Controls.Add(this.newsButton);
            this.menuPanel.Controls.Add(this.usertPanel);
            this.menuPanel.Controls.Add(this.logoutButton);
            this.menuPanel.Controls.Add(this.loginButton);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 600);
            this.menuPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Depth = 0;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.Location = new System.Drawing.Point(0, 492);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logoutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Primary = false;
            this.logoutButton.Size = new System.Drawing.Size(200, 36);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Depth = 0;
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginButton.Location = new System.Drawing.Point(0, 528);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = false;
            this.loginButton.Size = new System.Drawing.Size(200, 36);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Depth = 0;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.Location = new System.Drawing.Point(0, 564);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.Primary = false;
            this.exitButton.Size = new System.Drawing.Size(200, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Wyjście";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 600);
            this.contentPanel.TabIndex = 1;
            // 
            // usertPanel
            // 
            this.usertPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usertPanel.Location = new System.Drawing.Point(0, 0);
            this.usertPanel.Name = "usertPanel";
            this.usertPanel.Size = new System.Drawing.Size(200, 120);
            this.usertPanel.TabIndex = 3;
            // 
            // newsButton
            // 
            this.newsButton.AutoSize = true;
            this.newsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsButton.Depth = 0;
            this.newsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newsButton.Location = new System.Drawing.Point(0, 120);
            this.newsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.newsButton.Name = "newsButton";
            this.newsButton.Primary = false;
            this.newsButton.Size = new System.Drawing.Size(200, 36);
            this.newsButton.TabIndex = 4;
            this.newsButton.Text = "Nowości";
            this.newsButton.UseVisualStyleBackColor = true;
            // 
            // seancebutton
            // 
            this.seancebutton.AutoSize = true;
            this.seancebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seancebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seancebutton.Depth = 0;
            this.seancebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.seancebutton.Location = new System.Drawing.Point(0, 156);
            this.seancebutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.seancebutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.seancebutton.Name = "seancebutton";
            this.seancebutton.Primary = false;
            this.seancebutton.Size = new System.Drawing.Size(200, 36);
            this.seancebutton.TabIndex = 5;
            this.seancebutton.Text = "Seanse";
            this.seancebutton.UseVisualStyleBackColor = true;
            // 
            // priceButton
            // 
            this.priceButton.AutoSize = true;
            this.priceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.priceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceButton.Depth = 0;
            this.priceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.priceButton.Location = new System.Drawing.Point(0, 192);
            this.priceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.priceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.priceButton.Name = "priceButton";
            this.priceButton.Primary = false;
            this.priceButton.Size = new System.Drawing.Size(200, 36);
            this.priceButton.TabIndex = 6;
            this.priceButton.Text = "Cennik";
            this.priceButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = true;
            this.settingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Depth = 0;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.Location = new System.Drawing.Point(0, 228);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.settingsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Primary = false;
            this.settingsButton.Size = new System.Drawing.Size(200, 36);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Ustawienia";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private MaterialSkin.Controls.MaterialFlatButton exitButton;
        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialFlatButton logoutButton;
        private MaterialSkin.Controls.MaterialFlatButton loginButton;
        private System.Windows.Forms.Panel usertPanel;
        private MaterialSkin.Controls.MaterialFlatButton priceButton;
        private MaterialSkin.Controls.MaterialFlatButton seancebutton;
        private MaterialSkin.Controls.MaterialFlatButton newsButton;
        private MaterialSkin.Controls.MaterialFlatButton settingsButton;
    }
}