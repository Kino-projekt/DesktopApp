using System;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Services;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.LoginForm
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void registractionButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormService formService = FormsController.getFormService();
            formService.OpenRegitrationForm();
        }
    }
}
