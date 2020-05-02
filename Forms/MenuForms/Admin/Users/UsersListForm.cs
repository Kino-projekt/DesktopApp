using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Services.AdminServices.ArticleServices;
using DesktopApp.Backend.Services.AdminServices.UsersServices;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Forms.MenuForms.Admin.News;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.Users
{
    public partial class UsersListForm : MaterialForm
    {
        private DesingerService desingerService;
        private UsersService usersService;
        private ListFormService listFormService;
        private List<Backend.Data.User> users;
        public UsersListForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);

            usersService = UsersServiceImpl.GetService();
            listFormService = new ListFormService();

            DownloadArticlesList();
            listFormService.SetControlButtonsAndLabel(previusPageButton, nextPageButton, pageNumberLabel);
            listFormService.SetInfoPanel(infoLabel);

            ConnectPanels();
            ConnectForms();

            listFormService.ShowForms();
        }

        private void ConnectForms()
        {
            List<MaterialForm> forms = new List<MaterialForm>();
            foreach (Backend.Data.User user in users)
            {
                forms.Add(new UserInfoForm(user));
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

        private void DownloadArticlesList()
        {
            users = usersService.GetUsersList();
        }

        private void nextPageButton_Click_1(object sender, EventArgs e)
        {
            listFormService.NextPage();
        }

        private void previusPageButton_Click_1(object sender, EventArgs e)
        {
            listFormService.PreviusePage();
        }
    }
}
