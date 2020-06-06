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
using DesktopApp.Backend.Services.DataServices.CommentsServices;
using DesktopApp.Backend.Services.DataServices.MoviesServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Movies.Comments
{
    public partial class CommentsForm : MaterialForm
    {
        private DesingerService desingerService;
        private Movie movie;
        public CommentsForm(Movie movie)
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(titlePanel);
            this.movie = movie;

            SetLabels();
        }

        private void SetLabels()
        {
            commentsList.Items.Clear();
            titleLabel.Text = movie.GetTitle();
            List<Comment> comments = movie.GetCommentsList();

            foreach (Comment comment in comments)
            {
                commentsList.Items.Add(comment.GetContent());
            }
        }

        private void commentAddButton_Click(object sender, EventArgs e)
        {
            Comment comment = new Comment();
            comment.SetContent(commentTextField.Text);
            comment.SetMovieId(movie.GetId());

            CommentsServiceImpl.GetService().SendComment(comment);
            MoviesServiceImpl.GetService().DownloadMoviesList();
            List<Movie> movies = MoviesServiceImpl.GetService().GetMoviesList();

            Movie update = movies.Find(x => x.GetId() == movie.GetId());
            movie = update;
            SetLabels();
        }
    }
}
