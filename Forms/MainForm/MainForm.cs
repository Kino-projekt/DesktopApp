using System;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.ContentPanel;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Backend.Services.UserServices;
using MaterialSkin.Controls;

namespace DesktopApp.MainForm
{
    public partial class MainForm : MaterialForm
    {
        private bool userStatus;
        private DesingerService desingerService;
        private ContentPanelController contentPanelController;

        public MainForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            contentPanelController = ContentPanelControllerImpl.CreateController(contentPanel);
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
    }
}
