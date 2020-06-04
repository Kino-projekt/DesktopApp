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
using DesktopApp.Backend.Services.AdminServices;
using DesktopApp.Backend.Services.AdminServices.ArticleServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.News
{
    public partial class AddNewsForm : MaterialForm
    {
        private DesingerService desingerService;
        public AddNewsForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Article article = new Article();
            article.SetTitle(titleField.Text);
            article.SetDescription(descriptionField.Text);

            ArticleAdminService articleService = ArticleAdminServiceImpl.GetService();
            articleService.SendArticle(article);
        }
    }
}
