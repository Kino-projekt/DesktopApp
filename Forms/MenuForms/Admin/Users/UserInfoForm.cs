using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.AdminServices.ArticleServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.Users
{
    public partial class UserInfoForm : MaterialForm
    {
        private DesingerService desingerService;
        private Backend.Data.User user;

        public UserInfoForm(Backend.Data.User user)
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(contentPanel);

            this.user = user;
            SetLabels();
        }

        private void SetLabels()
        {
            idLabel.Text = "Numer: " + user.GetId();
            emailLabel.Text = user.GetEmail();
            
            if (user.GetRole() == Role.ADMIN)
                roleLabel.Text = "Administrator";
            else
                roleLabel.Text = "Użytkownik";
        }
    }
}
