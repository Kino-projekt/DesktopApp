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
using DesktopApp.Backend.Services.AdminServices;
using DesktopApp.Backend.Services.AdminServices.ArticleServices;
using DesktopApp.Backend.Services.ArticleServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.News
{
    public partial class NewsAdminListForm : MaterialForm
    {
        private DesingerService desingerService;
        private ArticleAdminService articleService;
        private List<Article> articles;
        private int lastArticle;
        private int sizeList;
        private int pageNumber;

        public NewsAdminListForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);

            articleService = ArticleAdminServiceImpl.GetService();
            pageNumber = 1;
            DownloadArticlesList();
            ShowNews();
        }

        private void ShowNews()
        {
            CleanContentPanel();

            if (sizeList <= 0 || articles == null) { }
            else
            {
                if(sizeList>=1+lastArticle)
                    CreateNewsPanel(panel1, 0 + lastArticle);
                if (sizeList >= 2 + lastArticle)
                    CreateNewsPanel(panel2, 1 + lastArticle);
                if (sizeList >= 3 + lastArticle)
                    CreateNewsPanel(panel3, 2 + lastArticle);
                if (sizeList >= 4 + lastArticle)
                    CreateNewsPanel(panel4, 3 + lastArticle);
                if (sizeList >= 5 + lastArticle)
                    CreateNewsPanel(panel5, 4 + lastArticle);
                if (sizeList >= 6 + lastArticle)
                    CreateNewsPanel(panel6, 5 + lastArticle);

                if (lastArticle != 0)
                    previusPageButton.Visible = true;

                if (lastArticle + 6 < sizeList)
                    nextPageButton.Visible = true;
            }
        }

        private void CreateNewsPanel(Panel panel, int number)
        {
            panel.Visible = true;
            PanelCreator contentPanel = new PanelCreator(panel);
            contentPanel.Open(new NewsAdminInfoForm(articles[number]));
        }

        private void DownloadArticlesList()
        {
            articles = articleService.GetArticleListForAdmin();
            sizeList = articles.Count;
            lastArticle = 0;
        }

        private void previusPageButton_Click(object sender, EventArgs e)
        {
            lastArticle = lastArticle - 6;
            pageNumber--;
            ShowNews();
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            lastArticle = lastArticle + 6;
            pageNumber++;
            ShowNews();
        }

        private void CleanContentPanel()
        {
            SetPageNumberLabel();
            previusPageButton.Visible = false;
            nextPageButton.Visible = false;

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void SetPageNumberLabel()
        {
            if (sizeList <= 8)
            {
                pageNumberLabel.Visible = false;
            }
            else
            {
                pageNumberLabel.Visible = true;
                pageNumberLabel.Text = "Strona: " + pageNumber;
            }
        }
    }
}
