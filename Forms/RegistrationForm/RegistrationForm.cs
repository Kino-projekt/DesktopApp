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
using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.RegistrationForm
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormService formService = FormsController.getFormService();
            formService.OpenLoginForm();
        }
    }
}
