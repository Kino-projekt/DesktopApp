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
            this.checkTicketPanel = new System.Windows.Forms.Panel();
            this.chceckTicketButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ticketNumberField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.newsTab = new System.Windows.Forms.TabPage();
            this.addNewsButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.newsPanel = new System.Windows.Forms.Panel();
            this.refreshNewsListButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.newsListButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.seancesTab = new System.Windows.Forms.TabPage();
            this.addSeanceButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.seancePanel = new System.Windows.Forms.Panel();
            this.refreshSeanseListButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.seanceListButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.moviesTab = new System.Windows.Forms.TabPage();
            this.addMoviesButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.moviesPanel = new System.Windows.Forms.Panel();
            this.refreshMoviesListButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.moviesListbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.roomsTab = new System.Windows.Forms.TabPage();
            this.addHallButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.hallsPanel = new System.Windows.Forms.Panel();
            this.refreshHallsButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.hallsListButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.refreshUsersListButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.usersListButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mainPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.seanceTab.SuspendLayout();
            this.checkTicketPanel.SuspendLayout();
            this.newsTab.SuspendLayout();
            this.seancesTab.SuspendLayout();
            this.moviesTab.SuspendLayout();
            this.roomsTab.SuspendLayout();
            this.usersTab.SuspendLayout();
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
            this.seanceTab.Controls.Add(this.checkTicketPanel);
            this.seanceTab.Location = new System.Drawing.Point(4, 22);
            this.seanceTab.Name = "seanceTab";
            this.seanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.seanceTab.Size = new System.Drawing.Size(792, 514);
            this.seanceTab.TabIndex = 0;
            this.seanceTab.Text = "Sprawdzarka biletów";
            this.seanceTab.UseVisualStyleBackColor = true;
            // 
            // checkTicketPanel
            // 
            this.checkTicketPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkTicketPanel.Controls.Add(this.chceckTicketButton);
            this.checkTicketPanel.Controls.Add(this.ticketNumberField);
            this.checkTicketPanel.Controls.Add(this.materialLabel2);
            this.checkTicketPanel.Location = new System.Drawing.Point(15, 13);
            this.checkTicketPanel.Margin = new System.Windows.Forms.Padding(10);
            this.checkTicketPanel.Name = "checkTicketPanel";
            this.checkTicketPanel.Size = new System.Drawing.Size(762, 150);
            this.checkTicketPanel.TabIndex = 0;
            // 
            // chceckTicketButton
            // 
            this.chceckTicketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chceckTicketButton.Depth = 0;
            this.chceckTicketButton.Location = new System.Drawing.Point(250, 98);
            this.chceckTicketButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.chceckTicketButton.Name = "chceckTicketButton";
            this.chceckTicketButton.Primary = true;
            this.chceckTicketButton.Size = new System.Drawing.Size(231, 39);
            this.chceckTicketButton.TabIndex = 1;
            this.chceckTicketButton.Text = "Sprawdź bilet";
            this.chceckTicketButton.UseVisualStyleBackColor = true;
            // 
            // ticketNumberField
            // 
            this.ticketNumberField.Depth = 0;
            this.ticketNumberField.Hint = "";
            this.ticketNumberField.Location = new System.Drawing.Point(182, 49);
            this.ticketNumberField.MouseState = MaterialSkin.MouseState.HOVER;
            this.ticketNumberField.Name = "ticketNumberField";
            this.ticketNumberField.PasswordChar = '\0';
            this.ticketNumberField.SelectedText = "";
            this.ticketNumberField.SelectionLength = 0;
            this.ticketNumberField.SelectionStart = 0;
            this.ticketNumberField.Size = new System.Drawing.Size(506, 23);
            this.ticketNumberField.TabIndex = 1;
            this.ticketNumberField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(60, 53);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(99, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Numer biletu:";
            // 
            // newsTab
            // 
            this.newsTab.Controls.Add(this.addNewsButton);
            this.newsTab.Controls.Add(this.newsPanel);
            this.newsTab.Controls.Add(this.refreshNewsListButton);
            this.newsTab.Controls.Add(this.newsListButton);
            this.newsTab.Location = new System.Drawing.Point(4, 22);
            this.newsTab.Name = "newsTab";
            this.newsTab.Padding = new System.Windows.Forms.Padding(3);
            this.newsTab.Size = new System.Drawing.Size(792, 514);
            this.newsTab.TabIndex = 1;
            this.newsTab.Text = "Newsy";
            this.newsTab.UseVisualStyleBackColor = true;
            // 
            // addNewsButton
            // 
            this.addNewsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewsButton.Depth = 0;
            this.addNewsButton.Location = new System.Drawing.Point(203, 13);
            this.addNewsButton.Margin = new System.Windows.Forms.Padding(10);
            this.addNewsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addNewsButton.Name = "addNewsButton";
            this.addNewsButton.Primary = true;
            this.addNewsButton.Size = new System.Drawing.Size(160, 44);
            this.addNewsButton.TabIndex = 2;
            this.addNewsButton.Text = "Dodaj ogłoszenie";
            this.addNewsButton.UseVisualStyleBackColor = true;
            this.addNewsButton.Click += new System.EventHandler(this.addNewsButton_Click);
            // 
            // newsPanel
            // 
            this.newsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newsPanel.Location = new System.Drawing.Point(3, 56);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Size = new System.Drawing.Size(786, 455);
            this.newsPanel.TabIndex = 3;
            // 
            // refreshNewsListButton
            // 
            this.refreshNewsListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshNewsListButton.Depth = 0;
            this.refreshNewsListButton.Location = new System.Drawing.Point(617, 13);
            this.refreshNewsListButton.Margin = new System.Windows.Forms.Padding(10);
            this.refreshNewsListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshNewsListButton.Name = "refreshNewsListButton";
            this.refreshNewsListButton.Primary = true;
            this.refreshNewsListButton.Size = new System.Drawing.Size(160, 44);
            this.refreshNewsListButton.TabIndex = 1;
            this.refreshNewsListButton.Text = "Odśwież liste";
            this.refreshNewsListButton.UseVisualStyleBackColor = true;
            this.refreshNewsListButton.Click += new System.EventHandler(this.refreshNewsListButton_Click);
            // 
            // newsListButton
            // 
            this.newsListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsListButton.Depth = 0;
            this.newsListButton.Location = new System.Drawing.Point(15, 13);
            this.newsListButton.Margin = new System.Windows.Forms.Padding(10);
            this.newsListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.newsListButton.Name = "newsListButton";
            this.newsListButton.Primary = true;
            this.newsListButton.Size = new System.Drawing.Size(170, 44);
            this.newsListButton.TabIndex = 0;
            this.newsListButton.Text = "Lista ogłoszeń";
            this.newsListButton.UseVisualStyleBackColor = true;
            this.newsListButton.Click += new System.EventHandler(this.newsListButton_Click);
            // 
            // seancesTab
            // 
            this.seancesTab.Controls.Add(this.addSeanceButton);
            this.seancesTab.Controls.Add(this.seancePanel);
            this.seancesTab.Controls.Add(this.refreshSeanseListButton);
            this.seancesTab.Controls.Add(this.seanceListButton);
            this.seancesTab.Location = new System.Drawing.Point(4, 22);
            this.seancesTab.Name = "seancesTab";
            this.seancesTab.Padding = new System.Windows.Forms.Padding(3);
            this.seancesTab.Size = new System.Drawing.Size(792, 514);
            this.seancesTab.TabIndex = 2;
            this.seancesTab.Text = "Seanse";
            this.seancesTab.UseVisualStyleBackColor = true;
            // 
            // addSeanceButton
            // 
            this.addSeanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSeanceButton.Depth = 0;
            this.addSeanceButton.Location = new System.Drawing.Point(203, 8);
            this.addSeanceButton.Margin = new System.Windows.Forms.Padding(10);
            this.addSeanceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addSeanceButton.Name = "addSeanceButton";
            this.addSeanceButton.Primary = true;
            this.addSeanceButton.Size = new System.Drawing.Size(160, 44);
            this.addSeanceButton.TabIndex = 6;
            this.addSeanceButton.Text = "Dodaj seans";
            this.addSeanceButton.UseVisualStyleBackColor = true;
            this.addSeanceButton.Click += new System.EventHandler(this.addSeanceButton_Click);
            // 
            // seancePanel
            // 
            this.seancePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.seancePanel.Location = new System.Drawing.Point(3, 56);
            this.seancePanel.Name = "seancePanel";
            this.seancePanel.Size = new System.Drawing.Size(786, 455);
            this.seancePanel.TabIndex = 7;
            // 
            // refreshSeanseListButton
            // 
            this.refreshSeanseListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshSeanseListButton.Depth = 0;
            this.refreshSeanseListButton.Location = new System.Drawing.Point(617, 8);
            this.refreshSeanseListButton.Margin = new System.Windows.Forms.Padding(10);
            this.refreshSeanseListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshSeanseListButton.Name = "refreshSeanseListButton";
            this.refreshSeanseListButton.Primary = true;
            this.refreshSeanseListButton.Size = new System.Drawing.Size(160, 44);
            this.refreshSeanseListButton.TabIndex = 5;
            this.refreshSeanseListButton.Text = "Odśwież liste";
            this.refreshSeanseListButton.UseVisualStyleBackColor = true;
            this.refreshSeanseListButton.Click += new System.EventHandler(this.refreshSeanseListButton_Click);
            // 
            // seanceListButton
            // 
            this.seanceListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seanceListButton.Depth = 0;
            this.seanceListButton.Location = new System.Drawing.Point(15, 8);
            this.seanceListButton.Margin = new System.Windows.Forms.Padding(10);
            this.seanceListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.seanceListButton.Name = "seanceListButton";
            this.seanceListButton.Primary = true;
            this.seanceListButton.Size = new System.Drawing.Size(170, 44);
            this.seanceListButton.TabIndex = 4;
            this.seanceListButton.Text = "Lista seansów";
            this.seanceListButton.UseVisualStyleBackColor = true;
            this.seanceListButton.Click += new System.EventHandler(this.seanceListButton_Click);
            // 
            // moviesTab
            // 
            this.moviesTab.Controls.Add(this.addMoviesButton);
            this.moviesTab.Controls.Add(this.moviesPanel);
            this.moviesTab.Controls.Add(this.refreshMoviesListButton);
            this.moviesTab.Controls.Add(this.moviesListbutton);
            this.moviesTab.Location = new System.Drawing.Point(4, 22);
            this.moviesTab.Name = "moviesTab";
            this.moviesTab.Padding = new System.Windows.Forms.Padding(3);
            this.moviesTab.Size = new System.Drawing.Size(792, 514);
            this.moviesTab.TabIndex = 3;
            this.moviesTab.Text = "Filmy";
            this.moviesTab.UseVisualStyleBackColor = true;
            // 
            // addMoviesButton
            // 
            this.addMoviesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMoviesButton.Depth = 0;
            this.addMoviesButton.Location = new System.Drawing.Point(203, 13);
            this.addMoviesButton.Margin = new System.Windows.Forms.Padding(10);
            this.addMoviesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addMoviesButton.Name = "addMoviesButton";
            this.addMoviesButton.Primary = true;
            this.addMoviesButton.Size = new System.Drawing.Size(160, 44);
            this.addMoviesButton.TabIndex = 6;
            this.addMoviesButton.Text = "Dodaj film";
            this.addMoviesButton.UseVisualStyleBackColor = true;
            this.addMoviesButton.Click += new System.EventHandler(this.addMoviesButton_Click);
            // 
            // moviesPanel
            // 
            this.moviesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.moviesPanel.Location = new System.Drawing.Point(3, 56);
            this.moviesPanel.Name = "moviesPanel";
            this.moviesPanel.Size = new System.Drawing.Size(786, 455);
            this.moviesPanel.TabIndex = 7;
            // 
            // refreshMoviesListButton
            // 
            this.refreshMoviesListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshMoviesListButton.Depth = 0;
            this.refreshMoviesListButton.Location = new System.Drawing.Point(617, 13);
            this.refreshMoviesListButton.Margin = new System.Windows.Forms.Padding(10);
            this.refreshMoviesListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshMoviesListButton.Name = "refreshMoviesListButton";
            this.refreshMoviesListButton.Primary = true;
            this.refreshMoviesListButton.Size = new System.Drawing.Size(160, 44);
            this.refreshMoviesListButton.TabIndex = 5;
            this.refreshMoviesListButton.Text = "Odśwież liste";
            this.refreshMoviesListButton.UseVisualStyleBackColor = true;
            this.refreshMoviesListButton.Click += new System.EventHandler(this.refreshMoviesListButton_Click);
            // 
            // moviesListbutton
            // 
            this.moviesListbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moviesListbutton.Depth = 0;
            this.moviesListbutton.Location = new System.Drawing.Point(13, 13);
            this.moviesListbutton.Margin = new System.Windows.Forms.Padding(10);
            this.moviesListbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.moviesListbutton.Name = "moviesListbutton";
            this.moviesListbutton.Primary = true;
            this.moviesListbutton.Size = new System.Drawing.Size(170, 44);
            this.moviesListbutton.TabIndex = 4;
            this.moviesListbutton.Text = "Lista filmów";
            this.moviesListbutton.UseVisualStyleBackColor = true;
            this.moviesListbutton.Click += new System.EventHandler(this.moviesListbutton_Click);
            // 
            // roomsTab
            // 
            this.roomsTab.Controls.Add(this.addHallButton);
            this.roomsTab.Controls.Add(this.hallsPanel);
            this.roomsTab.Controls.Add(this.refreshHallsButton);
            this.roomsTab.Controls.Add(this.hallsListButton);
            this.roomsTab.Location = new System.Drawing.Point(4, 22);
            this.roomsTab.Name = "roomsTab";
            this.roomsTab.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTab.Size = new System.Drawing.Size(792, 514);
            this.roomsTab.TabIndex = 4;
            this.roomsTab.Text = "Sale";
            this.roomsTab.UseVisualStyleBackColor = true;
            // 
            // addHallButton
            // 
            this.addHallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addHallButton.Depth = 0;
            this.addHallButton.Location = new System.Drawing.Point(205, 13);
            this.addHallButton.Margin = new System.Windows.Forms.Padding(10);
            this.addHallButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addHallButton.Name = "addHallButton";
            this.addHallButton.Primary = true;
            this.addHallButton.Size = new System.Drawing.Size(160, 44);
            this.addHallButton.TabIndex = 6;
            this.addHallButton.Text = "Dodaj sale";
            this.addHallButton.UseVisualStyleBackColor = true;
            this.addHallButton.Click += new System.EventHandler(this.addHallButton_Click);
            // 
            // hallsPanel
            // 
            this.hallsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hallsPanel.Location = new System.Drawing.Point(3, 56);
            this.hallsPanel.Name = "hallsPanel";
            this.hallsPanel.Size = new System.Drawing.Size(786, 455);
            this.hallsPanel.TabIndex = 7;
            // 
            // refreshHallsButton
            // 
            this.refreshHallsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshHallsButton.Depth = 0;
            this.refreshHallsButton.Location = new System.Drawing.Point(617, 13);
            this.refreshHallsButton.Margin = new System.Windows.Forms.Padding(10);
            this.refreshHallsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshHallsButton.Name = "refreshHallsButton";
            this.refreshHallsButton.Primary = true;
            this.refreshHallsButton.Size = new System.Drawing.Size(160, 44);
            this.refreshHallsButton.TabIndex = 5;
            this.refreshHallsButton.Text = "Odśwież liste";
            this.refreshHallsButton.UseVisualStyleBackColor = true;
            this.refreshHallsButton.Click += new System.EventHandler(this.refreshHallsButton_Click);
            // 
            // hallsListButton
            // 
            this.hallsListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hallsListButton.Depth = 0;
            this.hallsListButton.Location = new System.Drawing.Point(15, 13);
            this.hallsListButton.Margin = new System.Windows.Forms.Padding(10);
            this.hallsListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.hallsListButton.Name = "hallsListButton";
            this.hallsListButton.Primary = true;
            this.hallsListButton.Size = new System.Drawing.Size(170, 44);
            this.hallsListButton.TabIndex = 4;
            this.hallsListButton.Text = "Lista sal";
            this.hallsListButton.UseVisualStyleBackColor = true;
            this.hallsListButton.Click += new System.EventHandler(this.hallsListButton_Click);
            // 
            // usersTab
            // 
            this.usersTab.Controls.Add(this.usersPanel);
            this.usersTab.Controls.Add(this.refreshUsersListButton);
            this.usersTab.Controls.Add(this.usersListButton);
            this.usersTab.Location = new System.Drawing.Point(4, 22);
            this.usersTab.Name = "usersTab";
            this.usersTab.Padding = new System.Windows.Forms.Padding(3);
            this.usersTab.Size = new System.Drawing.Size(792, 514);
            this.usersTab.TabIndex = 5;
            this.usersTab.Text = "Użytkownicy";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // usersPanel
            // 
            this.usersPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usersPanel.Location = new System.Drawing.Point(3, 56);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(786, 455);
            this.usersPanel.TabIndex = 7;
            // 
            // refreshUsersListButton
            // 
            this.refreshUsersListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshUsersListButton.Depth = 0;
            this.refreshUsersListButton.Location = new System.Drawing.Point(617, 13);
            this.refreshUsersListButton.Margin = new System.Windows.Forms.Padding(10);
            this.refreshUsersListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshUsersListButton.Name = "refreshUsersListButton";
            this.refreshUsersListButton.Primary = true;
            this.refreshUsersListButton.Size = new System.Drawing.Size(160, 44);
            this.refreshUsersListButton.TabIndex = 5;
            this.refreshUsersListButton.Text = "Odśwież liste";
            this.refreshUsersListButton.UseVisualStyleBackColor = true;
            this.refreshUsersListButton.Click += new System.EventHandler(this.refreshUsersListButton_Click);
            // 
            // usersListButton
            // 
            this.usersListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersListButton.Depth = 0;
            this.usersListButton.Location = new System.Drawing.Point(15, 13);
            this.usersListButton.Margin = new System.Windows.Forms.Padding(10);
            this.usersListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.usersListButton.Name = "usersListButton";
            this.usersListButton.Primary = true;
            this.usersListButton.Size = new System.Drawing.Size(170, 44);
            this.usersListButton.TabIndex = 4;
            this.usersListButton.Text = "Lista użytkowników";
            this.usersListButton.UseVisualStyleBackColor = true;
            this.usersListButton.Click += new System.EventHandler(this.usersListButton_Click);
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
            this.seanceTab.ResumeLayout(false);
            this.checkTicketPanel.ResumeLayout(false);
            this.checkTicketPanel.PerformLayout();
            this.newsTab.ResumeLayout(false);
            this.seancesTab.ResumeLayout(false);
            this.moviesTab.ResumeLayout(false);
            this.roomsTab.ResumeLayout(false);
            this.usersTab.ResumeLayout(false);
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
        private System.Windows.Forms.Panel newsPanel;
        private MaterialSkin.Controls.MaterialRaisedButton addNewsButton;
        private MaterialSkin.Controls.MaterialRaisedButton refreshNewsListButton;
        private MaterialSkin.Controls.MaterialRaisedButton newsListButton;
        private System.Windows.Forms.Panel checkTicketPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField ticketNumberField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton chceckTicketButton;
        private System.Windows.Forms.Panel usersPanel;
        private MaterialSkin.Controls.MaterialRaisedButton refreshUsersListButton;
        private MaterialSkin.Controls.MaterialRaisedButton usersListButton;
        private MaterialSkin.Controls.MaterialRaisedButton addMoviesButton;
        private System.Windows.Forms.Panel moviesPanel;
        private MaterialSkin.Controls.MaterialRaisedButton refreshMoviesListButton;
        private MaterialSkin.Controls.MaterialRaisedButton moviesListbutton;
        private MaterialSkin.Controls.MaterialRaisedButton addHallButton;
        private System.Windows.Forms.Panel hallsPanel;
        private MaterialSkin.Controls.MaterialRaisedButton refreshHallsButton;
        private MaterialSkin.Controls.MaterialRaisedButton hallsListButton;
        private MaterialSkin.Controls.MaterialRaisedButton addSeanceButton;
        private System.Windows.Forms.Panel seancePanel;
        private MaterialSkin.Controls.MaterialRaisedButton refreshSeanseListButton;
        private MaterialSkin.Controls.MaterialRaisedButton seanceListButton;
    }
}