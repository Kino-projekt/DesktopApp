using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Backend.Services.UserServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.User
{
    public partial class UserForm : MaterialForm
    {
        private DesingerService desingerService;
        public UserForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(passwordPanel);
            desingerService.AddPanelToChangeColor(accoutnDeletePanel);

        }
    }
}
