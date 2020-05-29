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
using DesktopApp.Backend.Services.AdminServices.HallsServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.Halls
{
    public partial class AddHallsForm : MaterialForm
    {
        private DesingerService desingerService;
        public AddHallsForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Hall hall = new Hall();
            hall.SetName(nameField.Text);
            hall.SetSeats((int)numberField.Value);
            HallsAdminServiceImpl.GetService().SendHallToServer(hall);
        }
    }
}
