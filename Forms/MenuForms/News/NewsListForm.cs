using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.ContentPanel.Methods;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Forms.MenuForms.Admin.News;
using MaterialSkin.Controls;
using DesktopApp.Backend.Services.DataServices.ArticleServices;
using DesktopApp.Forms.MenuForms.Movies;

namespace DesktopApp.Forms.MenuForms.News
{
    public partial class NewsListForm : MaterialForm
    {
        private DesingerService desingerService;
        private ArticleService articleService;
        private ListFormService listFormService;
        private List<Article> articles;

        public NewsListForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);

            articleService = ArticleServiceImpl.GetService();
            listFormService = new ListFormService();

            DownloadArticlesList();
            listFormService.SetControlButtonsAndLabel(previusPageButton, nextPageButton, pageNumberLabel);
            ConnectPanels();
            ConnectForms();

            listFormService.ShowForms();
        }

        private void ConnectForms()
        {
            List<MaterialForm> forms = new List<MaterialForm>();
            foreach (Article article in articles)
            {
                forms.Add(new NewsInfoForm(article));
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
            panels.Add(panel7);
            listFormService.SetPanels(panels);
        }

        
        private void DownloadArticlesList()
        {
            articles = articleService.GetArticleList();
            if (articles == null)
                infoLabel.Visible = true;
            else
                infoLabel.Visible = false;


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
