using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.AdminServices.HallsServices;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Forms.MenuForms.Admin.News;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.Halls
{
    public partial class HallsAdminListForm : MaterialForm
    {
        private DesingerService desingerService;
        private HallsAdminService hallsService;
        private ListFormService listFormService;
        private List<Hall> halls;
        public HallsAdminListForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);

            hallsService = HallsAdminServiceImpl.GetService();
            listFormService = new ListFormService();

            DownloadList();
            listFormService.SetControlButtonsAndLabel(previusPageButton, nextPageButton, pageNumberLabel);
            listFormService.SetInfoPanel(infoLabel);

            ConnectPanels();
            ConnectForms();

            listFormService.ShowForms();
        }

        private void ConnectForms()
        {
            List<MaterialForm> forms = new List<MaterialForm>();
                foreach (Hall hall in halls)
                {
                    forms.Add(new HallsAdminInfoForm(hall));
                }
                listFormService.SetForms(forms);
        }

        private void ConnectPanels()
        {
            List<Panel> panels = new List<Panel>();
            panels.Add(panel1);
            panels.Add(panel2);
            panels.Add(panel3);
            panels.Add(panel4);
            panels.Add(panel5);
            panels.Add(panel6);
            listFormService.SetPanels(panels);
        }

        private void DownloadList()
        {
            halls = hallsService.GetHallsList();
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            listFormService.NextPage();
        }

        private void previusPageButton_Click(object sender, EventArgs e)
        {
            listFormService.PreviusePage();
        }
    }
}
