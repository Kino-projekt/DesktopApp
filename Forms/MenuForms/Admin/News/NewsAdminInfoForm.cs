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
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.News
{
    public partial class NewsAdminInfoForm : MaterialForm
    {
        private DesingerService desingerService;
        private ArticleAdminService service;
        private Article article;

        public NewsAdminInfoForm(Article article)
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(contentPanel);

            service = ArticleAdminServiceImpl.GetService();
            this.article = article;
            SetLabels();
        }

        private void SetLabels()
        {
            idLabel.Text = "Numer: " + article.GetId();
            titleLabel.Text = article.GetTitle();
            descriptionLabel.Text = article.GetDescription();
            if (article.GetStatus() == Status.Active)
                statusLabel.Text = "Aktywne";
            else
                statusLabel.Text = "Nieaktywne";
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            service.ChangeArticleStatus(article);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            service.DeleteArticle(article);
        }
    }
}
