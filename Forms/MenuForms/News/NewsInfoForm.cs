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

namespace DesktopApp.Forms.MenuForms.News
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
            desingerService.AddPanelToChangeColor(contentPanel);

            this.article = article;
            SetLabels();
        }

        private void SetLabels()
        {
            titleLabel.Text = article.GetTitle();
            descriptionLabel.Text = article.GetDescription();
            dateLabel.Text = article.GetDate().Remove(10); ;
        }
    }
}
