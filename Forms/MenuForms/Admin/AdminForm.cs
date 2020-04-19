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
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Forms.MenuForms.Admin.News;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin
{
    public partial class AdminForm : MaterialForm
    {
        private DesingerService desingerService;
        private ContentCreator newsContent;

        public AdminForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);

            newsContent = new ContentCreator(newsPanel);
            newsContent.Open(new NewsListForm());
        }

        private void addNewsButton_Click(object sender, EventArgs e)
        {
            newsContent.Open(new AddNewsForm());
        }

        private void newsListButton_Click(object sender, EventArgs e)
        {
            newsContent.Open(new NewsListForm());
        }
    }
}
