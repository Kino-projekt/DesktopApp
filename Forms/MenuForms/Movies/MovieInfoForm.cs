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
using DesktopApp.Forms.MenuForms.Movies.Comments;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Movies
{
    public partial class MovieInfoForm : MaterialForm
    {
        private DesingerService desingerService;
        private Movie movie;
        public MovieInfoForm(Movie movie)
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
            titleLabel.Text ="Tytuł: "+ movie.GetTitle();
            descriptionLabel.Text = "Opis: " + movie.GetDescription();
            directLabel.Text ="Reżyser: " + movie.GetDirector();
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            CommentsForm comments = new CommentsForm(movie);
            comments.Show();
        }
    }
}
