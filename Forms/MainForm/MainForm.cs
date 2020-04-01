using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Services;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Backend.Services.UserServices;
using DesktopApp.Forms.LoginForm;
using DesktopApp.Forms.MenuForms.Settings;
using DesktopApp.Forms.RegistrationForm;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopApp.MainForm
{
    public partial class MainForm : MaterialForm
    {
        private bool userStatus;
        private DesingerService desingerService;

        public MainForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
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

        public void SetUserStatus(bool userStatus)
        {
            this.userStatus = userStatus;
            ChangeUserStatus();
        }

        private void ChangeUserStatus()
        {
            if (userStatus == false)
            {

                EmptyUserSetting();
            }
            else
            {
                StandardUserSetting();
            }
        }

        private MaterialForm activeForm = null;

        private void OpenChildForm(MaterialForm childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(childForm);
            contentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void EmptyUserSetting()
        {
            loginButton.Visible = true;
            logoutButton.Visible = false;
            userEmailLabel.Visible = false;
        }

        private void StandardUserSetting()
        {
            loginButton.Visible = false;
            logoutButton.Visible = true;

            userEmailLabel.Text = GetUserEmailFromService();
            userEmailLabel.Visible = true;
        }

        private string GetUserEmailFromService()
        {
            UserService userService = UserServiceImpl.GetInstance();
            return userService.GetUserEmail();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingsForm());
        }
    }
}
