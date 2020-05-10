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
using DesktopApp.Backend.Services.AdminServices.HallsServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.Halls
{
    public partial class HallsAdminInfoForm : MaterialForm
    {
        private DesingerService desingerService;
        private HallsAdminService service;
        private Hall hall;

        public HallsAdminInfoForm(Hall hall)
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(contentPanel);

            service = HallsAdminServiceImpl.GetService();
            this.hall = hall;
            SetLabels();
        }

        private void SetLabels()
        {
            idLabel.Text = "Numer: " + hall.GetId();
            nameLabel.Text = "Sala: "+hall.GetName();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            service.DeleteHall(hall);
        }
    }
}
