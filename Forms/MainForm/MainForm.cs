using System;
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
        private DesingerService desinger;
        private ContentPanelController content;

        public MainForm()
        {
            InitializeComponent();
            desinger = DesingerServiceImpl.GetInstance();
            desinger.AddFormToDesinger(this);
            desinger.AddPanelToChangeColor(menuPanel);
            desinger.AddPanelToChangeColor(logoPanel);

            content = ContentPanelControllerImpl.CreateController(contentPanel);
            content.OpenNewsForm();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            FormsController formsController = FormsControllerImpl.GetInstance();
            formsController.OpenLoginForm();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = LogoutDialog();
            if (dialog == DialogResult.Yes)
            {
                MainUserService mainUserService = MainUserServiceImpl.GetInstance();
                mainUserService.RemoveUser();
            }
        }

        public void SetUserRole(Role role)
        {
            content.OpenNewsForm();
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
            MainUserService mainUserService = MainUserServiceImpl.GetInstance();
            return mainUserService.GetUserEmail();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            content.OpenSettingForm();
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            content.OpenPriceForm();
            
        }

        private void newsButton_Click(object sender, EventArgs e)
        {
            content.OpenNewsForm();
        }

        private void seancebutton_Click(object sender, EventArgs e)
        {
            content.OpenSeanceForm();
        }

        private void userButton_Click(object sender, EventArgs e)
        {

            content.OpenUserForm();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
         content.OpenAdminForms();   
        }

        private void moviesButton_Click(object sender, EventArgs e)
        {
            content.OpenMoviesForm();
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

        private DialogResult LogoutDialog()
        {
            DialogResult dialog = dialog = MessageBox.Show("Czy na pewno chcesz się wylogować z programu?", "Scruter", MessageBoxButtons.YesNo);
            return dialog;
        }

    }
}
