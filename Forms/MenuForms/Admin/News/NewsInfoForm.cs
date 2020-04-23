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
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.News
{
    public partial class NewsInfoForm : MaterialForm
    {
        private DesingerService desingerService;
        private Article article;

        public NewsInfoForm(Article article)
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            this.article = article;
            SetLabels();
        }

        private void SetLabels()
        {
            idLabel.Text = "Numer: " + article.GetId();
            titleLabel.Text = article.GetTitle();
            descriptionLabel.Text = article.GetDescription();
            statusLabel.Text = article.GetStatus();
        }
    }
}
