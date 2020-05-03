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
using DesktopApp.Backend.Services.AdminServices.MoviesServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.Movies
{
    public partial class MovieAdminInfoForm : MaterialForm
    {
        private DesingerService desingerService;
        private Movie movie;

        public MovieAdminInfoForm(Movie movie)
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(contentPanel);

            this.movie = movie;
            SetLabels();
        }

        private void SetLabels()
        {
            idLabel.Text = "Numer: " + movie.GetId();
            titleLabel.Text = "Tytuł: " + movie.GetTitle();
            descriptionLabel.Text = "Opis: " + movie.GetDescription();
            directLabel.Text = "Reżyser: " + movie.GetDirector();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MoviesAdminServiceImpl.GetService().DeleteMovie(movie);
        }
    }
}
