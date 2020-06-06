using System.ComponentModel;

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
            this.components = new System.ComponentModel.Container();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.adminButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.userButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.priceButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.moviesButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.seancebutton = new MaterialSkin.Controls.MaterialFlatButton();
            this.newsButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.userEmailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.logoutButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.loginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.exitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuPanel.Controls.Add(this.settingsButton);
            this.menuPanel.Controls.Add(this.adminButton);
            this.menuPanel.Controls.Add(this.userButton);
            this.menuPanel.Controls.Add(this.priceButton);
            this.menuPanel.Controls.Add(this.moviesButton);
            this.menuPanel.Controls.Add(this.seancebutton);
            this.menuPanel.Controls.Add(this.newsButton);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Controls.Add(this.logoutButton);
            this.menuPanel.Controls.Add(this.loginButton);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 601);
            this.menuPanel.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = true;
            this.settingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Depth = 0;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.Location = new System.Drawing.Point(0, 336);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.settingsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Primary = false;
            this.settingsButton.Size = new System.Drawing.Size(200, 36);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Ustawienia";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.AutoSize = true;
            this.adminButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.Depth = 0;
            this.adminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminButton.Location = new System.Drawing.Point(0, 300);
            this.adminButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.adminButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.adminButton.Name = "adminButton";
            this.adminButton.Primary = false;
            this.adminButton.Size = new System.Drawing.Size(200, 36);
            this.adminButton.TabIndex = 9;
            this.adminButton.Text = "Administrator";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // userButton
            // 
            this.userButton.AutoSize = true;
            this.userButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.Depth = 0;
            this.userButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userButton.Location = new System.Drawing.Point(0, 264);
            this.userButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.userButton.Name = "userButton";
            this.userButton.Primary = false;
            this.userButton.Size = new System.Drawing.Size(200, 36);
            this.userButton.TabIndex = 8;
            this.userButton.Text = "Użytkownik";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Visible = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // priceButton
            // 
            this.priceButton.AutoSize = true;
            this.priceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.priceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceButton.Depth = 0;
            this.priceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.priceButton.Location = new System.Drawing.Point(0, 228);
            this.priceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.priceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.priceButton.Name = "priceButton";
            this.priceButton.Primary = false;
            this.priceButton.Size = new System.Drawing.Size(200, 36);
            this.priceButton.TabIndex = 6;
            this.priceButton.Text = "Cennik";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // moviesButton
            // 
            this.moviesButton.AutoSize = true;
            this.moviesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.moviesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moviesButton.Depth = 0;
            this.moviesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.moviesButton.Location = new System.Drawing.Point(0, 192);
            this.moviesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.moviesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Primary = false;
            this.moviesButton.Size = new System.Drawing.Size(200, 36);
            this.moviesButton.TabIndex = 7;
            this.moviesButton.Text = "Filmoteka";
            this.moviesButton.UseVisualStyleBackColor = true;
            this.moviesButton.Click += new System.EventHandler(this.moviesButton_Click);
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
            this.seancebutton.Click += new System.EventHandler(this.seancebutton_Click);
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
            this.newsButton.Click += new System.EventHandler(this.newsButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.materialLabel1);
            this.logoPanel.Controls.Add(this.userEmailLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 120);
            this.logoPanel.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(0, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Email";
            this.materialLabel1.Visible = false;
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Depth = 0;
            this.userEmailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userEmailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.userEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userEmailLabel.Location = new System.Drawing.Point(0, 0);
            this.userEmailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(47, 19);
            this.userEmailLabel.TabIndex = 0;
            this.userEmailLabel.Text = "Email";
            this.userEmailLabel.Visible = false;
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Depth = 0;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.Location = new System.Drawing.Point(0, 493);
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
            this.loginButton.Location = new System.Drawing.Point(0, 529);
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
            this.exitButton.Location = new System.Drawing.Point(0, 565);
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
            this.contentPanel.Size = new System.Drawing.Size(800, 601);
            this.contentPanel.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 601);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scruter";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_FormClosing);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private MaterialSkin.Controls.MaterialFlatButton exitButton;
        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialFlatButton logoutButton;
        private MaterialSkin.Controls.MaterialFlatButton loginButton;
        private System.Windows.Forms.Panel logoPanel;
        private MaterialSkin.Controls.MaterialFlatButton priceButton;
        private MaterialSkin.Controls.MaterialFlatButton seancebutton;
        private MaterialSkin.Controls.MaterialFlatButton newsButton;
        private MaterialSkin.Controls.MaterialFlatButton settingsButton;
        private MaterialSkin.Controls.MaterialLabel userEmailLabel;
        private MaterialSkin.Controls.MaterialFlatButton adminButton;
        private MaterialSkin.Controls.MaterialFlatButton userButton;
        private MaterialSkin.Controls.MaterialFlatButton moviesButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}