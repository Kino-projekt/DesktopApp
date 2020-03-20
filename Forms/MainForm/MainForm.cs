using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Services;
using DesktopApp.Backend.Services.FormServices;
using DesktopApp.Forms.LoginForm;
using DesktopApp.Forms.RegistrationForm;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopApp.MainForm
{
    public partial class MainForm : MaterialForm
    {
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

    }
}
