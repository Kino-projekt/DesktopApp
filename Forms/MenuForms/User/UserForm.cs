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
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Backend.Services.UserServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.User
{
    public partial class UserForm : MaterialForm
    {
        private DesingerService desingerService;
        private MainUserService mainUser;
        public UserForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(passwordPanel);
            desingerService.AddPanelToChangeColor(accoutnDeletePanel);
            desingerService.AddPanelToChangeColor(panel1);
            desingerService.AddPanelToChangeColor(panel2);
            desingerService.AddPanelToChangeColor(panel3);
            desingerService.AddPanelToChangeColor(userInfoPanel);

            mainUser = MainUserServiceImpl.GetInstance();
            SetLabels();
        }

        private void SetLabels()
        {

            if (mainUser.GetUserRole() != Role.DEFAULT)
            {
                emailLabel.Text = "Adres: "+mainUser.GetUserEmail();
                roleLabel.Text = "Poziom uprawnień: "+mainUser.GetUserRole();
            }
           
        }
    }
}
