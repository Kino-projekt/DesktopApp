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
using DesktopApp.Backend.Services;
using DesktopApp.Backend.Services.FormServices;
using DesktopApp.Backend.Services.UserServices;
using DesktopApp.Forms.LoginForm;
using DesktopApp.Forms.RegistrationForm;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopApp.MainForm
{
    public partial class MainForm : MaterialForm
    {
        private bool userStatus;

        public MainForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            FormService formService = new FormServiceImpl();
            formService.OpenLoginForm();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            UserService userService = UserController.GetUserService();
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
                loginButton.Visible = true;
                logoutButton.Visible = false;
            }
            else
            {
                loginButton.Visible = false;
                logoutButton.Visible = true;
            }
        }

    }
}
