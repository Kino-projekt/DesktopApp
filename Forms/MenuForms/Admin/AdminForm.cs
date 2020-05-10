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
using DesktopApp.Backend.Services.AdminServices.ArticleServices;
using DesktopApp.Backend.Services.AdminServices.HallsServices;
using DesktopApp.Backend.Services.AdminServices.MoviesServices;
using DesktopApp.Backend.Services.AdminServices.UsersServices;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Forms.MenuForms.Admin.Halls;
using DesktopApp.Forms.MenuForms.Admin.Movies;
using DesktopApp.Forms.MenuForms.Admin.News;
using DesktopApp.Forms.MenuForms.Admin.Users;
using DesktopApp.Forms.MenuForms.Movies;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin
{
    public partial class AdminForm : MaterialForm
    {
        private DesingerService desingerService;

        private PanelCreator newsContent;
        private PanelCreator moviesContent;
        private PanelCreator usersContent;
        private PanelCreator hallsContent;

        public AdminForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(checkTicketPanel);

            newsContent = new PanelCreator(newsPanel);
            newsContent.Open(new NewsAdminListForm());

            moviesContent = new PanelCreator(moviesPanel);
            moviesContent.Open(new MoviesAdminListForm());

            usersContent = new PanelCreator(usersPanel);
            usersContent.Open(new UsersListForm());

            hallsContent = new PanelCreator(hallsPanel);
            hallsContent.Open(new HallsAdminListForm());
        }

        private void addNewsButton_Click(object sender, EventArgs e)
        {
            newsContent.Open(new AddNewsForm());
        }

        private void newsListButton_Click(object sender, EventArgs e)
        {
            newsContent.Open(new NewsAdminListForm());
        }

        private void usersListButton_Click(object sender, EventArgs e)
        {
            usersContent.Open(new UsersListForm());
        }

        private void refreshNewsListButton_Click(object sender, EventArgs e)
        {
            ArticleAdminServiceImpl.GetService().DownloadArticleList();
            usersContent.Open(new UsersListForm());
        }

        private void refreshUsersListButton_Click(object sender, EventArgs e)
        {
            UsersServiceImpl.GetService().DownloadUserList();
            usersContent.Open(new UsersListForm());
        }

        private void addMoviesButton_Click(object sender, EventArgs e)
        {
            moviesContent.Open(new AddMovieForm());
        }

        private void moviesListbutton_Click(object sender, EventArgs e)
        {
            moviesContent.Open(new MoviesAdminListForm());
        }

        private void refreshMoviesListButton_Click(object sender, EventArgs e)
        {
            MoviesAdminServiceImpl.GetService().DownloadMoviesList();
            moviesContent.Open(new MoviesAdminListForm());
        }

        private void hallsListButton_Click(object sender, EventArgs e)
        {
            hallsContent.Open(new HallsAdminListForm());
        }

        private void refreshHallsButton_Click(object sender, EventArgs e)
        {
            HallsAdminServiceImpl.GetService().DownloadHallsList();
            hallsContent.Open(new HallsAdminListForm());
        }

        private void addHallButton_Click(object sender, EventArgs e)
        {
            hallsContent.Open(new AddHallsForm());
        }
    }
}
