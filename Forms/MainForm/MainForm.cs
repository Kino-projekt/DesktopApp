﻿using System;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.ContentPanel;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Backend.Services.UserServices;
using MaterialSkin.Controls;

namespace DesktopApp.MainForm
{
    public partial class MainForm : MaterialForm
    {
        private DesingerService desingerService;
        private ContentPanelController contentPanelController;

        public MainForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            contentPanelController = ContentPanelControllerImpl.CreateController(contentPanel);
            contentPanelController.OpenNewsForm();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            FormsController formsController = FormsControllerImpl.GetInstance();
            formsController.OpenLoginForm();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            UserService userService = UserServiceImpl.GetInstance();
            userService.RemoveUser();
        }

        public void SetUserRole(Role role)
        {
            contentPanelController.OpenNewsForm();
            if (role == Role.CUSTOMER)
            {
                StandardUserSetting();
            }
            else if (role == Role.ADMIN)
            {
                AdminUserSettings();
            }
            else
            {
                EmptyUserSetting();
            }
        }


        private void EmptyUserSetting()
        {
            loginButton.Visible = true;
            logoutButton.Visible = false;
            userEmailLabel.Visible = false;

            userButton.Visible = false;
            adminButton.Visible = false;
        }

        private void StandardUserSetting()
        {
            loginButton.Visible = false;
            logoutButton.Visible = true;

            userEmailLabel.Text = GetUserEmailFromService();
            userEmailLabel.Visible = true;

            userButton.Visible = true;
            adminButton.Visible = false;
        }

        private void AdminUserSettings()
        {
            StandardUserSetting();
            adminButton.Visible = true;
        }

        private string GetUserEmailFromService()
        {
            UserService userService = UserServiceImpl.GetInstance();
            return userService.GetUserEmail();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            contentPanelController.OpenSettingForm();
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            contentPanelController.OpenPriceForm();
        }

        private void newsButton_Click(object sender, EventArgs e)
        {
            contentPanelController.OpenNewsForm();
        }

        private void seancebutton_Click(object sender, EventArgs e)
        {
            contentPanelController.OpenSeanceForm();
        }

        private void userButton_Click(object sender, EventArgs e)
        {

            contentPanelController.OpenUserForm();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
         contentPanelController.OpenAdminForms();   
        }

        private void moviesButton_Click(object sender, EventArgs e)
        {
            contentPanelController.OpenMoviesForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = CloseDialog();
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult dialog = CloseDialog();
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private DialogResult CloseDialog()
        {
            DialogResult dialog = dialog = MessageBox.Show("Czy na pewno chcesz zamknąć ten program?", "Scruter", MessageBoxButtons.YesNo);
            return dialog;
        }
    }
}
