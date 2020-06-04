using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.AdminServices.ArticleServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.News
{
    public partial class NewsAdminListForm : MaterialForm
    {
        private DesingerService desingerService;
        private ArticleAdminService articleService;
        private ListFormService listFormService;
        private List<Article> articles;

        public NewsAdminListForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);

            articleService = ArticleAdminServiceImpl.GetService();
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
            foreach (Article article in articles)
            {
                forms.Add(new NewsAdminInfoForm(article));
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
            articles = articleService.GetArticleList();
        }

        private void previusPageButton_Click(object sender, EventArgs e)
        {
            listFormService.PreviusePage();
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            listFormService.NextPage();
        }
    }
}
