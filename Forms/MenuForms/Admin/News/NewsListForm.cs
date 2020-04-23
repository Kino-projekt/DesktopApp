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
using DesktopApp.Backend.Services.ArticleServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.News
{
    public partial class NewsListForm : MaterialForm
    {
        private DesingerService desingerService;
        private ArticleService articleService;
        private List<Article> articles;

        public NewsListForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);

            articleService = ArticleServiceImpl.GetService();
            ShowNews();
        }

        private void ShowNews()
        {
            articles = articleService.GetArticleListForAdmin();
            if (articles == null)
            {
                title1.Text = "brak info";
            }
            else
            {
                title1.Text = articles[0].GetTitle();
                description1.Text = articles[0].GetDescription();
            }
        }
    }
}
