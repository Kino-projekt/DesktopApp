namespace DesktopApp
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPriceList = new System.Windows.Forms.Button();
            this.btnSeance = new System.Windows.Forms.Button();
            this.btnPremiere = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorPanel = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.authorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.menuPanel.Controls.Add(this.btnLogin);
            this.menuPanel.Controls.Add(this.btnPriceList);
            this.menuPanel.Controls.Add(this.btnSeance);
            this.menuPanel.Controls.Add(this.btnPremiere);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(234, 761);
            this.menuPanel.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(0, 684);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(234, 77);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Logowanie";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnPriceList
            // 
            this.btnPriceList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceList.FlatAppearance.BorderSize = 0;
            this.btnPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceList.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriceList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPriceList.Location = new System.Drawing.Point(0, 282);
            this.btnPriceList.Name = "btnPriceList";
            this.btnPriceList.Size = new System.Drawing.Size(237, 77);
            this.btnPriceList.TabIndex = 3;
            this.btnPriceList.Text = "Cennik";
            this.btnPriceList.UseVisualStyleBackColor = true;
            // 
            // btnSeance
            // 
            this.btnSeance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeance.FlatAppearance.BorderSize = 0;
            this.btnSeance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeance.Location = new System.Drawing.Point(-3, 199);
            this.btnSeance.Name = "btnSeance";
            this.btnSeance.Size = new System.Drawing.Size(237, 77);
            this.btnSeance.TabIndex = 2;
            this.btnSeance.Text = "Repertuar";
            this.btnSeance.UseVisualStyleBackColor = true;
            // 
            // btnPremiere
            // 
            this.btnPremiere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPremiere.FlatAppearance.BorderSize = 0;
            this.btnPremiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPremiere.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremiere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPremiere.Location = new System.Drawing.Point(0, 116);
            this.btnPremiere.Name = "btnPremiere";
            this.btnPremiere.Size = new System.Drawing.Size(234, 77);
            this.btnPremiere.TabIndex = 1;
            this.btnPremiere.Text = "Premiery";
            this.btnPremiere.UseVisualStyleBackColor = true;
            this.btnPremiere.Click += new System.EventHandler(this.btnPremiere_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.logoPanel.Controls.Add(this.titleLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(234, 100);
            this.logoPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(23, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(189, 36);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "SCRUTER";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorPanel
            // 
            this.authorPanel.Controls.Add(this.authorLabel);
            this.authorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.authorPanel.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.authorPanel.Location = new System.Drawing.Point(234, 681);
            this.authorPanel.Name = "authorPanel";
            this.authorPanel.Size = new System.Drawing.Size(1150, 80);
            this.authorPanel.TabIndex = 1;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(367, 30);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(257, 23);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "Informacje prawne i takie tam";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(234, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1150, 681);
            this.contentPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.authorPanel);
            this.Controls.Add(this.menuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.authorPanel.ResumeLayout(false);
            this.authorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel authorPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button btnPremiere;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPriceList;
        private System.Windows.Forms.Button btnSeance;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Panel contentPanel;
    }
}

